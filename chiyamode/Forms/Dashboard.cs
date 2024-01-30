using System;
using System.Windows.Forms;

namespace chiyamode.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            AttachEventHandlers();
            OnLoadEvents();
        }

        private void OnLoadEvents()
        {
            date.Text = DateTime.Now.ToString().Split()[0] + " " + DateTime.Now.ToString("dddd");
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            WindowState = FormWindowState.Maximized;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AttachEventHandlers()
        {
            productsBtn.Click += ProductsBtnOnClick;
            checkOutBtn.Click += CheckOutBtnOnClick;
        }

        private void CheckOutBtnOnClick(object sender, EventArgs e)
        {
            cart1.Visible = true;
            productsPage1.Visible = false;
        }

        private void ProductsBtnOnClick(object sender, EventArgs e)
        {
            cart1.Visible = false;
            productsPage1.Visible = true;
        }
    }
}