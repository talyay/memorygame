using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {// משתנים גלובלים
        Random rnd = new Random();
        PictureBox[] allp;

        public Form1()
        {
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e)//לעשות כפתור רק כשלוחצים עליו זה מפעיל את שלושתם
          {
        // buildpicture(40);
        //  shuffle();
        //     showboard(8,5);
  }//
        private void shuffle()
        {
            int num;
            PictureBox tmp;
            for (int i = 0; i < allp.Length; i++)
            {
                num = rnd.Next(0, allp.Length);
                tmp = allp[i];
                allp[i] = allp[num];
                allp[num] = tmp;
            }
        }
        private void showboard(int row, int col)
        {
            int x = 100, y = 100;
            int place = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    allp[place].Location = new Point(x, y);
                    x += 85;
                    Controls.Add(allp[place++]);
                }
                y += 85;
                x = 100;
            }
        }
        private void buildpicture(int size)
        {
            int picnum = 1;
            allp = new PictureBox[size];
            for (int i = 0; i < allp.Length - 1; i += 2)
            {
                allp[i] = new PictureBox();
                allp[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("pic" + (picnum));
                allp[i].Size = new Size(80, 80);
                allp[i].SizeMode = PictureBoxSizeMode.StretchImage;
                allp[i].BorderStyle = BorderStyle.FixedSingle;
                allp[i].Tag = (i + 1) + "";
                allp[i].Click += allP_Click;
                allp[i + 1] = new PictureBox();
                allp[i + 1].Image = (Image)Properties.Resources.ResourceManager.GetObject("pic" + (picnum++));
                allp[i + 1].Size = new Size(80, 80);
                allp[i + 1].SizeMode = PictureBoxSizeMode.StretchImage;
                allp[i + 1].BorderStyle = BorderStyle.FixedSingle;
                allp[i + 1].Tag = (i + 1) + "";
                allp[i + 1].Click += allP_Click;
            }
        }
        private void allP_Click(object sender, EventArgs e)
        {
           
        }
         private void picturebox1_click(object sender , EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buildpicture(40);
            shuffle();
            showboard(8, 5);
            btn1.Hide();
        }
    }
}



