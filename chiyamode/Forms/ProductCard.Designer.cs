using System.ComponentModel;

namespace chiyamode.Forms
{
    partial class ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // thumbnail
            // 
            this.thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.thumbnail.Image = ((System.Drawing.Image)(resources.GetObject("thumbnail.Image")));
            this.thumbnail.Location = new System.Drawing.Point(0, 0);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(290, 207);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 210);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(165, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Apple cider";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceLabel.Location = new System.Drawing.Point(183, 210);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(93, 20);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Rs. 900";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryLbl
            // 
            this.categoryLbl.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryLbl.Location = new System.Drawing.Point(12, 230);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(105, 20);
            this.categoryLbl.TabIndex = 1;
            this.categoryLbl.Text = "Soft Drinks";
            this.categoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addToCart
            // 
            this.addToCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.ForeColor = System.Drawing.Color.Teal;
            this.addToCart.Location = new System.Drawing.Point(0, 280);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(290, 34);
            this.addToCart.TabIndex = 2;
            this.addToCart.Text = "Add To Cart";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.edit.Location = new System.Drawing.Point(12, 250);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 23);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.thumbnail);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(290, 314);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label edit;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button addToCart;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLbl;

        private System.Windows.Forms.PictureBox thumbnail;

        #endregion
    }
}