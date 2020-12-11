using System;
using System.Net;
using DarkUI.Forms;


namespace KundData
{
    public partial class about : DarkForm
    {

        public about()
        {
            InitializeComponent();
            //When the program starts it instantly hides the easterbutton
            darkButton1.Hide();
        }


        //the text inside the textbox is already defined inside of "about.Designer.cs" since it was easier than doing it here...

        //if you press F12 it downloads an mp3 file inside the working dir of the program...
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F12)
            {
                //if you've pressed f12 a wild messagebox appears congratulating the user of finding the secret button
                System.Windows.Forms.MessageBox.Show("Enjoy the gift my dood.");
                //shows the play button
                darkButton1.Show();

                //downloads the file from my site and places it in the working dir...
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://rexarn.tk/fuck/side_loop.mp3", "C:\\ProgramData\\Heaven\\side_loop.mp3");



                }

            }
        }


        //if you click the "EASTER BUTTON" it starts playing the mp3 file until the program is exited.
        private void DarkButton1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
            {
                URL = ("C:\\ProgramData\\Heaven\\side_loop.mp3")

            };
            wplayer.controls.play();
        }

    }
}







