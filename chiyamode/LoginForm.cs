using chiyamode.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chiyamode
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)

        {
            incorrect.Visible = false;
            AttachEventHandlers();
            usermaneInp.Focus();
        }

        private void AttachEventHandlers()
        {
            loginBtn.Click += loginBtn_Click;
            registerNow.Click += registerNow_Click;
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = usermaneInp.Text;
            var password = passwordInp.Text;
            if(username=="kamal"&& password=="12345")
            {
                var dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                incorrect.Visible = true;
            }
        }

        private void registerNow_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.ShowDialog();
        }

       
        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}