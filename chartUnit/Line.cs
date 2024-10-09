using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace chartUnit
{
    public partial class Line : UserControl
    {
        public Line()
        {
            InitializeComponent();
        }

        public Color lineColor = Color.Black;

        [Description("线条颜色"), Category("自定义")]
        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }



        public enum _direction {
            Horizontal,
            Vertical,
        }
        public _direction direction = _direction.Horizontal;
        [Description("线条方向"), Category("自定义")]
        public _direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }

     


        


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen p = new Pen(lineColor);

            switch (direction)
            {
                case _direction.Horizontal:
                    g.DrawLine(p, 0, this.Height / 2, this.Width, this.Height / 2);
                    p.Dispose();
                    g.Dispose();
                break;


                case _direction.Vertical:

                    g.DrawLine(p, this.Width / 2,0, this.Width/2, this.Height);
                    p.Dispose();
                    g.Dispose();

                    break;

            }

          
        }






    }
}
