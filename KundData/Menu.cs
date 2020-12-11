using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using System.Data.SqlClient;

namespace KundData
{
    public partial class Menu : DarkForm
    {
        public Menu()
        {
            InitializeComponent();
            //Everytime the program starts it looks if the "heaven" folder exists, if not it just creates it.
            //Folder path is "C:\ProgramData\heaven"
            System.IO.Directory.CreateDirectory(@"C:\ProgramData\heaven");
            // aaaaaaaaand the barcode folder..
            System.IO.Directory.CreateDirectory(@"C:\ProgramData\heaven\codes");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //If the "Registrera Kund" button is pressed, open the registration window.
            AddUser secondForm = new AddUser();
            secondForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //If the "Visa Kunder" button is pressed, open the customer list.
            List listform = new List();
            listform.Show();


            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //If the "Mer Info" button is pressed, open the information window.
            about aboutform = new about();
            aboutform.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // If the "Inventory" button is pressed, open the aformentioned window
            Inventory Inventform = new Inventory();
            Inventform.Show();
                
        }
    }
}
