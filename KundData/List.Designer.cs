namespace KundData
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.delusrbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delusrbtn
            // 
            this.delusrbtn.Location = new System.Drawing.Point(550, 12);
            this.delusrbtn.Name = "delusrbtn";
            this.delusrbtn.Size = new System.Drawing.Size(70, 40);
            this.delusrbtn.TabIndex = 2;
            this.delusrbtn.Text = "Radera Kund";
            this.delusrbtn.UseVisualStyleBackColor = true;
            this.delusrbtn.Click += new System.EventHandler(this.Delusrbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(35, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(710, 319);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox1_DrawItem);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(130, 27);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(113, 20);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.Text = "Search....";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.GotFocus += new System.EventHandler(this.TextBox1_Focus);
            this.TextBox1.Leave += new System.EventHandler(this.TextBox1_LostFocus);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.ForeColor = System.Drawing.Color.Snow;
            this.labelResults.Location = new System.Drawing.Point(163, 50);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 5;
            this.labelResults.Text = "Results:";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.delusrbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List";
            this.Text = "KundLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delusrbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label labelResults;
    }
}