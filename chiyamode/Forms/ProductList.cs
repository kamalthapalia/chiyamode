using System;
using System.Collections.Generic;
using System.Windows.Forms;
using chiyamode.Models;
using chiyamode.Repository;
using chiyamode.utils;

namespace chiyamode.Forms
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
            Load += LoadMeth;
        }

        public IEnumerable<Products> products { get; set; }

        private void LoadMeth(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            var productRepository = new ProductRepository();
            var prods = productRepository.GetAll();
            foreach (var product in prods)
            {
                var productCard = new ProductCard();
                productCard.Price = product.Price.ToString();
                productCard.Category = Data.menuCategories[product.Category];
                productCard.Title = product.Name;
                productCard.Img = product.image;
                productCard.id = product.Id;
                flowLayoutPanel1.Controls.Add(productCard);
            }
        }
    }
}