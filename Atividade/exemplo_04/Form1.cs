﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Mascara.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:\\Imagens\\Tanque_de_Mistura_Off2.jpg");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }  

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_0.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_1.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_2.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_3.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_4.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_5.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_6.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_7.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_8.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Imagens\\Dig_9.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Imagens\\Tanque_de_Mistura_On2.jpg");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Imagens\\Tanque_de_Mistura_Off2.jpg");
        }
    }
}
