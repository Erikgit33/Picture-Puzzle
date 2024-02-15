using Picture_Puzzle_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Picture_Puzzle_
{
    public partial class Form1 : Form
    {
        Image[] imagesFirst = { Resources.dog_1a, Resources.dog_2a, Resources.dog_3a, Resources.dog_4a };
        Image[] imagesSecond = { Resources.dog_1b, Resources.dog_2b, Resources.dog_3b, Resources.dog_4b };
        Image[] imagesThird = { Resources.dog_1c, Resources.dog_2c, Resources.dog_3c, Resources.dog_4c };
        Image[] imagesFourth = { Resources.dog_1d, Resources.dog_2d, Resources.dog_3d, Resources.dog_4d };
        //Four arrays and integrals working "together", Ex when first = 3, the first array will be on index 4, containing the picture dog_4a.
        int first = 0;
        int second = 1;
        int third = 2;
        int fourth = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == imagesFirst[fourth])
            {
                //When the picturebox is clicked and the array is at the picture in its last index, the picture in the box will
                //switch to the picture in the first index, essentially starting over. 
                pictureBox1.Image = imagesFirst[first];
            }
            
            if (first == 3)
            {
                first = 0;
            }
            else //When the fourth index, 3, is reached, the variable "first" is set to 0, making the array begin again because 
                 // of it basing what index it is on by reading the variable.
            {
                first++;
            }
            pictureBox1.Image = imagesFirst[first];
            if (first == second && first == third && first == fourth)
            {
                //When all all indexes are the same, i.e when the puzzle is complete, a messagebox appears that says that you completed the puzzle.
                MessageBox.Show("You completed the puzzle!");
            }
        }
               
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == imagesSecond[fourth])
            {
                pictureBox2.Image = imagesSecond[first];
            }

            if (second == 3)
            {
                second = 0;
            }
            else
            {
                second++;
            }
            pictureBox2.Image = imagesSecond[second];
            if (first == second && first == third && first == fourth)
            {
                MessageBox.Show("You completed the puzzle!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == imagesThird[fourth])
            {
                pictureBox3.Image = imagesThird[first];
            }

            if (third == 3)
            {
                third = 0;
            }
            else
            {
                third++;
            }
            pictureBox3.Image = imagesThird[third];
            if (first == second && first == third && first == fourth)
            {
                MessageBox.Show("You completed the puzzle!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == imagesFourth[fourth])
            {
                pictureBox4.Image = imagesFourth[first];
            }
       
            if (fourth == 3)
            {
                fourth = 0;
            }
            else
            {
                fourth++;
            }
            pictureBox4.Image = imagesFourth[fourth];
            if (first == second && first == third && first == fourth)
            {
                MessageBox.Show("You completed the puzzle!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imagesFirst[first];
            pictureBox2.Image = imagesSecond[second];
            pictureBox3.Image = imagesThird[third];
            pictureBox4.Image = imagesFourth[fourth];
        }
    }
}
