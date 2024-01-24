using System;
using System.Windows.Forms;

namespace chiyamode.Forms
{
    public partial class ProductCard : UserControl
    {
        // Remove the public fields
        private string category;
        private string price;
        private string title;

        public ProductCard()
        {
            InitializeComponent();
            Load += LoadMeth;
        }

        // Use properties instead
        public string Category
        {
            get => category;
            set
            {
                category = value;
                categoryLbl.Text = value;
            }
        }

        public string Price
        {
            get => price;
            set
            {
                price = value;
                priceLabel.Text = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                titleLabel.Text = value;
            }
        }

        private void LoadMeth(object sender, EventArgs e)
        {
            // You can remove this method if it's not needed
        }
    }
}