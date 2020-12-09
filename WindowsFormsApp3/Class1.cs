using System;
using System.Windows.Forms;
using System.Drawing;


public abstract class Figure
{
    public Color color { get; set; }
    private double X;
    public double x
    {
        get
        {
            return X;
        }
        set
        {
            X = x;
        }
    }
    private double Y;
    public double y
    {
        get
        {
            return Y;
        }
        set
        {
            Y = y;
        }
    }
    public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            if (X == 550) {X = 0; }

            X += 10;
            System.Threading.Thread.Sleep(50);
        }

    }
    public class Circle : Figure
    {
    private double radius;
    public double rad
    {
        get
        {
            return radius;
        }
        set
        {
            radius = rad;
        }
    }
    public Circle() { }
        public Circle(double radius) { this.radius = radius; }
        public Circle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Circle(double x, double y, double radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack()
        {
           color = Color.Black;
        }
        public override void HideDrawingBackGround()
        {
           color = Color.White;
        }

    }
    public class Square : Figure
    {
    private double side;
    public double sideLength
    {
        get
        {
            return side;
        }
        set
        {
            side = sideLength;
        }
    }
   
        public Square() { }
        public Square(double sideLength) { this.side = sideLength; }
        public Square(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Square(double x, double y, double side)
        {
            this.sideLength = sideLength;
            this.x = x;
            this.y = y;
        }
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    public override void DrawBlack()
    {
        color = Color.Black;
    }
    public override void HideDrawingBackGround()
    {
        color = Color.White;
    }


}
    public class Rhomb : Figure
    {
        
    private double horDiag;
    public double horDiagLen
    {
        get
        {
            return horDiag;
        }
        set
        {
            horDiag = horDiagLen;
        }
    }
    private double vertDiag;
    public double vertDiagLen
    {
        get
        {
            return vertDiag;
        }
        set
        {
            vertDiag = vertDiagLen;
        }
    }
    public Rhomb() { }
        public Rhomb(double horDiagLen, double vertDiagLen)
        {
            this.horDiag = horDiagLen;
            this.vertDiag= vertDiagLen;
        }
        public Rhomb(double x, double y, double horDiagLen, double vertDiagLen)
        {
            this.x = x;
            this.y = y;
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }

    public override void DrawBlack()
    {
        color = Color.Black;
    }
    public override void HideDrawingBackGround()
    {
        color = Color.White;
    }

}

