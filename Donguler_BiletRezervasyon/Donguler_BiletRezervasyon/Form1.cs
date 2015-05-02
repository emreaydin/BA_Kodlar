using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_BiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button btn = new Button();
            //btn.Location=new Point(10,30);
            //btn.Size = new System.Drawing.Size(50, 50);
            //gbKoltuklar.Controls.Add(btn);

            //Button btn2 = new Button();
            //btn2.Location=new Point(10+btn.Width+10,30);
            //btn2.Size = new System.Drawing.Size(50, 50);
            //gbKoltuklar.Controls.Add(btn2);

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    Button btn = new Button();
                    btn.Location = GetLocation(x, y);
                    btn.Size = new System.Drawing.Size(50, 50);
                    gbKoltuklar.Controls.Add(btn);

                    if (x == 1 && y == 8)
                    {
                        Button btn2 = new Button();
                        int pointX = 10 + ((x + 1) * 60);
                        int pointY = 30 + (y * 60);
                        btn2.Location = new Point(pointX, pointY);
                        btn2.Size = new System.Drawing.Size(50, 50);
                        gbKoltuklar.Controls.Add(btn2);

                    }
                }
            }
        }

        //Koltuğun konumuna göre groupboxtaki orjinal location değerini döndürür
        private Point GetLocation(int x, int y)
        {
            Point p = new Point();
            int pointX = 10 + (x * 60);
            int pointY = 30 + (y * 60);
            int koridor = 60;
            if (x > 1)
                pointX += koridor; //pointX = pointX + koridor;


            p.X = pointX;
            p.Y = pointY;

            return p;
        }
    }
}
