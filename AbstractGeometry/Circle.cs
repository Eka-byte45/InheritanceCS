using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	 
	internal class Circle : Shape,IHaveDiameter
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
				/*value < MIN_SIZE ? MIN_SIZE :
				value > MAX_SIZE ? MAX_SIZE :
				value;*/
		}

		public Circle(double radius,int startX,int startY,int lineWidth,Color color)
			:base(startX,startY, lineWidth, color)
		{
			Radius = radius;
		}

		public override double GetArea()=> Math.PI*Math.Pow(Radius,2);
		public override double GetPerimeter()=> 2*Math.PI*Radius;
		public double GetDiameter() => 2 * Radius;

		public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color,LineWidth);
			float centerX = StartX + (float)Radius;
			float centerY = StartY + (float)Radius;

			float startX = centerX - (float)Radius;
			float startY = centerY;
			float endX = centerX + (float)Radius;
			float endY = centerY;
			e.Graphics.DrawLine(pen, startX, startY, endX, endY);
		}
		
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color,LineWidth);
			//SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawEllipse(pen, StartX, StartY,(float)Radius*2,(float)Radius*2);
			//e.Graphics.FillEllipse(brush, StartX, StartY, (float)Radius*2, (float)Radius*2);
		}

		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Радиус:{Radius}");
            Console.WriteLine($"Диаметр: {GetDiameter()}");
			base.Info(e);
			DrawDiameter(e);
		}
	}
}
