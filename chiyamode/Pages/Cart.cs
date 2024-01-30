using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace chiyamode.Pages
{
    public partial class Cart : UserControl
    {
        public static Dictionary<int, int> OrderProducts = new Dictionary<int, int>();

        public Cart()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        public static void addToSet(int id)
        {
            MessageBox.Show(id.ToString());
            if (OrderProducts.ContainsKey(id))
                OrderProducts[id]++;
            else
                OrderProducts.Add(id, 1);
        }


        private void OnLoad(object sender, EventArgs e)
        {
        }
    }
}