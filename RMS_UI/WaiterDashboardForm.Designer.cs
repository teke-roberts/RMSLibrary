namespace RMS_UI
{
    partial class WaiterDashboardForm
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
            waiterDashboardLabel = new Label();
            waiterLabel = new Label();
            currentOrdersListBox = new ListBox();
            editOrderButton = new Button();
            newOrderButton = new Button();
            addNewItemButton = new Button();
            deleteOrderButton = new Button();
            SuspendLayout();
            // 
            // waiterDashboardLabel
            // 
            waiterDashboardLabel.AutoSize = true;
            waiterDashboardLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            waiterDashboardLabel.Location = new Point(23, 20);
            waiterDashboardLabel.Name = "waiterDashboardLabel";
            waiterDashboardLabel.Size = new Size(266, 45);
            waiterDashboardLabel.TabIndex = 0;
            waiterDashboardLabel.Text = "WaiterDashboard";
            // 
            // waiterLabel
            // 
            waiterLabel.AutoSize = true;
            waiterLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            waiterLabel.Location = new Point(804, 36);
            waiterLabel.Name = "waiterLabel";
            waiterLabel.Size = new Size(64, 25);
            waiterLabel.TabIndex = 1;
            waiterLabel.Text = "waiter";
            waiterLabel.Click += waiterLabel_Click;
            // 
            // currentOrdersListBox
            // 
            currentOrdersListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentOrdersListBox.FormattingEnabled = true;
            currentOrdersListBox.ItemHeight = 32;
            currentOrdersListBox.Location = new Point(32, 78);
            currentOrdersListBox.Name = "currentOrdersListBox";
            currentOrdersListBox.Size = new Size(706, 516);
            currentOrdersListBox.TabIndex = 2;
            // 
            // editOrderButton
            // 
            editOrderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editOrderButton.Location = new Point(782, 169);
            editOrderButton.Name = "editOrderButton";
            editOrderButton.Size = new Size(104, 80);
            editOrderButton.TabIndex = 3;
            editOrderButton.Text = "Edit \r\nOrder";
            editOrderButton.UseVisualStyleBackColor = true;
            editOrderButton.Click += editOrderButton_Click;
            // 
            // newOrderButton
            // 
            newOrderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newOrderButton.Location = new Point(782, 291);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new Size(104, 80);
            newOrderButton.TabIndex = 3;
            newOrderButton.Text = "New\r\nOrder\r\n";
            newOrderButton.UseVisualStyleBackColor = true;
            newOrderButton.Click += newOrderButton_Click;
            // 
            // addNewItemButton
            // 
            addNewItemButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewItemButton.Location = new Point(295, 25);
            addNewItemButton.Name = "addNewItemButton";
            addNewItemButton.Size = new Size(158, 40);
            addNewItemButton.TabIndex = 4;
            addNewItemButton.Text = "Add Menu Item";
            addNewItemButton.UseVisualStyleBackColor = true;
            addNewItemButton.Click += addNewItemButton_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteOrderButton.Location = new Point(782, 416);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(104, 80);
            deleteOrderButton.TabIndex = 5;
            deleteOrderButton.Text = "Delete\r\nOrder";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // WaiterDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 617);
            Controls.Add(deleteOrderButton);
            Controls.Add(addNewItemButton);
            Controls.Add(newOrderButton);
            Controls.Add(editOrderButton);
            Controls.Add(currentOrdersListBox);
            Controls.Add(waiterLabel);
            Controls.Add(waiterDashboardLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "WaiterDashboardForm";
            Text = "WaiterDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label waiterDashboardLabel;
        private Label waiterLabel;
        private ListBox currentOrdersListBox;
        private Button editOrderButton;
        private Button newOrderButton;
        private Button addNewItemButton;
        private Button deleteOrderButton;
    }
}