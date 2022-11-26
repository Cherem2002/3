using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;


namespace IS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"; //Фильтер на формат файла
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);//Вывод в  pictureBox1
                pictureBox1.Text = open.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var ocrengine = new TesseractEngine(@".\tessdata", "rus+eng", EngineMode.Default);//Подключенние библиотеки с языками
            var img = Pix.LoadFromFile(pictureBox1.Text);
            var res = ocrengine.Process(img);//Превращение картинки в текст
            richTextBox1.Text = res.GetText();//Вывод в richTextBox1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
