using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Rectangle : Shape
	{
		double width;
		double height;

		public double Width
		{ 
			get => width;
			set => width = FilterSize(value);
		}
		public double Height
		{
			get => height;
			set => height = FilterSize(value);
		}

		public Rectangle
			(
			double width, double height,
			int startX, int startY, int lineWidth,Color color
			): base (startX, startY, lineWidth, color )
		{
			Width = width;
			Height = height;
		}

		public override double GetArea() => Width * Height;
		public override double GetPerimeter()=> 2* (Width+Height);

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX,StartY,(float)Width,(float)Height);
			e.Graphics.FillRectangle(brush,StartX,StartY,(float)Width, (float)Height);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last()+":");
			Console.WriteLine($"Ширина:{Width}");
			Console.WriteLine($"Высота:{Height}");
			base.Info(e);
		}
	}
}
