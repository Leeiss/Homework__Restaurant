using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework__Restaurant
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }
        private void lbl_text_Click(object sender, EventArgs e)
        {

        }

        private void to_come_in_btn_Click(object sender, EventArgs e)
        {
            if (tb_enteredPassword.Text == "admin")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
