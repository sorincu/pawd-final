namespace PAWD_Final {
    partial class TodosForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TodoDGV = new System.Windows.Forms.DataGridView();
            this.nrProiect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluTodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereTodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioritate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IesireBtn = new System.Windows.Forms.Button();
            this.AddTodoBtn = new System.Windows.Forms.Button();
            this.AuthHeader = new System.Windows.Forms.Label();
            this.InapoiBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TodoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TodoDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TodoDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TodoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TodoDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TodoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TodoDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TodoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrProiect,
            this.titluTodo,
            this.descriereTodo,
            this.Prioritate,
            this.Deadline});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodoDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TodoDGV.Location = new System.Drawing.Point(155, 188);
            this.TodoDGV.Name = "TodoDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TodoDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TodoDGV.RowTemplate.Height = 24;
            this.TodoDGV.Size = new System.Drawing.Size(1039, 520);
            this.TodoDGV.TabIndex = 9;
            // 
            // nrProiect
            // 
            this.nrProiect.FillWeight = 75.56384F;
            this.nrProiect.HeaderText = "Nr. todo";
            this.nrProiect.Name = "nrProiect";
            // 
            // titluTodo
            // 
            this.titluTodo.FillWeight = 76.14214F;
            this.titluTodo.HeaderText = "Titlul todo";
            this.titluTodo.Name = "titluTodo";
            // 
            // descriereTodo
            // 
            this.descriereTodo.FillWeight = 148.294F;
            this.descriereTodo.HeaderText = "Descriere";
            this.descriereTodo.Name = "descriereTodo";
            // 
            // Prioritate
            // 
            this.Prioritate.HeaderText = "Prioritate";
            this.Prioritate.Name = "Prioritate";
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            // 
            // IesireBtn
            // 
            this.IesireBtn.BackColor = System.Drawing.Color.White;
            this.IesireBtn.FlatAppearance.BorderSize = 0;
            this.IesireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IesireBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IesireBtn.Location = new System.Drawing.Point(976, -98);
            this.IesireBtn.Name = "IesireBtn";
            this.IesireBtn.Size = new System.Drawing.Size(83, 37);
            this.IesireBtn.TabIndex = 8;
            this.IesireBtn.Text = "Iesire";
            this.IesireBtn.UseVisualStyleBackColor = false;
            // 
            // AddTodoBtn
            // 
            this.AddTodoBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddTodoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTodoBtn.ForeColor = System.Drawing.Color.White;
            this.AddTodoBtn.Location = new System.Drawing.Point(587, 124);
            this.AddTodoBtn.Name = "AddTodoBtn";
            this.AddTodoBtn.Size = new System.Drawing.Size(159, 39);
            this.AddTodoBtn.TabIndex = 7;
            this.AddTodoBtn.Text = "Adauga todo";
            this.AddTodoBtn.UseVisualStyleBackColor = false;
            this.AddTodoBtn.Click += new System.EventHandler(this.AddTodoBtn_Click);
            // 
            // AuthHeader
            // 
            this.AuthHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(1338, 106);
            this.AuthHeader.TabIndex = 6;
            this.AuthHeader.Text = "Todo";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InapoiBtn
            // 
            this.InapoiBtn.BackColor = System.Drawing.Color.White;
            this.InapoiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InapoiBtn.FlatAppearance.BorderSize = 0;
            this.InapoiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InapoiBtn.Location = new System.Drawing.Point(21, 26);
            this.InapoiBtn.Name = "InapoiBtn";
            this.InapoiBtn.Size = new System.Drawing.Size(55, 54);
            this.InapoiBtn.TabIndex = 11;
            this.InapoiBtn.Text = "<";
            this.InapoiBtn.UseVisualStyleBackColor = false;
            this.InapoiBtn.Click += new System.EventHandler(this.InapoiBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Image = global::PAWD_Final.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(766, 124);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(37, 39);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshBtn.TabIndex = 12;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PAWD_Final.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(516, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TodosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 740);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.InapoiBtn);
            this.Controls.Add(this.TodoDGV);
            this.Controls.Add(this.IesireBtn);
            this.Controls.Add(this.AddTodoBtn);
            this.Controls.Add(this.AuthHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TodosForm";
            this.Text = "TodosForm";
            ((System.ComponentModel.ISupportInitialize)(this.TodoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TodoDGV;
        private System.Windows.Forms.Button IesireBtn;
        private System.Windows.Forms.Button AddTodoBtn;
        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InapoiBtn;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrProiect;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioritate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
    }
}