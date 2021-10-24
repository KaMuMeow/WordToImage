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
        int defWidth = 200;
        int defHeight = 35;
        List<char> fillWord = new List<char>();

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
            int.TryParse(Text_ImgWidth.Text,out defWidth);
            defWidth = defWidth == 0 ? 200 : defWidth;
            getFillWord();
            //Step1-Draw Text;
            Bitmap wordBroad = new Bitmap(defWidth, defHeight);
            Graphics g = Graphics.FromImage(wordBroad);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, wordBroad.Width, wordBroad.Height));
            g.DrawString(text, new Font("標楷體",22), new SolidBrush(Color.Black),
                new Point(0, 0));
            g.Dispose();

            //Step2-Get Pixel
            int[,] wordArray = GetPixelArray(wordBroad);

            //Step3-Output
            string strOutput = "";
            for (int y = 0; y < defHeight; y++)
            {
                for (int x = 0; x < defWidth; x++)
                {
                    if (wordArray[x, y] == 255)
                    {
                        strOutput += fillWord[x % fillWord.Count()];
                    }
                    else
                    {
                        strOutput += "　";
                    }
                }
                strOutput += Environment.NewLine;
            }
            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                writer.Write(strOutput);
            }
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

        private void getFillWord()
        {
            string getWords = Text_FillWord.Text == string.Empty ? "填" : Text_FillWord.Text;
            fillWord.Clear();
            foreach( var t in getWords)
            {
                fillWord.Add(t);
            }
        }

    }
}
