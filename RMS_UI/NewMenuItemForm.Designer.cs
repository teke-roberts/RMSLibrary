namespace RMS_UI
{
    partial class NewMenuItemForm
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
            AddItemLabel = new Label();
            ItemNameLabel = new Label();
            ItemNameBox = new TextBox();
            ItemDescriptionBox = new TextBox();
            ItemPriceBox = new TextBox();
            ItemPriceLabel = new Label();
            ItemDescriptionLabel = new Label();
            ItemCategoryBox = new ComboBox();
            ItemCategoryLabel = new Label();
            AddItemCancelButton = new Button();
            AddItemButton = new Button();
            SuspendLayout();
            // 
            // AddItemLabel
            // 
            AddItemLabel.AutoSize = true;
            AddItemLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemLabel.Location = new Point(28, 26);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(283, 40);
            AddItemLabel.TabIndex = 0;
            AddItemLabel.Text = "Add New Menu Item";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemNameLabel.Location = new Point(44, 93);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(90, 21);
            ItemNameLabel.TabIndex = 1;
            ItemNameLabel.Text = "Item Name:";
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(45, 117);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(229, 23);
            ItemNameBox.TabIndex = 2;
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(44, 256);
            ItemDescriptionBox.Multiline = true;
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(229, 111);
            ItemDescriptionBox.TabIndex = 3;
            // 
            // ItemPriceBox
            // 
            ItemPriceBox.Location = new Point(45, 182);
            ItemPriceBox.Name = "ItemPriceBox";
            ItemPriceBox.Size = new Size(229, 23);
            ItemPriceBox.TabIndex = 4;
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemPriceLabel.Location = new Point(44, 158);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(47, 21);
            ItemPriceLabel.TabIndex = 5;
            ItemPriceLabel.Text = "Price:";
            // 
            // ItemDescriptionLabel
            // 
            ItemDescriptionLabel.AutoSize = true;
            ItemDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemDescriptionLabel.Location = new Point(44, 232);
            ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            ItemDescriptionLabel.Size = new Size(92, 21);
            ItemDescriptionLabel.TabIndex = 6;
            ItemDescriptionLabel.Text = "Description:";
            // 
            // ItemCategoryBox
            // 
            ItemCategoryBox.FormattingEnabled = true;
            ItemCategoryBox.Items.AddRange(new object[] { "Appetizer", "Entree", "Dessert", "Drink" });
            ItemCategoryBox.Location = new Point(44, 418);
            ItemCategoryBox.Name = "ItemCategoryBox";
            ItemCategoryBox.Size = new Size(230, 23);
            ItemCategoryBox.TabIndex = 7;
            // 
            // ItemCategoryLabel
            // 
            ItemCategoryLabel.AutoSize = true;
            ItemCategoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemCategoryLabel.Location = new Point(44, 394);
            ItemCategoryLabel.Name = "ItemCategoryLabel";
            ItemCategoryLabel.Size = new Size(76, 21);
            ItemCategoryLabel.TabIndex = 8;
            ItemCategoryLabel.Text = "Category:";
            // 
            // AddItemCancelButton
            // 
            AddItemCancelButton.BackColor = SystemColors.ControlLight;
            AddItemCancelButton.Location = new Point(42, 479);
            AddItemCancelButton.Name = "AddItemCancelButton";
            AddItemCancelButton.Size = new Size(92, 35);
            AddItemCancelButton.TabIndex = 9;
            AddItemCancelButton.Text = "Cancel";
            AddItemCancelButton.UseVisualStyleBackColor = false;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(181, 479);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(92, 35);
            AddItemButton.TabIndex = 10;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // NewMenuItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 555);
            Controls.Add(AddItemButton);
            Controls.Add(AddItemCancelButton);
            Controls.Add(ItemCategoryLabel);
            Controls.Add(ItemCategoryBox);
            Controls.Add(ItemDescriptionLabel);
            Controls.Add(ItemPriceLabel);
            Controls.Add(ItemPriceBox);
            Controls.Add(ItemDescriptionBox);
            Controls.Add(ItemNameBox);
            Controls.Add(ItemNameLabel);
            Controls.Add(AddItemLabel);
            Name = "NewMenuItemForm";
            Text = "NewMenuItemForm";
            Load += NewMenuItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddItemLabel;
        private Label ItemNameLabel;
        private TextBox ItemNameBox;
        private TextBox ItemDescriptionBox;
        private TextBox ItemPriceBox;
        private Label ItemPriceLabel;
        private Label ItemDescriptionLabel;
        private ComboBox ItemCategoryBox;
        private Label ItemCategoryLabel;
        private Button AddItemCancelButton;
        private Button AddItemButton;
    }
}