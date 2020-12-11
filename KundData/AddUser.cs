using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using System.Windows.Forms;
using System.IO;

namespace KundData
{


    public partial class AddUser : DarkForm
    {
        //Some variables, FUCK RIGHT OFF.
        readonly string message = "Vill du spara informationen?";
        readonly MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        readonly string title = "";
        

        public AddUser()
        {
            InitializeComponent();

        }



        //If the "save" button is pressed it'll ask if the user wants to save what he's written
        private void Button1_Click(object sender, EventArgs e)
        {

            //It'll ask "Wanna save?" Yes or No..
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //If yes is chosen it will put namebox.text (name field), make a new line, 
                // put the nmbrbox.text (number field) and then make a new line until the next user is added to prevent them clinging after eachother.
                File.AppendAllText("C:\\ProgramData\\heaven\\nameandnmbr.rex", "   |   " + namebox.Text + "   |   " + nmbrbox.Text + "   |" + Environment.NewLine);

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //If No is chosen it'll just do nothing. And just... ....Stop it.
                this.Close();
            }
        }


        private void Nmbrbox_Leave(object sender, EventArgs e)
        {
            //checks whether the entered text is 10 characters or shorter, otherwise...
            if (nmbrbox.Text.Length < 10)
                
                //if it isn't exactly 10 numbers long it'll throw an error message and after it's read you just press ok.
                MessageBox.Show("Ditt nummer är för kort!");
            nmbrbox.SelectAll();
        }
    }
    }