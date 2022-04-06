namespace PAWD_Final {
    partial class AddProjectForm {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuthHeader = new System.Windows.Forms.Label();
            this.AddProjBtn = new System.Windows.Forms.Button();
            this.TitluProiectInput = new System.Windows.Forms.TextBox();
            this.DescriereProiectInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.AuthHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 122);
            this.panel2.TabIndex = 13;
            // 
            // AuthHeader
            // 
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(498, 122);
            this.AuthHeader.TabIndex = 0;
            this.AuthHeader.Text = "Proiect nou";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProjBtn
            // 
            this.AddProjBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddProjBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjBtn.ForeColor = System.Drawing.Color.White;
            this.AddProjBtn.Location = new System.Drawing.Point(117, 504);
            this.AddProjBtn.Name = "AddProjBtn";
            this.AddProjBtn.Size = new System.Drawing.Size(258, 74);
            this.AddProjBtn.TabIndex = 18;
            this.AddProjBtn.Text = "Adauga";
            this.AddProjBtn.UseVisualStyleBackColor = false;
            this.AddProjBtn.Click += new System.EventHandler(this.AddProjBtn_Click);
            // 
            // TitluProiectInput
            // 
            this.TitluProiectInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitluProiectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluProiectInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitluProiectInput.Location = new System.Drawing.Point(48, 190);
            this.TitluProiectInput.Multiline = true;
            this.TitluProiectInput.Name = "TitluProiectInput";
            this.TitluProiectInput.Size = new System.Drawing.Size(386, 64);
            this.TitluProiectInput.TabIndex = 15;
            // 
            // DescriereProiectInput
            // 
            this.DescriereProiectInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriereProiectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriereProiectInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriereProiectInput.Location = new System.Drawing.Point(48, 323);
            this.DescriereProiectInput.Multiline = true;
            this.DescriereProiectInput.Name = "DescriereProiectInput";
            this.DescriereProiectInput.Size = new System.Drawing.Size(386, 147);
            this.DescriereProiectInput.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Titlul proiectului:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descrierea proiectului:";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriereProiectInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddProjBtn);
            this.Controls.Add(this.TitluProiectInput);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.Button AddProjBtn;
        private System.Windows.Forms.TextBox TitluProiectInput;
        private System.Windows.Forms.TextBox DescriereProiectInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}