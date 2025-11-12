using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Triangle : Shape,IHaveHeight
	{
		//protected double A, B, C;

		//public Triangle(double a, double b, double c,int startX,int startY,int lineWidth,Color color): base(startX, startY, lineWidth, color)
		//{
		//	A = FilterSize(a);
		//	B = FilterSize(b);
		//	C = FilterSize(c);
		//	if (!CanFormTriangle(A, B, C))
		//		throw new ArgumentException("Длины сторон не позволяют сформировать треугольник.");
		//}

		//bool CanFormTriangle(double a,double b,double c)
		//{
		//	return a + b > c && a + c > b && b + c > a;
		//}

		//public override double GetArea()
		//{
		//	double s = GetPerimeter() / 2;
		//	return Math.Sqrt(s*(s-A)*(s-B)*(s-C));

		//}

		//public override double GetPerimeter()
		//{
		//	return A + B + C;
		//}

		//public override void Draw(PaintEventArgs e)
		//{
		//	Pen pen = new Pen(Color);
		//	SolidBrush brush = new SolidBrush(Color);
		//	Point[] points = CalculatePoints();
		//	e.Graphics.DrawPolygon(pen, points);
		//	e.Graphics.FillPolygon(brush,points);
		//}

		//public virtual Point[] CalculatePoints()
		//{
		//	return new Point[]
		//       {
		//		new Point(StartX, StartY),
		//		new Point((int)(StartX + A), StartY),
		//		new Point((int)(StartX + A / 2), (int)(StartY + B))
		//	};
		//}

		//public override void Info(PaintEventArgs e)
		//{
		//	Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
		//	Console.WriteLine($"Сторона A:{A},сторона В:{B},сторона С:{C}");
		//	base.Info(e);
		//}

		public abstract double GetHeigth();
		public abstract void DrawHeigth(System.Windows.Forms.PaintEventArgs e);
		public Triangle(int startX,int startY, int lineWidth,System.Drawing.Color color):
			base(startX, startY, lineWidth, color) { }

		public override void Info(PaintEventArgs e)
		{

            Console.WriteLine($"Высота треугольника: {GetHeigth()}");
			base.Info(e);
		}

	}
}
