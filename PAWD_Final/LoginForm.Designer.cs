namespace PAWD_Final {
    partial class LoginForm {
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
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UtilizatorNouBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.AuthHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 122);
            this.panel2.TabIndex = 0;
            // 
            // AuthHeader
            // 
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(480, 122);
            this.AuthHeader.TabIndex = 0;
            this.AuthHeader.Text = "Autentificare";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginInput
            // 
            this.LoginInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginInput.Location = new System.Drawing.Point(82, 183);
            this.LoginInput.Multiline = true;
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(386, 64);
            this.LoginInput.TabIndex = 2;
            // 
            // PassInput
            // 
            this.PassInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PassInput.Location = new System.Drawing.Point(82, 263);
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.Size = new System.Drawing.Size(386, 56);
            this.PassInput.TabIndex = 4;
            this.PassInput.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(105, 360);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(258, 74);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Intra";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UtilizatorNouBtn
            // 
            this.UtilizatorNouBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UtilizatorNouBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizatorNouBtn.ForeColor = System.Drawing.Color.White;
            this.UtilizatorNouBtn.Location = new System.Drawing.Point(164, 452);
            this.UtilizatorNouBtn.Name = "UtilizatorNouBtn";
            this.UtilizatorNouBtn.Size = new System.Drawing.Size(137, 36);
            this.UtilizatorNouBtn.TabIndex = 6;
            this.UtilizatorNouBtn.Text = "Utilizator nou";
            this.UtilizatorNouBtn.UseVisualStyleBackColor = false;
            this.UtilizatorNouBtn.Click += new System.EventHandler(this.UtilizatorNouBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PAWD_Final.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(12, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PAWD_Final.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 521);
            this.Controls.Add(this.UtilizatorNouBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button UtilizatorNouBtn;
    }
}