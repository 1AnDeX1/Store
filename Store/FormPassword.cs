using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var password = textBox1.Text;

            if (checkBox2.Checked == true)
            {
                if (password == "admin")
                {
                    this.Hide();


                    FormForAdmin Form1 = new FormForAdmin();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                if (password == "seller")
                {
                    this.Hide();

                    FormForSeller formForSeller = new FormForSeller();
                    formForSeller.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            
            
            
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {

            textBox1.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
