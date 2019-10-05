namespace loginPage
{
    partial class Form
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
            this.user = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DaxilOl = new System.Windows.Forms.Button();
            this.Qeydiyyat = new System.Windows.Forms.Button();
            this.Cixis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user.Location = new System.Drawing.Point(36, 38);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(37, 13);
            this.user.TabIndex = 0;
            this.user.Text = "USER";
            this.user.Click += new System.EventHandler(this.User_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(36, 79);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "PASSWORD";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 3;
            // 
            // DaxilOl
            // 
            this.DaxilOl.BackColor = System.Drawing.SystemColors.Highlight;
            this.DaxilOl.Location = new System.Drawing.Point(39, 115);
            this.DaxilOl.Name = "DaxilOl";
            this.DaxilOl.Size = new System.Drawing.Size(75, 39);
            this.DaxilOl.TabIndex = 4;
            this.DaxilOl.Text = "DAXIL OL";
            this.DaxilOl.UseVisualStyleBackColor = false;
            this.DaxilOl.Click += new System.EventHandler(this.DaxilOl_Click);
            // 
            // Qeydiyyat
            // 
            this.Qeydiyyat.BackColor = System.Drawing.SystemColors.Highlight;
            this.Qeydiyyat.Location = new System.Drawing.Point(144, 115);
            this.Qeydiyyat.Name = "Qeydiyyat";
            this.Qeydiyyat.Size = new System.Drawing.Size(80, 39);
            this.Qeydiyyat.TabIndex = 5;
            this.Qeydiyyat.Text = "QEYDIYYAT";
            this.Qeydiyyat.UseVisualStyleBackColor = false;
            this.Qeydiyyat.Click += new System.EventHandler(this.Qeydiyyat_Click);
            // 
            // Cixis
            // 
            this.Cixis.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cixis.Location = new System.Drawing.Point(244, 115);
            this.Cixis.Name = "Cixis";
            this.Cixis.Size = new System.Drawing.Size(75, 39);
            this.Cixis.TabIndex = 6;
            this.Cixis.Text = "CIXIS";
            this.Cixis.UseVisualStyleBackColor = false;
            this.Cixis.Click += new System.EventHandler(this.Cixis_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 218);
            this.Controls.Add(this.Cixis);
            this.Controls.Add(this.Qeydiyyat);
            this.Controls.Add(this.DaxilOl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.user);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DaxilOl;
        private System.Windows.Forms.Button Qeydiyyat;
        private System.Windows.Forms.Button Cixis;
    }
}

