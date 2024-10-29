namespace RMS_UI
{
    partial class EditOrderForm
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
            newOrderLabel = new Label();
            currentOrderListBox = new ListBox();
            menuItemsListBox = new ListBox();
            cancelOrderButton = new Button();
            enterOrderButton = new Button();
            tableNumberBox = new ComboBox();
            currentOrderLabel = new Label();
            appetizersButton = new Button();
            entreesButton = new Button();
            drinksButton = new Button();
            dessertsButton = new Button();
            menuLabel = new Label();
            removeItemButton = new Button();
            subTotalLabel = new Label();
            taxLabel = new Label();
            totalLabel = new Label();
            subTotalValue = new Label();
            taxValue = new Label();
            totalValue = new Label();
            SuspendLayout();
            // 
            // newOrderLabel
            // 
            newOrderLabel.AutoSize = true;
            newOrderLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newOrderLabel.ForeColor = SystemColors.ControlLightLight;
            newOrderLabel.Location = new Point(541, 9);
            newOrderLabel.Name = "newOrderLabel";
            newOrderLabel.Size = new Size(274, 65);
            newOrderLabel.TabIndex = 0;
            newOrderLabel.Text = "Order Taker";
            // 
            // currentOrderListBox
            // 
            currentOrderListBox.BackColor = Color.DarkGray;
            currentOrderListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentOrderListBox.FormattingEnabled = true;
            currentOrderListBox.ItemHeight = 32;
            currentOrderListBox.Location = new Point(12, 134);
            currentOrderListBox.Name = "currentOrderListBox";
            currentOrderListBox.Size = new Size(658, 484);
            currentOrderListBox.TabIndex = 1;
            // 
            // menuItemsListBox
            // 
            menuItemsListBox.BackColor = Color.DarkGray;
            menuItemsListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuItemsListBox.FormattingEnabled = true;
            menuItemsListBox.ItemHeight = 32;
            menuItemsListBox.Location = new Point(694, 134);
            menuItemsListBox.Name = "menuItemsListBox";
            menuItemsListBox.Size = new Size(658, 612);
            menuItemsListBox.TabIndex = 2;
            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.BackColor = Color.DarkSeaGreen;
            cancelOrderButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelOrderButton.ForeColor = SystemColors.ControlLightLight;
            cancelOrderButton.Location = new Point(41, 768);
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.Size = new Size(186, 50);
            cancelOrderButton.TabIndex = 3;
            cancelOrderButton.Text = "Cancel Order";
            cancelOrderButton.UseVisualStyleBackColor = false;
            cancelOrderButton.Click += cancelOrderButton_Click;
            // 
            // enterOrderButton
            // 
            enterOrderButton.BackColor = Color.OliveDrab;
            enterOrderButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterOrderButton.ForeColor = SystemColors.ControlLightLight;
            enterOrderButton.Location = new Point(453, 768);
            enterOrderButton.Name = "enterOrderButton";
            enterOrderButton.Size = new Size(186, 50);
            enterOrderButton.TabIndex = 4;
            enterOrderButton.Text = "Enter Order";
            enterOrderButton.UseVisualStyleBackColor = false;
            enterOrderButton.Click += enterOrderButton_Click;
            // 
            // tableNumberBox
            // 
            tableNumberBox.BackColor = Color.DarkGray;
            tableNumberBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableNumberBox.FormattingEnabled = true;
            tableNumberBox.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            tableNumberBox.Location = new Point(26, 85);
            tableNumberBox.Name = "tableNumberBox";
            tableNumberBox.Size = new Size(159, 38);
            tableNumberBox.TabIndex = 5;
            tableNumberBox.Text = "Table Number";
            // 
            // currentOrderLabel
            // 
            currentOrderLabel.AutoSize = true;
            currentOrderLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentOrderLabel.ForeColor = SystemColors.ControlLightLight;
            currentOrderLabel.Location = new Point(230, 80);
            currentOrderLabel.Name = "currentOrderLabel";
            currentOrderLabel.Size = new Size(224, 45);
            currentOrderLabel.TabIndex = 6;
            currentOrderLabel.Text = "Current Order:";
            // 
            // appetizersButton
            // 
            appetizersButton.BackColor = SystemColors.ControlLight;
            appetizersButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appetizersButton.Location = new Point(726, 768);
            appetizersButton.Name = "appetizersButton";
            appetizersButton.Size = new Size(144, 50);
            appetizersButton.TabIndex = 7;
            appetizersButton.Text = "Appetizers";
            appetizersButton.UseVisualStyleBackColor = false;
            appetizersButton.Click += appetizersButton_Click;
            // 
            // entreesButton
            // 
            entreesButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entreesButton.Location = new Point(876, 768);
            entreesButton.Name = "entreesButton";
            entreesButton.Size = new Size(144, 50);
            entreesButton.TabIndex = 7;
            entreesButton.Text = "Entrees";
            entreesButton.UseVisualStyleBackColor = true;
            entreesButton.Click += entreesButton_Click;
            // 
            // drinksButton
            // 
            drinksButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drinksButton.Location = new Point(1026, 768);
            drinksButton.Name = "drinksButton";
            drinksButton.Size = new Size(144, 50);
            drinksButton.TabIndex = 7;
            drinksButton.Text = "Drinks";
            drinksButton.UseVisualStyleBackColor = true;
            drinksButton.Click += drinksButton_Click;
            // 
            // dessertsButton
            // 
            dessertsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dessertsButton.Location = new Point(1176, 768);
            dessertsButton.Name = "dessertsButton";
            dessertsButton.Size = new Size(144, 50);
            dessertsButton.TabIndex = 7;
            dessertsButton.Text = "Desserts";
            dessertsButton.UseVisualStyleBackColor = true;
            dessertsButton.Click += dessertsButton_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuLabel.ForeColor = SystemColors.ControlLightLight;
            menuLabel.Location = new Point(977, 78);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(109, 45);
            menuLabel.TabIndex = 6;
            menuLabel.Text = "Menu:";
            // 
            // removeItemButton
            // 
            removeItemButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeItemButton.Location = new Point(57, 634);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(153, 38);
            removeItemButton.TabIndex = 8;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click;
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalLabel.ForeColor = SystemColors.ControlLightLight;
            subTotalLabel.Location = new Point(461, 634);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(95, 30);
            subTotalLabel.TabIndex = 9;
            subTotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxLabel.ForeColor = SystemColors.ControlLightLight;
            taxLabel.Location = new Point(461, 675);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(48, 30);
            taxLabel.TabIndex = 10;
            taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = SystemColors.ControlLightLight;
            totalLabel.Location = new Point(461, 716);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(62, 30);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total:";
            // 
            // subTotalValue
            // 
            subTotalValue.AutoSize = true;
            subTotalValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalValue.ForeColor = SystemColors.ControlLightLight;
            subTotalValue.Location = new Point(615, 634);
            subTotalValue.Name = "subTotalValue";
            subTotalValue.Size = new Size(24, 30);
            subTotalValue.TabIndex = 12;
            subTotalValue.Text = "0";
            // 
            // taxValue
            // 
            taxValue.AutoSize = true;
            taxValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxValue.ForeColor = SystemColors.ControlLightLight;
            taxValue.Location = new Point(615, 675);
            taxValue.Name = "taxValue";
            taxValue.Size = new Size(24, 30);
            taxValue.TabIndex = 13;
            taxValue.Text = "0";
            // 
            // totalValue
            // 
            totalValue.AutoSize = true;
            totalValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalValue.ForeColor = SystemColors.ControlLightLight;
            totalValue.Location = new Point(615, 716);
            totalValue.Name = "totalValue";
            totalValue.Size = new Size(24, 30);
            totalValue.TabIndex = 14;
            totalValue.Text = "0";
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1364, 845);
            Controls.Add(totalValue);
            Controls.Add(taxValue);
            Controls.Add(subTotalValue);
            Controls.Add(totalLabel);
            Controls.Add(taxLabel);
            Controls.Add(subTotalLabel);
            Controls.Add(removeItemButton);
            Controls.Add(dessertsButton);
            Controls.Add(drinksButton);
            Controls.Add(entreesButton);
            Controls.Add(appetizersButton);
            Controls.Add(menuLabel);
            Controls.Add(currentOrderLabel);
            Controls.Add(tableNumberBox);
            Controls.Add(enterOrderButton);
            Controls.Add(cancelOrderButton);
            Controls.Add(menuItemsListBox);
            Controls.Add(currentOrderListBox);
            Controls.Add(newOrderLabel);
            Name = "EditOrderForm";
            Text = "NewOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newOrderLabel;
        private ListBox currentOrderListBox;
        private ListBox menuItemsListBox;
        private Button cancelOrderButton;
        private Button enterOrderButton;
        private ComboBox tableNumberBox;
        private Label currentOrderLabel;
        private Button appetizersButton;
        private Button entreesButton;
        private Button drinksButton;
        private Button dessertsButton;
        private Label menuLabel;
        private Button removeItemButton;
        private Label subTotalLabel;
        private Label taxLabel;
        private Label totalLabel;
        private Label subTotalValue;
        private Label taxValue;
        private Label totalValue;
    }
}