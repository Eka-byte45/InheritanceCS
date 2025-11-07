using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW_1
{
	internal class Square : Rectangle
	{
		public Square(int x, int y, double A): base (x,y,A,A)
		{
			
		}

	    public override void Info()
		{
            Console.WriteLine($"Сторона квадрата равна {A},площадь квадрата {Area()},периметр квадрата {Perimetr()}");
		}

		public override void Draw(Graphics g)
		{
			base.Draw(g);
		}

		public override void Draw()
		{
			base.Draw();
		}

	}
}
