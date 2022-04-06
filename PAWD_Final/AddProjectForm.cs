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
    public partial class AddProjectForm : ParentForm {
        public AddProjectForm() {
            InitializeComponent();
        }

        private void AddProjBtn_Click(object sender, EventArgs e) {
            if (TitluProiectInput.Text == "") {
                MessageBox.Show("Introduceti un titlu !");
                return;
            }

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `proiecte` (`titlu`, `descriere`, `id_user`) VALUES (@titlu, @desc, @uid)", db.getConnection());

            command.Parameters.Add("@titlu", MySqlDbType.VarChar).Value = TitluProiectInput.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = DescriereProiectInput.Text;
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userId;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) {
                this.Close();
            } else
                MessageBox.Show("Completeaza campurile !");

            db.closeConnection();

        }
    }
}
