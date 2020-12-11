using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KundData
{
    public partial class List : DarkForm
    {

        //This motherfucker right here loads as soon as the form is displayed, 
        //it loads the main file, has the focus thingy and makes sure it says "search" before you click the searchbox..
        public List()
        {
            InitializeComponent();
            //Tells the listbox which file to load
            listBox1.DataSource = File.ReadAllLines("C:\\ProgramData\\heaven\\nameandnmbr.rex");
            //this hides the "search matches"
            labelResults.Hide();
        }

        //This script makes all text inside of "listBox1" centered.
        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            {
                object item = listBox1.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }
        // This cunt checks if the box has been focused and if it has it'll empty out the textbox..
        protected void TextBox1_Focus(Object sender, EventArgs e)
        {
            //shows the "Results:" text aswell as emptying out the aformetioned text..
            labelResults.Show();
            TextBox1.Text = null;
        }

        //This MOTHERFUCKER checks if you have left / removed focus from the search box
        //and reverts the text back to the standard value of "Search....."
        protected void TextBox1_LostFocus(Object sender, EventArgs e)
        {
            TextBox1.Text = "Search....";
            labelResults.Hide();
        }

        // Has the searchbox text been changed? If so, highlight the matches you get.
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(TextBox1.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
            labelResults.Text = "Results: " + listBox1.SelectedItems.Count.ToString();

        }



        //Delete button, Works. Put in the Yes/No prompt before executing anything. 
        //Also make the listbox update when something has been deleted. = done

        // add Yes / no pls... = FINALLY FUCKING DONE I HATE SQUIGGLY BRACKETS DUDE WTF IS WRONG WITH THEM?
        private void Delusrbtn_Click(object sender, EventArgs e)
        {
            //fuck all these goddamn fucking variables 
            int index;
            index = listBox1.SelectedIndex;
            string text = "";
            //A wild Yes/No box appeared
            DialogResult result = MessageBox.Show("Vill du radera?", "", MessageBoxButtons.YesNo);

            //if yes then...
            if (result == DialogResult.Yes)
            {
                // open the file
                using (StreamReader reader = new StreamReader("C:\\ProgramData\\heaven\\nameandnmbr.rex"))
                {
                    //read what it contains..
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line.Equals(listBox1.Items[index].ToString()))
                        {

                        }
                        else
                        {
                            text += line + "\r\n";
                        }
                        line = reader.ReadLine();


                    }
                }
                //Then save that shidd
                using (StreamWriter writer = new StreamWriter("C:\\ProgramData\\heaven\\nameandnmbr.rex"))
                {
                    //write the "blank text"/deletion and wait a little bit before closing and waiting some more...
                    writer.Write(text);
                    Thread.Sleep(100);
                    writer.Close();
                    Thread.Sleep(100);
                    //and reopen it when it has saved
                    listBox1.DataSource = File.ReadAllLines("C:\\ProgramData\\heaven\\nameandnmbr.rex");

                }
            }



            else
                 {
                    listBox1.DataSource = File.ReadAllLines("C:\\ProgramData\\heaven\\nameandnmbr.rex");

            }
        }
    }
}

