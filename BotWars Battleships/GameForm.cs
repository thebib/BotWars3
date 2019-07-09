using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotWars_Battleships
{
    public partial class GameForm : Form
    {
        public GameManager manager;
        public GameForm(GameManager manager)
        {
            //Tell the Game Manager to Open Comms
            Task t = manager.PlayerRegisterCommunications();
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF[] Square = new PointF[] {
            new Point(pictureBox1.Width / 2, 0 ),
            new Point(pictureBox1.Width, pictureBox1.Height /2 ),
            new Point(pictureBox1.Width / 2,pictureBox1.Height ),
            new Point(0, pictureBox1.Height / 2)
            };
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillPolygon(new SolidBrush(Color.Blue), Square);

            int arenaSize = 10;
            float Seasize = 1.0f / arenaSize;

            for(float i = 0; i < 1.0f; i = i + Seasize)
            {
                PointF t1 = Fraction(i, Square[0], Square[1]);
                PointF b1 = Fraction(i, Square[3], Square[2]);

                PointF t2 = Fraction(i, Square[1], Square[2]);
                PointF b2 = Fraction(i, Square[0], Square[3]);

                g.DrawLine(new Pen(Color.AliceBlue, 3), t1, b1);
                g.DrawLine(new Pen(Color.AliceBlue, 3), t2, b2);

            }

            
        }
        public PointF Fraction(float frac, PointF p1, PointF p2)
        {
            return new PointF(p1.X + frac * (p2.X - p1.X),
                               p1.Y + frac * (p2.Y - p1.Y));
        }
    }
}
