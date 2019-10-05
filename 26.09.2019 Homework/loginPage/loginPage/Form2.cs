using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form esas = new Form();

        private void QeydOl_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string userId = textBox1 + " " + textBox2;
                File.AppendAllText("Users.text", userId + Environment.NewLine);
                this.Hide();
                esas.Show();
            }
            else
            {
                MessageBox.Show("Xanalari doldurun");
            }

        }

        private void Geriye_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
    }
}
