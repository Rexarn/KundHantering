namespace KundData
{
    partial class Inventory
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
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.barButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(183, 26);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(100, 20);
            this.barcodeBox.TabIndex = 0;
            // 
            // barButton
            // 
            this.barButton.Location = new System.Drawing.Point(196, 48);
            this.barButton.Name = "barButton";
            this.barButton.Size = new System.Drawing.Size(75, 23);
            this.barButton.TabIndex = 1;
            this.barButton.Text = "Klar";
            this.barButton.UseVisualStyleBackColor = true;
            this.barButton.Click += new System.EventHandler(this.BarButton_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barButton);
            this.Controls.Add(this.barcodeBox);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Button barButton;
    }
}