using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToImage
{
    public partial class Form1 : Form
    {
        int defWidth = 100;
        int defHeight = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            WordToImage();
        }

        private void WordToImage()
        {
            string text = textBox1.Text;
            //Step1-Draw Text;
            Bitmap wordBroad = new Bitmap(defWidth, defHeight);
            Graphics g = Graphics.FromImage(wordBroad);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, wordBroad.Width, wordBroad.Height));
            g.DrawString(text, new Font("新細明體", 12), new SolidBrush(Color.Black),
                new Point(0, 0));
            g.Dispose();
            Pic_result.BackgroundImage = wordBroad;

            //Step2-Get Pixel
            int[,] wordArray = GetPixelArray(wordBroad);

            //Step3-Output
            string strOutput = "";
            for (int y = 0; y < defHeight; y++)
            {
                for (int x = 0; x < defWidth; x++)
                {
                    if (wordArray[x, y] == 0)
                    {
                        strOutput += "　";
                    }
                    else
                    {
                        strOutput += "蘭";
                    }
                }
                strOutput += Environment.NewLine;
            }
            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                writer.Write(strOutput);
            }
            Text_Output.Text = strOutput;
        }

        private int[,] GetPixelArray(Bitmap temp)
        {
            int[,] resultArr = new int[defWidth, defHeight];

            for (int y = 0; y < defHeight; y++)
            {
                for (int x = 0; x < defWidth; x++)
                {
                    Color getColor = temp.GetPixel(x, y);
                    byte rgb = (byte)(getColor.R * .299 + getColor.G * .587 + getColor.B * .114);
                    resultArr[x, y] = rgb;
                }
            }

            return resultArr;
        }


    }
}
