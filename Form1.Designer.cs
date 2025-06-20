namespace Inventory_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            item = new Label();
            quantity = new Label();
            price = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            comboSaleItem = new ComboBox();
            btnSale = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("STXinwei", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 0;
            label1.Text = "Inventory manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(111, 58);
            item.Name = "item";
            item.Size = new Size(39, 20);
            item.TabIndex = 1;
            item.Text = "Item";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new Point(282, 58);
            quantity.Name = "quantity";
            quantity.Size = new Size(65, 20);
            quantity.TabIndex = 2;
            quantity.Text = "Quantity";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(362, 58);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 3;
            price.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 58);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(362, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(66, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(282, 110);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(65, 27);
            txtQuantity.TabIndex = 7;
            // 
            // comboSaleItem
            // 
            comboSaleItem.FormattingEnabled = true;
            comboSaleItem.Location = new Point(111, 110);
            comboSaleItem.Name = "comboSaleItem";
            comboSaleItem.Size = new Size(151, 28);
            comboSaleItem.TabIndex = 8;
            // 
            // btnSale
            // 
            btnSale.Location = new Point(487, 110);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(94, 29);
            btnSale.TabIndex = 9;
            btnSale.Text = "Confirm";
            btnSale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(111, 225);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 10;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(111, 274);
            button2.Name = "button2";
            button2.Size = new Size(109, 43);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(111, 323);
            button3.Name = "button3";
            button3.Size = new Size(109, 43);
            button3.TabIndex = 12;
            button3.Text = "Show stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(111, 372);
            button4.Name = "button4";
            button4.Size = new Size(109, 43);
            button4.TabIndex = 13;
            button4.Text = "Veiw sales";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSale);
            Controls.Add(comboSaleItem);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(price);
            Controls.Add(quantity);
            Controls.Add(item);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label item;
        private Label quantity;
        private Label price;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox comboSaleItem;
        private Button btnSale;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
