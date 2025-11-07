using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW_1
{
	internal class Triangle :Shape
	{
		double a,b,c;
		public double A
		{
			get { return a; }
			set { a = value; }
		}

		public double B
		{
			get { return b; }
			set { b = value; }
		}
		public double C
		{
			get { return c; }
			set { c = value; }
		}

		public Triangle(double A, double B, double C)
		{
			this.A = A;
			this.B = B;
			this.C = C;
		}
		public override double Perimetr()
		{
			return A + B + C;
		}
		public override double Area()
		{
			if(!(A+B > C && A+C > B && B+C > A))
			{
				throw new InvalidOperationException("Стороны не образуют треугольник.");
			}
			double semiPerimeter = Perimetr() / 2; 
			return Math.Sqrt(semiPerimeter *
			(semiPerimeter - A) *
			(semiPerimeter - B) *
			(semiPerimeter - C));
		}

		public override void Info()
		{
            Console.WriteLine($"Первая сторона треугольника: {A}, вторая сторона треугольника: {B}, основание треугольника {C}," +
							  $" площадь треугольника {Area()}, периметр треугольника {Perimetr()}");
		}

		public override void Draw(Graphics g)
		{
			
			
		}

		public override void Draw()
		{
			
		}
	}
}
