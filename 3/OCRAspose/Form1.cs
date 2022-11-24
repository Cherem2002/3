using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.OCR;

namespace OCRAspose
{
    public partial class Form1 : Form
    {
        OcrEngine ocr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ocr = new OcrEngine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/OCR.bmp"); // Помещает изображение в pictureBox
            ocr.Image = ImageStream.FromFile("C:/OCR.bmp");   // Отправляет изображение в библиотеку
            if (ocr.Process()) // Начинает преобразование
            {
                label1.Text = "Text: " + ocr.Text;
            }
        }
    }
}
