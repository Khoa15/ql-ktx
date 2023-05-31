using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ql_ktx
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool CheckPassword(string user, String pass)
        {
            if (user == "sa" && pass == "123")
            {
                return true;
            }
            else
                return false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (CheckPassword(txtusername.Text, txtpassword.Text))
            {
                MessageBox.Show("Login successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                mainFormKTX hp = new mainFormKTX();
                hp.Show();
            }
            else
            {
                MessageBox.Show("Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
