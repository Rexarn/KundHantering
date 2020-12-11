using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using DarkUI.Forms;

namespace KundData
{
    public partial class Inventory : DarkForm
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // Make sure the textbox is always highlighted..
            this.ActiveControl = barcodeBox;
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            string fileName = barcodeBox.Text.ToString() + ".BAR";
            using (StreamWriter writer = new StreamWriter("C:\\ProgramData\\heaven\\codes\\" + fileName, append: true))
            {
                
                writer.Write("1");
            }
        }
    }
}
