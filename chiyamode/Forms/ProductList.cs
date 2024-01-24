using System;
using System.Windows.Forms;

namespace chiyamode.Forms
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
            Load += LoadMeth;
        }

        private void LoadMeth(object sender, EventArgs e)
        {
            for (var i = 0; i < 5; i++)
            {
                var productCard = new ProductCard();
                productCard.Price = "700";
                productCard.Category = "Clothes";
                productCard.Title = "Jeans pant Luois Vi";


                Controls.Add(productCard);
            }
        }
    }
}