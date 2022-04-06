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
    public partial class ProjectsForm : ParentForm {
        public ProjectsForm() {
            InitializeComponent();
            GenereazaProiecte();
        }

        private void IesireBtn_Click(object sender, EventArgs e) {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AddProjectBtn_Click(object sender, EventArgs e) {
            AddProjectForm addProjectForm = new AddProjectForm();
            addProjectForm.Show();
        }

        private void GenereazaProiecte() {
            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id_proiect, titlu, descriere FROM `proiecte` WHERE id_user=@uid", db.getConnection());
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows) {
                int index = ProiecteDGV.Rows.Add();

                ProiecteDGV.Rows[index].Cells[0].Value = row["id_proiect"];
                ProiecteDGV.Rows[index].Cells[1].Value = row["titlu"].ToString();
                ProiecteDGV.Rows[index].Cells[2].Value = row["descriere"].ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            ProiecteDGV.DataSource = null;
            ProiecteDGV.Rows.Clear();

            GenereazaProiecte();
        }

        private void ProiecteDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            projectId = Int32.Parse(ProiecteDGV.Rows[e.RowIndex].Cells["nrProiect"].Value.ToString());
            this.Close();
            TodosForm todosForm = new TodosForm();
            todosForm.Show();
        }
    }
}
