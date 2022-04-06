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
    public partial class TodosForm : ParentForm {
        public TodosForm() {
            InitializeComponent();
            GenereazaTodo();
        }

        private void AddTodoBtn_Click(object sender, EventArgs e) {
            AddTodoForm addTodoForm = new AddTodoForm();
            addTodoForm.Show();
        }

        private void GenereazaTodo() {
            db db = new db();
            int counter = 1;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT titlu, descriere, prioritate, deadline FROM `todos` WHERE id_proiect=@pid", db.getConnection());
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = projectId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows) {
                int index = TodoDGV.Rows.Add();

                TodoDGV.Rows[index].Cells[0].Value = counter;
                TodoDGV.Rows[index].Cells[1].Value = row["titlu"].ToString();
                TodoDGV.Rows[index].Cells[2].Value = row["descriere"].ToString();
                TodoDGV.Rows[index].Cells[3].Value = row["prioritate"].ToString();
                TodoDGV.Rows[index].Cells[4].Value = row["deadline"].ToString();

                counter++;
            }
        }

        private void InapoiBtn_Click(object sender, EventArgs e) {
            this.Close();
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            TodoDGV.DataSource = null;
            TodoDGV.Rows.Clear();

            GenereazaTodo();
        }
    }
}
