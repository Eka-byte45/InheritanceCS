using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW_1
{
	internal class Rectangle : Shape
	{
		double a;
		double b;
		int x;
		int y;
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

		public Rectangle(int x, int y,double A, double B)
		{
			this.x = x;
			this.y = y;
			this.A = A;
			this.B = B;
		}

		public override double Area()
		{
			return A * B;
		}

		public override double Perimetr()
		{
			return 2*(A+B);
		}

		public override void Info()
		{
            Console.WriteLine($"Сторона прямоугольника {A}, вторая сторона прямоугольника {B},площадь прямоугольника {Area()},периметр прямоугольника {Perimetr()}");
		}

		public override void Draw(Graphics g)
		{
			Pen redPen = Pens.Red;
			int width = (int)Math.Round(A);
			int height = (int)Math.Round(B);
			g.DrawRectangle(redPen, new System.Drawing.Rectangle(x,y,width,height));
		}

		public override void Draw()
		{
			for (int i = 0; i < B; i++)
			{
				for(int j = 0; j < A; j++)
				{
					Console.SetCursorPosition(x+i, y+j);	
                    Console.WriteLine('*');
				}
			}
			
		}

	}
}
