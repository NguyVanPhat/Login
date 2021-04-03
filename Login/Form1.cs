using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
            string userName, passWord;
            userName = txtUserName.Text;
            passWord = txtPassword.Text;
            if (userName == "admin" && passWord == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong","Thong bao");
            }
            else {
                MessageBox.Show("Dang nhap that bai", "Thong bao");
            }
		}
	}
}
