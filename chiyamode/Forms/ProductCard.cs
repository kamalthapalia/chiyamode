using System;
using System.IO;
using System.Windows.Forms;
using chiyamode.Pages;

namespace chiyamode.Forms
{
    public partial class ProductCard : UserControl
    {
        // Remove the public fields
        private string category;
        public int id;
        private string img;
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


        public string Img
        {
            get => img;
            set
            {
                img = value;

                // Combine the destination folder with the product name as the file name
                var imagePath = Path.Combine(@"D:\Products Images", img);
                // Set the ImageLocation of the thumbnail
                thumbnail.ImageLocation = imagePath;
            }
        }

        public string Price
        {
            get => price;
            set
            {
                price = value;
                priceLabel.Text = "Rs. " + value;
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

        private string GetImageFormat(string imageName)
        {
            // Get the image format from the file extension
            return Path.GetExtension(imageName).Replace(".", "");
        }

        private void LoadMeth(object sender, EventArgs e)
        {
            addToCart.Click += AddToCartOnClick;
        }

        private void AddToCartOnClick(object sender, EventArgs e)
        {
            Cart.addToSet(id);
        }
    }
}