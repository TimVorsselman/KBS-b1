﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace kbs1b
{
    class Speelveld : PictureBox
    {
       public Image start { set; get; }
       public Image finish { set; get; }
        //Player player1;
        //Input input = new Input('W', 'A', 'S', 'D');
        public Speelveld()
        {
            //player1 = new Player(input);
            start = Image.FromFile(@"E:\school\Jaar 2.2\kbs\kbs1b\start1.png");
            finish = Image.FromFile(@"E:\school\Jaar 2.2\kbs\kbs1b\finish.png");
            



              


        }

        //protected override void OnPaint(PaintEventArgs pe) {
        //    pe.Graphics.DrawImage(start, 0, 0);
        //    pe.Graphics.DrawImage(finish, 550, 300);
        //    Rectangle rect = new Rectangle(player1.XPOS, player1.YPOS, 25, 25);
        //    Color color = Color.FromArgb(255, 255, 0, 0);
        //    Pen pen = new Pen(color, 10);
        //    pe.Graphics.DrawRectangle(pen, rect);

        //}




    }
}
