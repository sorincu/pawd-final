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
    public partial class RegisterForm : ParentForm {
        public RegisterForm() {
            InitializeComponent();
        }

        private void InregBtn_Click(object sender, EventArgs e) {
            if (InregLoginInput.Text == "") {
                MessageBox.Show("Introdu login !");
                return;
            }

            if (InregPassInput.Text == "") {
                MessageBox.Show("Introdu parola !");
                return;
            }

            if (verificaLoginExistent())
                return;

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `utilizatori` (`login`, `pass`) VALUES (@login, @pass)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = InregLoginInput.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = InregPassInput.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) {
                MessageBox.Show("Inregistrare cu succes !");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }  else
                MessageBox.Show("Completeaza campurile !");

            db.closeConnection();
        }

        public Boolean verificaLoginExistent() {
            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `utilizatori` WHERE `login` = @lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = InregLoginInput.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                MessageBox.Show("Introdu alt login !");
                return true;
            } else return false;
        }
    }
}
