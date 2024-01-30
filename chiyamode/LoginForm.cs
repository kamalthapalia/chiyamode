using System;
using System.Windows.Forms;
using chiyamode.Forms;
using chiyamode.Repository;

namespace chiyamode
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Load += LoginForm_Load;
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
            var user = new UserRepository();
            //user.Login(username, password))
            if (true)
            {
                var dash = new Dashboard();
                Hide();
                dash.ShowDialog();
                Show();
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
            Close();
        }
    }
}