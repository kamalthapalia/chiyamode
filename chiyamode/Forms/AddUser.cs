using System;
using System.Windows.Forms;
using chiyamode.Models;
using chiyamode.Repository;

namespace chiyamode.Forms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            EventsHandlers();
        }

        private void EventsHandlers()
        {
            closeBtn.Click += CloseBtn_Click;
            addUserBtn.Click += AddUserBtn_Click;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var users = new Users();
            var userRepository = new UserRepository();
            users.Username = usermaneInp.Text.Trim();
            users.Password = passwordInp.Text.Trim();
            var saved = userRepository.Save(users);
            if (saved.Id > -1) MessageBox.Show("Success i guess");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            WinClose();
        }

        private void WinClose()
        {
            Close();
        }

        private void registerNow_Click(object sender, EventArgs e)
        {
            WinClose();
        }
    }
}