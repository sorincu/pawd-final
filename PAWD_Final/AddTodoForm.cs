using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWD_Final {
    public partial class AddTodoForm : ParentForm {
        public AddTodoForm() {
            InitializeComponent();
        }

        private void AddProjBtn_Click(object sender, EventArgs e) {
           if (TitluTodoInput.Text == "") {
               MessageBox.Show("Introduceti un titlu !");
               return;
           }

            if (DescriereTodoInput.Text == "") {
                MessageBox.Show("Introduceti o descriere !");
                return;
            }

            if (prior1.Checked == false && prior2.Checked == false && prior3.Checked == false) {
                MessageBox.Show("Alege prioritatea todo-ului !");
                return;
            }

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `todos` (`titlu`, `descriere`, `prioritate`, `deadline`, `id_proiect`) VALUES (@titlu, @desc, @pr, @dt, @pid)", db.getConnection());

            command.Parameters.Add("@titlu", MySqlDbType.VarChar).Value = TitluTodoInput.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = DescriereTodoInput.Text;

            if (prior1.Checked == true) {
                command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = prior1.Text;
            } else if (prior2.Checked == true) {
                command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = prior2.Text;
            } else command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = prior3.Text;

            command.Parameters.Add("@dt", MySqlDbType.Date).Value = dateTimePicker.Value;
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = projectId;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) {
                this.Close();
            } else
                MessageBox.Show("Completeaza campurile !");

            db.closeConnection();
        }
    }
}
