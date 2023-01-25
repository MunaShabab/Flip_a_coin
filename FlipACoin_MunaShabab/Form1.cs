using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipACoin_MunaShabab
{
    //Author: Muna Shabab
    //ID:624191
    //Date: 9-14-19
    //Goal: to randomly flip a coin with switching button active status
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            //variable to indicate which side is up
            int sideUp;

            //create a random object
            Random rand = new Random();

            //get a random integer between 0 and 1 
            //0 means tails is up, 1 means heads is up
            sideUp = rand.Next(2);

            //display the side that is up
            if (sideUp==0)
            {
                //display tails up
                tailPic.Visible = true;
                headPic.Visible = false;
            }
            else
            {
                //display heads up
                headPic.Visible = true;
                tailPic.Visible = false;
            }

            //enable the clear button
            clearButton.Enabled = true;

            //disable Flip a coin button
            flipButton.Enabled = false;
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the pictures
            headPic.Visible = false;
            tailPic.Visible = false;

            //enable the flip a coin button
            flipButton.Enabled = true;

            //disable the clear button
            clearButton.Enabled = false;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

    }
}
