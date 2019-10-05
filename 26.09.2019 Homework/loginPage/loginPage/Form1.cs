using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        Form2 qeydiyyat = new Form2();
        private void DaxilOl_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Login ve ya Parol duzgun deyil");
            }
        }

 

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void Cixis_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Qeydiyyat_Click(object sender, EventArgs e)
        {
            this.Hide();
            qeydiyyat.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
