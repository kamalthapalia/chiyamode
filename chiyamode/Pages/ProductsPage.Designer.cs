using System.ComponentModel;

namespace chiyamode.Pages
{
    partial class ProductsPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addProduct = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.productList1 = new chiyamode.Forms.ProductList();
            this.panelAddProd = new System.Windows.Forms.Panel();
            this.prevPicBox = new System.Windows.Forms.PictureBox();
            this.submitProductBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.catVal = new System.Windows.Forms.ComboBox();
            this.nameVal = new System.Windows.Forms.TextBox();
            this.priceVal = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.imageLbl = new System.Windows.Forms.Label();
            this.catLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelHeader.SuspendLayout();
            this.panelAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct.BackColor = System.Drawing.Color.Teal;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProduct.Location = new System.Drawing.Point(725, 8);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(131, 37);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(30)))));
            this.panelHeader.Controls.Add(this.addProduct);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(872, 51);
            this.panelHeader.TabIndex = 4;
            // 
            // productList1
            // 
            this.productList1.BackColor = System.Drawing.Color.Azure;
            this.productList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList1.Location = new System.Drawing.Point(0, 51);
            this.productList1.Name = "productList1";
            this.productList1.Size = new System.Drawing.Size(872, 736);
            this.productList1.TabIndex = 5;
            // 
            // panelAddProd
            // 
            this.panelAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddProd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAddProd.Controls.Add(this.prevPicBox);
            this.panelAddProd.Controls.Add(this.submitProductBtn);
            this.panelAddProd.Controls.Add(this.fileBtn);
            this.panelAddProd.Controls.Add(this.catVal);
            this.panelAddProd.Controls.Add(this.nameVal);
            this.panelAddProd.Controls.Add(this.priceVal);
            this.panelAddProd.Controls.Add(this.nameLbl);
            this.panelAddProd.Controls.Add(this.imageLbl);
            this.panelAddProd.Controls.Add(this.catLbl);
            this.panelAddProd.Controls.Add(this.priceLbl);
            this.panelAddProd.Controls.Add(this.addLabel);
            this.panelAddProd.Controls.Add(this.closeBtn);
            this.panelAddProd.Location = new System.Drawing.Point(575, 0);
            this.panelAddProd.Name = "panelAddProd";
            this.panelAddProd.Size = new System.Drawing.Size(297, 784);
            this.panelAddProd.TabIndex = 1;
            // 
            // prevPicBox
            // 
            this.prevPicBox.InitialImage = null;
            this.prevPicBox.Location = new System.Drawing.Point(43, 440);
            this.prevPicBox.Name = "prevPicBox";
            this.prevPicBox.Size = new System.Drawing.Size(216, 198);
            this.prevPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevPicBox.TabIndex = 8;
            this.prevPicBox.TabStop = false;
            // 
            // submitProductBtn
            // 
            this.submitProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.submitProductBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitProductBtn.Location = new System.Drawing.Point(43, 663);
            this.submitProductBtn.Name = "submitProductBtn";
            this.submitProductBtn.Size = new System.Drawing.Size(216, 35);
            this.submitProductBtn.TabIndex = 7;
            this.submitProductBtn.Text = "Add Product";
            this.submitProductBtn.UseVisualStyleBackColor = true;
            // 
            // fileBtn
            // 
            this.fileBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileBtn.Location = new System.Drawing.Point(43, 390);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(216, 35);
            this.fileBtn.TabIndex = 7;
            this.fileBtn.Text = "Add Image";
            this.fileBtn.UseVisualStyleBackColor = true;
            // 
            // catVal
            // 
            this.catVal.Font = new System.Drawing.Font("JetBrains Mono", 10F);
            this.catVal.FormattingEnabled = true;
            this.catVal.Location = new System.Drawing.Point(43, 304);
            this.catVal.Name = "catVal";
            this.catVal.Size = new System.Drawing.Size(216, 27);
            this.catVal.TabIndex = 6;
            // 
            // nameVal
            // 
            this.nameVal.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVal.Location = new System.Drawing.Point(43, 146);
            this.nameVal.Name = "nameVal";
            this.nameVal.Size = new System.Drawing.Size(216, 27);
            this.nameVal.TabIndex = 5;
            // 
            // priceVal
            // 
            this.priceVal.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceVal.Location = new System.Drawing.Point(43, 223);
            this.priceVal.Name = "priceVal";
            this.priceVal.Size = new System.Drawing.Size(216, 27);
            this.priceVal.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(43, 120);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(122, 23);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Name:";
            // 
            // imageLbl
            // 
            this.imageLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.Location = new System.Drawing.Point(43, 355);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(122, 23);
            this.imageLbl.TabIndex = 4;
            this.imageLbl.Text = "Image:";
            // 
            // catLbl
            // 
            this.catLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLbl.Location = new System.Drawing.Point(43, 270);
            this.catLbl.Name = "catLbl";
            this.catLbl.Size = new System.Drawing.Size(122, 23);
            this.catLbl.TabIndex = 4;
            this.catLbl.Text = "Category:";
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(43, 197);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(122, 23);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "Price:";
            // 
            // addLabel
            // 
            this.addLabel.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(43, 55);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(167, 23);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Add Product";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(12, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 25);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "x";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddProd);
            this.Controls.Add(this.productList1);
            this.Controls.Add(this.panelHeader);
            this.Name = "ProductsPage";
            this.Size = new System.Drawing.Size(872, 787);
            this.panelHeader.ResumeLayout(false);
            this.panelAddProd.ResumeLayout(false);
            this.panelAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevPicBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button submitProductBtn;

        private System.Windows.Forms.PictureBox prevPicBox;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileBtn;

        private System.Windows.Forms.Label imageLbl;

        private System.Windows.Forms.ComboBox catVal;

        private System.Windows.Forms.TextBox nameVal;

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label catLbl;
        private System.Windows.Forms.TextBox priceVal;

        private System.Windows.Forms.Label priceLbl;

        private System.Windows.Forms.Label addLabel;

        private System.Windows.Forms.Label closeBtn;

        private System.Windows.Forms.Panel panelAddProd;

        private chiyamode.Forms.ProductList productList1;

        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Panel panelHeader;

        #endregion
    }
}