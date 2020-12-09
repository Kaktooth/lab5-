using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SolidBrush Brush;
        Circle circle;
        Square square;
        Rhomb rhomb;
        public bool clicked = false;
       
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            if (clicked == false) 
            { 
                clicked = true;
                CircleDraw();
                circle.DrawBlack();

            }
            else
            {
                CircleDraw();
                circle.HideDrawingBackGround();
                clicked = false;
                circle = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                SquareDraw();
                square.DrawBlack();

            }
            else
            {
                SquareDraw();
                square.HideDrawingBackGround();
                clicked = false;
                square = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                RhombDraw();
                rhomb.DrawBlack();

            }
            else
            {
                RhombDraw();
                rhomb.HideDrawingBackGround();
                clicked = false;
                rhomb = null;
            }
        }
        public void CircleDraw()
        {

            circle = new Circle(70,80,117.3);
            circle.DrawBlack();
        }
        public void SquareDraw()
        {   
            square = new Square(56);
            square.DrawBlack();
        }
        public void RhombDraw()
        {
            rhomb =  new Rhomb(56.3,23.2);
            rhomb.DrawBlack();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (circle != null)
            {
                circle.MoveRight();
            }
            else if (square != null)
            {
                square.MoveRight();
            }
            else if (rhomb != null)
            {
               rhomb.MoveRight();
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {




            if (circle != null)
            {
                Brush = new SolidBrush(circle.color);
                e.Graphics.FillEllipse(Brush, (float)circle.x, (float)circle.y, (float)circle.rad, (float)circle.rad);
            }
            else if (square != null)
            {
                Brush = new SolidBrush(square.color);
                e.Graphics.FillRectangle(Brush, (float)square.x, (float)square.y, (float)square.sideLength, (float)square.sideLength);
            }
            else if (rhomb != null)
            {
                Brush = new SolidBrush(rhomb.color);
                using (GraphicsPath myPath = new GraphicsPath())
                {
                    myPath.AddLines(new[]
                        {
                           new Point(0+ Convert.ToInt32(rhomb.x), Convert.ToInt32(rhomb.horDiagLen / 2.0)),
                           new Point(Convert.ToInt32(rhomb.vertDiagLen   / 2)+ Convert.ToInt32(rhomb.x), 0),
                           new Point(Convert.ToInt32(rhomb.vertDiagLen+ rhomb.x) , Convert.ToInt32(rhomb.horDiagLen / 2.0)),
                           new Point(Convert.ToInt32(rhomb.vertDiagLen  / 2)+ Convert.ToInt32(rhomb.x), Convert.ToInt32(rhomb.horDiagLen))
                    });
                    using (Brush)
                        
                        e.Graphics.FillPath(Brush, myPath);
                   
                }    
            }
            
        }

    }
}
