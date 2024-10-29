namespace RMS_UI
{
    partial class WaiterViewerForm
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
            headerLabel = new Label();
            orderListBox = new ListBox();
            createOrderButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(34, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(206, 40);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Current Orders";
            
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 30;
            orderListBox.Location = new Point(34, 82);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(838, 514);
            orderListBox.TabIndex = 1;
            
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(698, 22);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(174, 40);
            createOrderButton.TabIndex = 3;
            createOrderButton.Text = "Create Order";
            createOrderButton.UseVisualStyleBackColor = true;
            // 
            // WaiterViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(918, 625);
            Controls.Add(createOrderButton);
            Controls.Add(orderListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "WaiterViewerForm";
            Text = "WaiterViewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox orderListBox;
        private Button createOrderButton;
    }
}
