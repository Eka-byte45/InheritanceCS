using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW_1
{
	internal class Circle : Shape
	{
		double radius;
		public const double PI = Math.PI;
		int x, y;
		public double Radius
		{
			get {return radius;}
			set {radius = value;}	
		}
			
		public Circle(int x, int y,double Radius)
		{
			this.x = x;
			this.y = y;
			this.Radius = Radius;
		}

		public override double Area()
		{
			return PI* Radius*Radius;
		}

		public override double Perimetr()
		{
			return  2*PI*Radius;
		}

		public override void Info()
		{
            Console.WriteLine($"Радиус круга равен {Radius},площадь круга {Area()}, длина окружности {Perimetr()}");
		}

		public override void Draw(Graphics g)
		{

			Pen redPen = Pens.Red;
			int diameter = (int)(2*radius);
			g.DrawEllipse(redPen, new System.Drawing.Rectangle(x - (int)Radius, y - (int)Radius, diameter, diameter));

		}

		public override void Draw()
		{
				
		}
	}
}
