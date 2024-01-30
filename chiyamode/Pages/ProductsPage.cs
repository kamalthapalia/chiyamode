using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using chiyamode.Models;
using chiyamode.Repository;
using chiyamode.utils;

namespace chiyamode.Pages
{
    public partial class ProductsPage : UserControl
    {
        private readonly string destinationFolder = @"D:\Products Images";
        private string fileName;
        private string imgname;

        private string selectedImagePath;

        public ProductsPage()
        {
            InitializeComponent();
            Load += LoadMeth;
        }

        private void LoadMeth(object sender, EventArgs e)
        {
            catVal.Items.AddRange(Data.menuCategories);
            panelAddProd.Visible = false;
            EventHandlers();
        }


        private void EventHandlers()
        {
            closeBtn.Click += CloseBtnOnClick;
            addProduct.Click += AddProductOnClick;
            fileBtn.Click += FileBtnOnClick;
            submitProductBtn.Click += SubmitProductBtnOnClick;
        }

        private void SubmitProductBtnOnClick(object sender, EventArgs e)
        {
            var product = new Products();
            product.Name = nameVal.Text.Trim();
            product.Price = long.Parse(priceVal.Text.Trim());
            product.Category = catVal.SelectedIndex;
            product.image = imgname;
            var productRepository = new ProductRepository();

            if (productRepository.FindByField("Name", product.Name).Any())
            {
                MessageBox.Show("Product name cannot repeat.");
            }
            else
            {
                var prod = productRepository.Save(product);
                if (prod.Id > 1) MessageBox.Show("prod added iguess");
                productList1.GetData();
            }

            if (selectedImagePath != null && destinationFolder != null && fileName != null)
            {
                if (!Directory.Exists(destinationFolder)) Directory.CreateDirectory(destinationFolder);
                var destinationPath = Path.Combine(destinationFolder, imgname);


                File.Copy(selectedImagePath, destinationPath, true);
            }
            else
            {
                MessageBox.Show("Error: Paths are null. Can't add the product.");
            }
        }

        private void FileBtnOnClick(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                fileName = string.IsNullOrEmpty(nameVal.Text) ? "default" : nameVal.Text;
                prevPicBox.ImageLocation = selectedImagePath;
                imgname = nameVal.Text + GetImageFormat(selectedImagePath);
                MessageBox.Show(imgname);
            }
        }

        private string GetImageFormat(string imagePath)
        {
            // Get the image format from the file extension
            return Path.GetExtension(imagePath);
        }


        private void AddProductOnClick(object sender, EventArgs e)
        {
            panelAddProd.Visible = true;
            panelAddProd.Left = Width - panelAddProd.Width;
        }

        private void CloseBtnOnClick(object sender, EventArgs e)
        {
            panelAddProd.Left = -panelAddProd.Width;
            panelAddProd.Visible = false;
        }
    }
}