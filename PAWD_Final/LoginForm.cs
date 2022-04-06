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
    public class ParentForm : Form {
        public static Int32 userId;
        public static Int32 projectId;

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // ParentForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 366);
            this.Name = "ParentForm";
            this.ResumeLayout(false);

        }

        private void ParentForm_Load(object sender, EventArgs e) {

        }
    }

    public partial class LoginForm : ParentForm {
        public LoginForm() {
            InitializeComponent();

            this.PassInput.AutoSize = false;
            this.PassInput.Size = new Size(this.PassInput.Size.Width, 54);
        }

        private void LoginBtn_Click(object sender, EventArgs e) {
            String loginUtil = LoginInput.Text;
            String passUtil = PassInput.Text;

            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `utilizatori` WHERE `login` = @lu AND `pass` = @pu", db.getConnection() );
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginUtil;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = passUtil;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                foreach (DataRow row in table.Rows) {
                    userId = Int32.Parse(row["id"].ToString());
                }
                this.Hide();
                ProjectsForm projectsForm = new ProjectsForm();
                projectsForm.Show();
            }  else
                MessageBox.Show("Date incorecte. Incearca din nou !");
        }

        private void UtilizatorNouBtn_Click(object sender, EventArgs e) {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
