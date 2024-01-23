using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            date.Text = DateTime.Now.ToString().Split()[0]+" "+ DateTime.Now.ToString("dddd");
            timer1.Interval = 1000; 
            timer1.Enabled = true;  
            timer1.Tick += Timer1_Tick;
            this.WindowState = FormWindowState.Maximized;

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
