#define ADSTRACT_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;//DllImport
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static readonly string delimetr = "\n-------------------------------------\n";
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			//e.Graphics.DrawRectangle(new Pen(Color.Red),300,100,500,300);
#if ABSTRACT_1
			Rectangle rectangle = new Rectangle(80, 50, 400, 60, 2, Color.Coral);
			rectangle.Info(e);
			Console.WriteLine(delimetr);

			Square square = new Square(75, 500, 50, 3, Color.Red);
			square.Info(e);
			Console.WriteLine(delimetr);

			Circle circle = new Circle(55, 600, 40, 2, Color.BlueViolet);
			circle.Info(e);
			Console.WriteLine(delimetr);

			//Triangle triangle = new Triangle(100,100,20,700,30,2,Color.DarkGreen);
			//triangle.Info(e);
			//Console.WriteLine(delimetr);

			//RectangleTriangle triangle2 = new RectangleTriangle(900, 100, 2, Color.DarkTurquoise,50,90);
			//triangle2.Info(e);

			IsoscelesTriangle iso = new IsoscelesTriangle(75, 150, 700, 30, 3, Color.Blue);
			iso.Info(e);
			Console.WriteLine(delimetr);
			EquilaterTriangle equ = new EquilaterTriangle(50, 800, 20, 4, Color.Yellow);
			equ.Info(e);
			
#endif
		
		Shape[] shapes =
		{
			new Rectangle(80, 50, 400, 60, 2, Color.Coral),
			new Square(75, 500, 50, 3, Color.Red),
			new Circle(55, 600, 40, 2, Color.BlueViolet),
			new IsoscelesTriangle(75, 150, 700, 30, 3, Color.Blue),
			new EquilaterTriangle(50, 800, 20, 4, Color.Yellow)
		};

		for(int i = 0; i < shapes.Length;++i)
		{
			if (!(shapes[i] is IHaveDiagonal))
			{
				shapes[i].Draw(e);
			}	
		}
	}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
