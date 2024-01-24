using System;
using System.Linq;
using System.Windows.Forms;
using chiyamode.Repository;

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
            var productRepository = new ProductRepository();
            var products = productRepository.GetAll();

            var numberOfProducts = products.Count();

            MessageBox.Show($"Number of products: {numberOfProducts}");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AttachEventHandlers()
        {
        }
    }
}