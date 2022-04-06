namespace PAWD_Final {
    partial class ProjectsForm {
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
            this.AuthHeader = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.IesireBtn = new System.Windows.Forms.Button();
            this.ProiecteDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nrProiect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluProiect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereProiect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProiecteDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthHeader
            // 
            this.AuthHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(1352, 106);
            this.AuthHeader.TabIndex = 1;
            this.AuthHeader.Text = "Proiecte";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectBtn.ForeColor = System.Drawing.Color.White;
            this.AddProjectBtn.Location = new System.Drawing.Point(593, 119);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(159, 39);
            this.AddProjectBtn.TabIndex = 2;
            this.AddProjectBtn.Text = "Adauga proiect";
            this.AddProjectBtn.UseVisualStyleBackColor = false;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // IesireBtn
            // 
            this.IesireBtn.BackColor = System.Drawing.Color.White;
            this.IesireBtn.FlatAppearance.BorderSize = 0;
            this.IesireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IesireBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IesireBtn.Location = new System.Drawing.Point(1235, 32);
            this.IesireBtn.Name = "IesireBtn";
            this.IesireBtn.Size = new System.Drawing.Size(83, 37);
            this.IesireBtn.TabIndex = 3;
            this.IesireBtn.Text = "Iesire";
            this.IesireBtn.UseVisualStyleBackColor = false;
            this.IesireBtn.Click += new System.EventHandler(this.IesireBtn_Click);
            // 
            // ProiecteDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ProiecteDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProiecteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProiecteDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProiecteDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProiecteDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProiecteDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProiecteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProiecteDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrProiect,
            this.titluProiect,
            this.descriereProiect});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProiecteDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProiecteDGV.Location = new System.Drawing.Point(224, 190);
            this.ProiecteDGV.Name = "ProiecteDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProiecteDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ProiecteDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProiecteDGV.RowTemplate.Height = 24;
            this.ProiecteDGV.Size = new System.Drawing.Size(900, 520);
            this.ProiecteDGV.TabIndex = 4;
            this.ProiecteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProiecteDGV_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PAWD_Final.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(775, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nrProiect
            // 
            this.nrProiect.FillWeight = 75.56384F;
            this.nrProiect.HeaderText = "ID proiect";
            this.nrProiect.Name = "nrProiect";
            // 
            // titluProiect
            // 
            this.titluProiect.FillWeight = 76.14214F;
            this.titluProiect.HeaderText = "Titlul proiectului";
            this.titluProiect.Name = "titluProiect";
            // 
            // descriereProiect
            // 
            this.descriereProiect.FillWeight = 148.294F;
            this.descriereProiect.HeaderText = "Descriere";
            this.descriereProiect.Name = "descriereProiect";
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 738);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProiecteDGV);
            this.Controls.Add(this.IesireBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.AuthHeader);
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProiecteDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button IesireBtn;
        private System.Windows.Forms.DataGridView ProiecteDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrProiect;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluProiect;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereProiect;
    }
}