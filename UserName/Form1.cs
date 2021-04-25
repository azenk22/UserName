using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateBTN_Click(object sender, EventArgs e)
        {

            if(ValidUsername())
            {
                
                MessageBox.Show("That username is valid!", "Valid Username");


            }
            else
            {
                MessageBox.Show("That username is not valid!", "Invalid Username");
            }

        }

        private bool ValidUsername()
        {
            bool valid = true;


            if(!StartsWithLetter())
            {
                valid = false;
            }

            if (!Length())
            {
                valid = false;
            }

            if(!CheckChars())
            {
                valid = false;
            }
           
            if(!LastChar())
            {
                valid = false;  
            }
            
            return valid;
        }

        private bool StartsWithLetter()
        {
            bool letter = false;
           
            letter = Char.IsLetter(UsernameTB.Text[0]);

            return letter;
        }

        private bool Length()
        {
            bool length = false;

            if(UsernameTB.Text.Length >= 4 && UsernameTB.Text.Length <= 25)
            {
                length = true;
            }

            return length;
        }

        private bool CheckChars()
        {
            bool chars = true;

            foreach(char c in UsernameTB.Text)
            {

                if(!Char.IsLetter(c) && !Char.IsNumber(c) && c!= '_')
                {
                    chars = false;
                }

            }

            return chars;
        }

        private bool LastChar()
        {
            bool last = false;

            char lastChar = UsernameTB.Text.Last();

            if(lastChar != '_')
            {
                last = true;
            }

            return last;
        }
    }
}
