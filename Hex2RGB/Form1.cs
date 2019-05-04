using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex2RGB
{
    public partial class Form1 : Form
    {
        //Declaring string for future use
        public static string HexField = "#000000";

        public Form1()
        {
            InitializeComponent();

            //Setting a standard color for code to function properly
            textBox1.Text = "#000000";

            //Make bottom textbox un-editable
            textBox2.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //Check if the hex code is a valid length
            if (textBox1.TextLength > 7)
            {
                //If not, restore previous accepted statement and return
                textBox1.Text = HexField;
                return;
            }

            //Check if the hex code contains a hashtag. If not, add one.
            if (!textBox1.Text.Contains("#")) textBox1.Text = "#";

            if(!textBox1.Text.StartsWith("#"))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Hex code does not start with a hashtag!";
                return;
            }
            else
            {
                label3.ForeColor = Color.Lime;
                label3.Text = "Everything seems fine";
            }
            
            //Update string
            HexField = textBox1.Text;

            //Make sure everything is uppercased
            string colorOut = HexField.ToUpper();

            var ch = '#';
            if (textBox1.Text.IndexOf(ch) != textBox1.Text.LastIndexOf(ch))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "The hex code entered is invalid!";
                return;
            }

            //Try converting string into an ARGB code
            try
            {
                int argb = Int32.Parse(colorOut.Replace("#", ""), System.Globalization.NumberStyles.HexNumber);
                Color myColor = Color.FromArgb(argb);

                textBox1.ForeColor = myColor;
                textBox2.ForeColor = myColor;

                label3.ForeColor = Color.Lime;
                label3.Text = "Everything seems fine!";
            }
            //If not, then give the user a heads up.
            catch
            {
                label3.ForeColor = Color.Red;
                label3.Text = "The hex code entered is invalid!";
                return;
            }

            string HEX = colorOut.Replace("#", "");

            Converter.Convert(HEX, textBox2);

            textBox2.Text = Converter.output;
        }
    }
}
