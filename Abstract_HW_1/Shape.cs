using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Abstract_HW_1
{
	abstract class Shape
	{
		public abstract double Area();
		public abstract double Perimetr();
		public abstract void Info();
		public abstract void Draw(Graphics g);
		public abstract void Draw();
	}
}
