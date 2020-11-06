using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combfomm
{
   
    public partial class Form1 : Form
    {
        
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
           bool startPaint = false;

        //nullable int for string Null value
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
               //setting the PenBlackColor and line width
                //btn_color.BackColor = Color.Red;
                Pen p = new Pen(btn_pencolor.BackColor, float.Parse(cmb_combo.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(btn_pencolor.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and height value from TextBox(txt_ShapeSize)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                //setting startPaint and drawsquare value to false for creating one graphic on one click.
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {

                SolidBrush sb = new SolidBrush(btn_pencolor.BackColor);
                //setting the width twice of the height
              
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));

                startPaint = false;
                drawRectangle = false;

            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_pencolor.BackColor);
             

                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));

                startPaint = false;
                drawCircle = false;
            }
            }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            startPaint = false;
            initX = null;
            initY = null;
        }

        private void btn_pencolor_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_color if user click on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_pencolor.BackColor = c.Color;
            }
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_canvas_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = c.Color;
                btn_canvas.BackColor = c.Color;
            }
        }

        private void set_circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
    }
}
