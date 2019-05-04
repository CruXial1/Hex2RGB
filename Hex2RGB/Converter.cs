using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex2RGB
{
    public static class Converter
    {
        public static int finalR = 0;
        public static int finalG = 0;
        public static int finalB = 0;

        public static string output;

        public static void Convert(string input, TextBox textField)
        {
            if (input.Length < 6)
            {
                output = "0, 0, 0";
                return;
            }

             String Red = input.Substring(0, 2);
             String Green = input.Substring(2, 2);
             String Blue = input.Substring(4, 2);

             String r1 = Red.Substring(0, 1);
             String r2 = Red.Substring(1, 1);

             String g1 = Green.Substring(0, 1);
             String g2 = Green.Substring(1, 1);

             String b1 = Blue.Substring(0, 1);
             String b2 = Blue.Substring(1, 1);

            determineR(r1, r2);
            determineG(g1, g2);
            determineB(b1, b2);

             output = $"{finalR}, {finalG}, {finalB}";
        }

        private static void determineR(String r1, String r2)
        {
            if (r1 == "0")
            {
                r1 = "0";
            }

            if (r1 == "1")
            {
                r1 = "1";
            }

            if (r1 == "2")
            {
                r1 = "2";
            }

            if (r1 == "3")
            {
                r1 = "3";
            }

            if (r1 == "4")
            {
                r1 = "4";
            }

            if (r1 == "5")
            {
                r1 = "5";
            }

            if (r1 == "6")
            {
                r1 = "6";
            }

            if (r1 == "7")
            {
                r1 = "7";
            }

            if (r1 == "8")
            {
                r1 = "8";
            }

            if (r1 == "9")
            {
                r1 = "9";
            }

            if (r1 == "A")
            {
                r1 = "10";
            }

            if (r1 == "B")
            {
                r1 = "11";
            }

            if (r1 == "C")
            {
                r1 = "12";
            }

            if (r1 == "D")
            {
                r1 = "13";
            }

            if (r1 == "E")
            {
                r1 = "14";
            }

            if (r1 == "F")
            {
                r1 = "15";
            }

            if (r2 == "0")
            {
                r2 = "0";
            }

            if (r2 == "1")
            {
                r2 = "1";
            }

            if (r2 == "2")
            {
                r2 = "2";
            }

            if (r2 == "3")
            {
                r2 = "3";
            }

            if (r2 == "4")
            {
                r2 = "4";
            }

            if (r2 == "5")
            {
                r2 = "5";
            }

            if (r2 == "6")
            {
                r2 = "6";
            }

            if (r2 == "7")
            {
                r2 = "7";
            }

            if (r2 == "8")
            {
                r2 = "8";
            }

            if (r2 == "9")
            {
                r2 = "9";
            }

            if (r2 == "A")
            {
                r2 = "10";
            }

            if (r2 == "B")
            {
                r2 = "11";
            }

            if (r2 == "C")
            {
                r2 = "12";
            }

            if (r2 == "D")
            {
                r2 = "13";
            }

            if (r2 == "E")
            {
                r2 = "14";
            }

            if (r2 == "F")
            {
                r2 = "15";
            }

            int rgb1 = int.Parse(r1);
            int rgb2 = int.Parse(r2);

            rgb1 = rgb1 * 16;
            finalR = rgb1 + rgb2;
        }

        private static void determineG(String g1, String g2)
        {
            if (g1 == "0")
            {
                g1 = "0";
            }

            if (g1 == "1")
            {
                g1 = "1";
            }

            if (g1 == "2")
            {
                g1 = "2";
            }

            if (g1 == "3")
            {
                g1 = "3";
            }

            if (g1 == "4")
            {
                g1 = "4";
            }

            if (g1 == "5")
            {
                g1 = "5";
            }

            if (g1 == "6")
            {
                g1 = "6";
            }

            if (g1 == "7")
            {
                g1 = "7";
            }

            if (g1 == "8")
            {
                g1 = "8";
            }

            if (g1 == "9")
            {
                g1 = "9";
            }

            if (g1 == "A")
            {
                g1 = "10";
            }

            if (g1 == "B")
            {
                g1 = "11";
            }

            if (g1 == "C")
            {
                g1 = "12";
            }

            if (g1 == "D")
            {
                g1 = "13";
            }

            if (g1 == "E")
            {
                g1 = "14";
            }

            if (g1 == "F")
            {
                g1 = "15";
            }

            if (g2 == "0")
            {
                g2 = "0";
            }

            if (g2 == "1")
            {
                g2 = "1";
            }

            if (g2 == "2")
            {
                g2 = "2";
            }

            if (g2 == "3")
            {
                g2 = "3";
            }

            if (g2 == "4")
            {
                g2 = "4";
            }

            if (g2 == "5")
            {
                g2 = "5";
            }

            if (g2 == "6")
            {
                g2 = "6";
            }

            if (g2 == "7")
            {
                g2 = "7";
            }

            if (g2 == "8")
            {
                g2 = "8";
            }

            if (g2 == "9")
            {
                g2 = "9";
            }

            if (g2 == "A")
            {
                g2 = "10";
            }

            if (g2 == "B")
            {
                g2 = "11";
            }

            if (g2 == "C")
            {
                g2 = "12";
            }

            if (g2 == "D")
            {
                g2 = "13";
            }

            if (g2 == "E")
            {
                g2 = "14";
            }

            if (g2 == "F")
            {
                g2 = "15";
            }

            int rgb1 = int.Parse(g1);
            int rgb2 = int.Parse(g2);

            rgb1 = rgb1 * 16;
            finalG = rgb1 + rgb2;
        }

        private static void determineB(String b1, String b2)
        {
            if (b1 == "0")
            {
                b1 = "0";
            }

            if (b1 == "1")
            {
                b1 = "1";
            }

            if (b1 == "2")
            {
                b1 = "2";
            }

            if (b1 == "3")
            {
                b1 = "3";
            }

            if (b1 == "4")
            {
                b1 = "4";
            }

            if (b1 == "5")
            {
                b1 = "5";
            }

            if (b1 == "6")
            {
                b1 = "6";
            }

            if (b1 == "7")
            {
                b1 = "7";
            }

            if (b1 == "8")
            {
                b1 = "8";
            }

            if (b1 == "9")
            {
                b1 = "9";
            }

            if (b1 == "A")
            {
                b1 = "10";
            }

            if (b1 == "B")
            {
                b1 = "11";
            }

            if (b1 == "C")
            {
                b1 = "12";
            }

            if (b1 == "D")
            {
                b1 = "13";
            }

            if (b1 == "E")
            {
                b1 = "14";
            }

            if (b1 == "F")
            {
                b1 = "15";
            }

            if (b2 == "0")
            {
                b2 = "0";
            }

            if (b2 == "1")
            {
                b2 = "1";
            }

            if (b2 == "2")
            {
                b2 = "2";
            }

            if (b2 == "3")
            {
                b2 = "3";
            }

            if (b2 == "4")
            {
                b2 = "4";
            }

            if (b2 == "5")
            {
                b2 = "5";
            }

            if (b2 == "6")
            {
                b2 = "6";
            }

            if (b2 == "7")
            {
                b2 = "7";
            }

            if (b2 == "8")
            {
                b2 = "8";
            }

            if (b2 == "9")
            {
                b2 = "9";
            }

            if (b2 == "A")
            {
                b2 = "10";
            }

            if (b2 == "B")
            {
                b2 = "11";
            }

            if (b2 == "C")
            {
                b2 = "12";
            }

            if (b2 == "D")
            {
                b2 = "13";
            }

            if (b2 == "E")
            {
                b2 = "14";
            }

            if (b2 == "F")
            {
                b2 = "15";
            }

            int rgb1 = int.Parse(b1);
            int rgb2 = int.Parse(b2);

            rgb1 = rgb1 * 16;
            finalB = rgb1 + rgb2;
        }
    }
}
