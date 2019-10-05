namespace loginPage
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cixis = new System.Windows.Forms.Button();
            this.QeydOl = new System.Windows.Forms.Button();
            this.Geriye = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cixis
            // 
            this.Cixis.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cixis.Location = new System.Drawing.Point(467, 248);
            this.Cixis.Name = "Cixis";
            this.Cixis.Size = new System.Drawing.Size(75, 39);
            this.Cixis.TabIndex = 13;
            this.Cixis.Text = "CIXIS";
            this.Cixis.UseVisualStyleBackColor = false;
            // 
            // QeydOl
            // 
            this.QeydOl.BackColor = System.Drawing.SystemColors.Highlight;
            this.QeydOl.Location = new System.Drawing.Point(367, 248);
            this.QeydOl.Name = "QeydOl";
            this.QeydOl.Size = new System.Drawing.Size(80, 39);
            this.QeydOl.TabIndex = 12;
            this.QeydOl.Text = "QEYD OL";
            this.QeydOl.UseVisualStyleBackColor = false;
            this.QeydOl.Click += new System.EventHandler(this.QeydOl_Click);
            // 
            // Geriye
            // 
            this.Geriye.BackColor = System.Drawing.SystemColors.Highlight;
            this.Geriye.Location = new System.Drawing.Point(262, 248);
            this.Geriye.Name = "Geriye";
            this.Geriye.Size = new System.Drawing.Size(75, 39);
            this.Geriye.TabIndex = 11;
            this.Geriye.Text = "GERIYE";
            this.Geriye.UseVisualStyleBackColor = false;
            this.Geriye.Click += new System.EventHandler(this.Geriye_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(259, 212);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 13);
            this.Password.TabIndex = 8;
            this.Password.Text = "PASSWORD";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.user.Location = new System.Drawing.Point(259, 171);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(37, 13);
            this.user.TabIndex = 7;
            this.user.Text = "USER";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cixis);
            this.Controls.Add(this.QeydOl);
            this.Controls.Add(this.Geriye);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.user);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cixis;
        private System.Windows.Forms.Button QeydOl;
        private System.Windows.Forms.Button Geriye;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label user;
    }
}