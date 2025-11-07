//#define RECTANGLE
//#define SQUARE
//#define CIRCLE
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if RECTANGLE
			
			Rectangle rectangle = new Rectangle(50, 50, 100, 200);
			Bitmap bmp = new Bitmap(300, 300);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				rectangle.Draw(g);
			}
			bmp.Save("rect_image.png");
			Console.WriteLine("Картинка с рисунком сохранена в 'rect_image.png'.");
			rectangle.Info();

#endif

#if SQUARE
			Square square = new Square(50, 50, 100, 200);

			Bitmap bmp2 = new Bitmap(300, 300);

			using (Graphics g = Graphics.FromImage(bmp2))
			{
				square.Draw(g);
			}
			bmp2.Save("square_image.png");
			Console.WriteLine("Картинка с рисунком сохранена в 'square_image.png'.");
			square.Info();
#endif
#if CIRCLE
			Circle circle = new Circle(50, 50, 50);
			Bitmap bmp3 = new Bitmap(300, 300);
			using (Graphics g = Graphics.FromImage(bmp3))
			{
				circle.Draw(g);
			}
			bmp3.Save("circle_image.png");
			Console.WriteLine("Картинка с рисунком сохранена в 'circle_image.png'.");
			circle.Info();
#endif

			Rectangle rectangle = new Rectangle(10, 10, 8, 4);
			rectangle.Info();
			rectangle.Draw();

			Console.WriteLine();

			Square square = new Square(20, 20, 5);
			square.Info();
			square.Draw();

			Console.WriteLine();

			Circle circle = new Circle(40, 40,6);
			circle.Info();

			Console.WriteLine();

			Triangle triangle = new Triangle(5,5,5);
			triangle.Info();
		}
	}
	
}
