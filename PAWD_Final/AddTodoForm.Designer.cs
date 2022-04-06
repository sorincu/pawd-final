namespace PAWD_Final {
    partial class AddTodoForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriereTodoInput = new System.Windows.Forms.TextBox();
            this.AddProjBtn = new System.Windows.Forms.Button();
            this.TitluTodoInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prior1 = new System.Windows.Forms.RadioButton();
            this.prior2 = new System.Windows.Forms.RadioButton();
            this.prior3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.panel2.Size = new System.Drawing.Size(955, 122);
            this.panel2.TabIndex = 22;
            // 
            // AuthHeader
            // 
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(955, 122);
            this.AuthHeader.TabIndex = 0;
            this.AuthHeader.Text = "Todo nou";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descriere todo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titlul proiectului:";
            // 
            // DescriereTodoInput
            // 
            this.DescriereTodoInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriereTodoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriereTodoInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriereTodoInput.Location = new System.Drawing.Point(48, 317);
            this.DescriereTodoInput.Multiline = true;
            this.DescriereTodoInput.Name = "DescriereTodoInput";
            this.DescriereTodoInput.Size = new System.Drawing.Size(386, 147);
            this.DescriereTodoInput.TabIndex = 25;
            // 
            // AddProjBtn
            // 
            this.AddProjBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddProjBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjBtn.ForeColor = System.Drawing.Color.White;
            this.AddProjBtn.Location = new System.Drawing.Point(354, 529);
            this.AddProjBtn.Name = "AddProjBtn";
            this.AddProjBtn.Size = new System.Drawing.Size(258, 74);
            this.AddProjBtn.TabIndex = 24;
            this.AddProjBtn.Text = "Adauga";
            this.AddProjBtn.UseVisualStyleBackColor = false;
            this.AddProjBtn.Click += new System.EventHandler(this.AddProjBtn_Click);
            // 
            // TitluTodoInput
            // 
            this.TitluTodoInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitluTodoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitluTodoInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitluTodoInput.Location = new System.Drawing.Point(48, 200);
            this.TitluTodoInput.Multiline = true;
            this.TitluTodoInput.Name = "TitluTodoInput";
            this.TitluTodoInput.Size = new System.Drawing.Size(386, 64);
            this.TitluTodoInput.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Titlu todo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prioritate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Deadline:";
            // 
            // prior1
            // 
            this.prior1.AutoSize = true;
            this.prior1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prior1.Location = new System.Drawing.Point(533, 222);
            this.prior1.Name = "prior1";
            this.prior1.Size = new System.Drawing.Size(87, 29);
            this.prior1.TabIndex = 31;
            this.prior1.TabStop = true;
            this.prior1.Text = "Joasa";
            this.prior1.UseVisualStyleBackColor = true;
            // 
            // prior2
            // 
            this.prior2.AutoSize = true;
            this.prior2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prior2.Location = new System.Drawing.Point(655, 222);
            this.prior2.Name = "prior2";
            this.prior2.Size = new System.Drawing.Size(87, 29);
            this.prior2.TabIndex = 32;
            this.prior2.TabStop = true;
            this.prior2.Text = "Medie";
            this.prior2.UseVisualStyleBackColor = true;
            // 
            // prior3
            // 
            this.prior3.AutoSize = true;
            this.prior3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prior3.Location = new System.Drawing.Point(782, 222);
            this.prior3.Name = "prior3";
            this.prior3.Size = new System.Drawing.Size(80, 29);
            this.prior3.TabIndex = 33;
            this.prior3.TabStop = true;
            this.prior3.Text = "Inalta";
            this.prior3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(554, 376);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(293, 27);
            this.dateTimePicker.TabIndex = 34;
            // 
            // AddTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 646);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.prior3);
            this.Controls.Add(this.prior2);
            this.Controls.Add(this.prior1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriereTodoInput);
            this.Controls.Add(this.AddProjBtn);
            this.Controls.Add(this.TitluTodoInput);
            this.Name = "AddTodoForm";
            this.Text = "AddTodoForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriereTodoInput;
        private System.Windows.Forms.Button AddProjBtn;
        private System.Windows.Forms.TextBox TitluTodoInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton prior1;
        private System.Windows.Forms.RadioButton prior2;
        private System.Windows.Forms.RadioButton prior3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}