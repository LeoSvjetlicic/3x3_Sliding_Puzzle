using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzz
{
    public partial class Puzzle : Form
    {
        Random rand=new Random();
        Bitmap image = new Bitmap(@"D:\Users\Korisnik\Desktop\Test\luka.jpg");
        Bitmap[] imageArray = new Bitmap[9];
        static List<int> used = new List<int>();
        Bitmap[] correctImages = new Bitmap[9];


        bool mouse_clicked =false;
        public Puzzle()
        {
            InitializeComponent();
        }
        private void Swap(ref PictureBox one, ref PictureBox two)
        {
            PictureBox three=new PictureBox();
            three.BackgroundImage=one.BackgroundImage;
            one.BackgroundImage = two.BackgroundImage;
            two.BackgroundImage = three.BackgroundImage;
        }
        private int GetIndex()
        {
            int number;
            do
            {
                number = rand.Next(0, 8);
            }while (used.Contains(number));
            used.Add(number);
            return number;
        } 
        private void CreateImages()
        {
            Bitmap originalImage = image;

            Rectangle rect = new Rectangle(0, 0, originalImage.Width / 3, originalImage.Height/3);
            Bitmap firstCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()]= firstCell;
            correctImages[0]= firstCell;

            rect = new Rectangle(originalImage.Width / 3, 0, originalImage.Width / 3, originalImage.Height/3);
            Bitmap secondCell= originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = secondCell;
            correctImages[1] = secondCell;

            rect = new Rectangle(originalImage.Width / 3*2, 0, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap thirdCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = thirdCell;
            correctImages[2] = thirdCell;

            rect = new Rectangle(0, originalImage.Height / 3, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap fourthCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = fourthCell;
            correctImages[3] = fourthCell;

            rect = new Rectangle(originalImage.Width / 3, originalImage.Height / 3, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap fifthCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = fifthCell;
            correctImages[4] = fifthCell;

            rect = new Rectangle(originalImage.Width / 3*2, originalImage.Height / 3, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap sixthCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = sixthCell;
            correctImages[5]=sixthCell;

            rect = new Rectangle(0, originalImage.Height / 3*2, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap seventhCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = seventhCell;
            correctImages[6]=seventhCell;

            rect = new Rectangle(originalImage.Width / 3, originalImage.Height / 3*2, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap eightCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[GetIndex()] = eightCell;
            correctImages[7]=eightCell;

            rect = new Rectangle(originalImage.Width / 3 * 2, originalImage.Height / 3*2, originalImage.Width / 3, originalImage.Height / 3);
            Bitmap ninthCell = originalImage.Clone(rect, originalImage.PixelFormat);
            imageArray[8] = null;
            correctImages[8] = null;

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackgroundImage == null) { Swap(ref pictureBox2, ref pictureBox1); }
            if (pictureBox4.BackgroundImage == null) { Swap(ref pictureBox4, ref pictureBox1); }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage == null) { Swap(ref pictureBox2, ref pictureBox1); }
            if (pictureBox3.BackgroundImage == null) { Swap(ref pictureBox2, ref pictureBox3); }
            if (pictureBox5.BackgroundImage == null) { Swap(ref pictureBox2, ref pictureBox5); }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackgroundImage == null) { Swap(ref pictureBox2, ref pictureBox3); }
            if (pictureBox6.BackgroundImage == null) { Swap(ref pictureBox6, ref pictureBox3); }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage == null) { Swap(ref pictureBox4, ref pictureBox1); }
            if (pictureBox5.BackgroundImage == null) { Swap(ref pictureBox4, ref pictureBox5); }
            if (pictureBox7.BackgroundImage == null) { Swap(ref pictureBox4, ref pictureBox7); }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackgroundImage == null) { Swap(ref pictureBox5, ref pictureBox2); }
            if (pictureBox4.BackgroundImage == null) { Swap(ref pictureBox5, ref pictureBox4); }
            if (pictureBox6.BackgroundImage == null) { Swap(ref pictureBox5, ref pictureBox6); }
            if (pictureBox8.BackgroundImage == null) { Swap(ref pictureBox5, ref pictureBox8); }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackgroundImage == null) { Swap(ref pictureBox6, ref pictureBox3); }
            if (pictureBox5.BackgroundImage == null) { Swap(ref pictureBox6, ref pictureBox5); }
            if (pictureBox9.BackgroundImage == null) { Swap(ref pictureBox6, ref pictureBox9); }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackgroundImage == null) { Swap(ref pictureBox7, ref pictureBox4); }
            if (pictureBox8.BackgroundImage == null) { Swap(ref pictureBox7, ref pictureBox8); }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackgroundImage == null) { Swap(ref pictureBox8, ref pictureBox5); }
            if (pictureBox7.BackgroundImage == null) { Swap(ref pictureBox8, ref pictureBox7); }
            if (pictureBox9.BackgroundImage == null) { Swap(ref pictureBox8, ref pictureBox9); }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackgroundImage == null) { Swap(ref pictureBox9, ref pictureBox6); }
            if (pictureBox8.BackgroundImage == null) { Swap(ref pictureBox9, ref pictureBox8); }
        }

        private void clicked(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                mouse_clicked = true;
            }
        }
        private void released(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                mouse_clicked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
