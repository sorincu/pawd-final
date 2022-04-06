namespace PAWD_Final {
    partial class RegisterForm {
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
            this.InregBtn = new System.Windows.Forms.Button();
            this.InregPassInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InregLoginInput = new System.Windows.Forms.TextBox();
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
            this.panel2.Size = new System.Drawing.Size(487, 122);
            this.panel2.TabIndex = 7;
            // 
            // AuthHeader
            // 
            this.AuthHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthHeader.ForeColor = System.Drawing.Color.White;
            this.AuthHeader.Location = new System.Drawing.Point(0, 0);
            this.AuthHeader.Name = "AuthHeader";
            this.AuthHeader.Size = new System.Drawing.Size(487, 122);
            this.AuthHeader.TabIndex = 0;
            this.AuthHeader.Text = "Inregistrare";
            this.AuthHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InregBtn
            // 
            this.InregBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InregBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InregBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregBtn.ForeColor = System.Drawing.Color.White;
            this.InregBtn.Location = new System.Drawing.Point(105, 345);
            this.InregBtn.Name = "InregBtn";
            this.InregBtn.Size = new System.Drawing.Size(258, 74);
            this.InregBtn.TabIndex = 12;
            this.InregBtn.Text = "Confirma";
            this.InregBtn.UseVisualStyleBackColor = false;
            this.InregBtn.Click += new System.EventHandler(this.InregBtn_Click);
            // 
            // InregPassInput
            // 
            this.InregPassInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregPassInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InregPassInput.Location = new System.Drawing.Point(89, 244);
            this.InregPassInput.Name = "InregPassInput";
            this.InregPassInput.PasswordChar = '*';
            this.InregPassInput.Size = new System.Drawing.Size(386, 56);
            this.InregPassInput.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PAWD_Final.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(12, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // InregLoginInput
            // 
            this.InregLoginInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InregLoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregLoginInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InregLoginInput.Location = new System.Drawing.Point(89, 164);
            this.InregLoginInput.Multiline = true;
            this.InregLoginInput.Name = "InregLoginInput";
            this.InregLoginInput.Size = new System.Drawing.Size(386, 64);
            this.InregLoginInput.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PAWD_Final.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.InregBtn);
            this.Controls.Add(this.InregPassInput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.InregLoginInput);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthHeader;
        private System.Windows.Forms.Button InregBtn;
        private System.Windows.Forms.TextBox InregPassInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox InregLoginInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}