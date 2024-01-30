namespace chiyamode.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.productsPage1 = new chiyamode.Pages.ProductsPage();
            this.cart1 = new chiyamode.Pages.Cart();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.checkOutBtn);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.productsBtn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.welcome);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 673);
            this.panel2.TabIndex = 2;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.checkOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.checkOutBtn.Location = new System.Drawing.Point(11, 201);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(177, 37);
            this.checkOutBtn.TabIndex = 0;
            this.checkOutBtn.Text = "Checkout";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(12, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Sales";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.productsBtn.Location = new System.Drawing.Point(12, 115);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(176, 37);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.time.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.Control;
            this.time.Location = new System.Drawing.Point(0, 566);
            this.time.Name = "time";
            this.time.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.time.Size = new System.Drawing.Size(126, 27);
            this.time.TabIndex = 0;
            this.time.Text = "10:26 PM";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.Control;
            this.date.Location = new System.Drawing.Point(0, 593);
            this.date.Name = "date";
            this.date.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.date.Size = new System.Drawing.Size(172, 19);
            this.date.TabIndex = 0;
            this.date.Text = "2024/1/16, Monday";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome.Location = new System.Drawing.Point(12, 22);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(126, 19);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome, user";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 612);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 61);
            this.panel7.TabIndex = 2;
            // 
            // productsPage1
            // 
            this.productsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPage1.Location = new System.Drawing.Point(200, 0);
            this.productsPage1.Name = "productsPage1";
            this.productsPage1.Size = new System.Drawing.Size(820, 673);
            this.productsPage1.TabIndex = 3;
            // 
            // cart1
            // 
            this.cart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart1.Location = new System.Drawing.Point(200, 0);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(820, 673);
            this.cart1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 673);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.productsPage1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Chiyamode";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private chiyamode.Pages.Cart cart1;

        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button checkOutBtn;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private chiyamode.Pages.ProductsPage productsPage1;
    }
}