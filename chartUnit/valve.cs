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
    public partial class valve : UserControl
    {
        public valve()
        {
            InitializeComponent();
        }


        Point point1, point2, point3, point4;
        Point[] punit = null;

        public Color valveColor = Color.Black;
        [Description("阀门颜色"), Category("自定义")]
        public Color ValveColor
        {
            get { return valveColor; }
            set { valveColor = value;Refresh(); }//刷新
        }



        public enum _direction
        {
            Horizontal,
            Vertical,
        }
        public _direction direction = _direction.Horizontal;
        [Description("阀门方向"), Category("自定义")]
        public _direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }







        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen p = new Pen(valveColor);

            switch (direction)
            {
                case _direction.Horizontal:
                    point1 = new Point(0, 0);
                    point2 = new Point(this.Width, this.Height);
                    point3 = new Point(this.Width, 0);
                    point4 = new Point(0, this.Height);

                    punit = new Point[] { point1, point2, point3, point4 };



                    g.DrawLine(p, point1, point2);
                    g.DrawLine(p, point2, point3);
                    g.DrawLine(p, point3, point4);
                    g.DrawLine(p, point4, point1);

                    g.DrawClosedCurve(p, punit);
                    g.FillClosedCurve(new SolidBrush(valveColor), punit);
            


                    break;


                case _direction.Vertical:
                    point1 = new Point(0, 0);
                    point2 = new Point(this.Width, 0);
                    point3 = new Point(0, this.Height);
                    point4 = new Point(this.Width, this.Height);

                    punit = new Point[] { point1, point2, point3, point4 };



                    g.DrawLine(p, point1, point2);
                    g.DrawLine(p, point2, point3);
                    g.DrawLine(p, point3, point4);
                    g.DrawLine(p, point4, point1);

                    g.DrawClosedCurve(p, punit);
                    g.FillClosedCurve(new SolidBrush(valveColor), punit);

                    break;

            }


        }

    }
}
