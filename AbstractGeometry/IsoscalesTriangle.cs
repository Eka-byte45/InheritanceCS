using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle : Triangle
	{
		double @base;//'base' колючевое слово, означающее базовый класс.
					 //Ключевые слова нельзя использовать для именования
					 //своих сущностей, но если перед ключевым слово поставить @,
					 //то его можно использовать для именования своих сущностей
		double side;
		public double Base
		{
			get=> @base;
			set => @base = FilterSize(value);
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}

		public IsoscelesTriangle(double @base, double side, int startX, int startY,int lineWidth, System.Drawing.Color color):
			base(startX, startY, lineWidth, color)
		{
			Base = @base;
			Side = side;
		}

		public override double GetHeigth()
		{
			return Math.Sqrt(Math.Pow(Side, 2)-Math.Pow(Base/2, 2));
		}
		public override double GetArea()
		{
			return Base * GetHeigth() / 2;
		}
		public override double GetPerimeter()
		{
			return 2 * Side + Base;
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			Point[] vertices = new Point[]
			{
				new Point(StartX,StartY+(int)GetHeigth()),
				new Point(StartX+(int)Base,StartY+(int)GetHeigth()),
				new Point(StartX+(int)Base/2,StartY)
			};
			e.Graphics.DrawPolygon(pen, vertices);
				
		}
		public override void DrawHeigth(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, 1);
			float centerX = StartX + (float)(Base/2);
			float topY = StartY;
			float bottomY = StartY + (float)GetHeigth();
			e.Graphics.DrawLine(pen,centerX,topY,centerX,bottomY);
		}

		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Основание: {Base}");
            Console.WriteLine($"Сторона: {Side}");
			base.Info(e);
			DrawHeigth(e);
		}
	}
}
