//#define INHERITANCE_1
//#define INHERITANCE_2
#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using Acadamy;

namespace Acadamy
{

	internal class Program
	{
		//static void Save(Human[] group, string fileName)
		//{
		//	StreamWriter streamWriter = new StreamWriter(fileName);
		//	foreach (Human human in group)
		//	streamWriter.WriteLine(human.ToString());
		//	streamWriter.Close();
		//}
		//public static void Save(Human[] group, string fileName)
		//{
		//	using (StreamWriter sw = new StreamWriter(fileName))
		//	{
		//		foreach (Human human in group)
		//		{
		//			if (human is Human h && !(h is Teacher || h is Student || h is Graduate))
		//			{

		//				sw.WriteLine("Human,{0},{1},{2}", h.LastName, h.FirstName, h.Age);
		//			}
		//			else if (human is Teacher t)
		//			{

		//				sw.WriteLine("Teacher,{0},{1},{2},{3},{4}",
		//					t.LastName, t.FirstName, t.Age, t.Speciality, t.Experience);
		//			}
		//			else if (human is Graduate g)
		//			{

		//				sw.WriteLine("Graduate,{0},{1},{2},{3},{4},{5},{6},{7}",
		//					g.LastName, g.FirstName, g.Age, g.Speciality, g.Group, g.Rating, g.Attendance, g.Subject);
		//			}
		//			else if (human is Student s)
		//			{

		//				sw.WriteLine("Student,{0},{1},{2},{3},{4},{5},{6}",
		//					s.LastName, s.FirstName, s.Age, s.Speciality, s.Group, s.Rating, s.Attendance);
		//			}
		//		}
		//	}
		//}
		//public static Human[] Load(string filename)
		//{
		//	List<Human> result = new List<Human>();

		//	using (StreamReader sr = new StreamReader(filename))
		//	{
		//		while (!sr.EndOfStream)
		//		{
		//			string line = sr.ReadLine()?.Trim();
		//			if (string.IsNullOrEmpty(line)) continue; 

		//			string[] parts = line.Split(',');
		//			if (parts.Length < 3) continue; 

		//			switch (parts[0])
		//			{
		//				case "Human":
		//					result.Add(new Human(parts[1], parts[2], int.Parse(parts[3]))); break;
		//				case "Teacher":
		//					result.Add(new Teacher(parts[1], parts[2], int.Parse(parts[3]), parts[4], int.Parse(parts[5]))); break;
		//				case "Student":
		//					result.Add(new Student(parts[1], parts[2], int.Parse(parts[3]), parts[4], parts[5], int.Parse(parts[6]), double.Parse(parts[7]))); break;
		//				case "Graduate":
		//					result.Add(new Graduate(parts[1], parts[2], int.Parse(parts[3]), parts[4], parts[5], int.Parse(parts[6]), double.Parse(parts[7]), parts[8])); break;
		//				default:
		//					continue; 

		//			}
		//		}
		//	}

		//	return result.ToArray();
		//}
		static readonly string delimetr = "\n----------------------------------------------------------------------------------------------------------------------------\n";

		static void Main(string[] args)
		{
#if INHERITANCE_1
			Console.WriteLine("Acadamy");

			Human human = new Human("Montana", "Antonio ", 25);
			human.Info();

			Console.WriteLine(delimetr);

			Student student = new Student("Pinkman", "Jessie ", 22, "Chemistry ", "WW_220", 90, 95);
			student.Info();

			Console.WriteLine(delimetr);

			Teacher teacher = new Teacher("White", "Walter ", 50, "Chemisrty ", 25);
			teacher.Info();
			Console.WriteLine(delimetr);

#endif

#if INHERITANCE_2
			Human human = new Human("Pinkman", "Jessie", 22);
			human.Info();
			Console.WriteLine(delimetr);

			Student student = new Student(human, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimetr);

			Teacher teacher = new Teacher(new Human("White", "Walter", 50), "Chemistry", 25);
			teacher.Info();

			Console.WriteLine(delimetr);

			Human h_hank = new Human("Shreder", "Hank", 40);
			Student s_hank = new Student(h_hank, "Criminalistic", "OBN", 50, 60);

			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
			graduate.Info();

#endif
#if WRITE_TO_FILE
            Human[] group =
			{
				new Student("Pinkman", "Jessie ", 22, "Chemistry ", "WW_220", 90, 95),
				new Student("Varcetty","Tommy",30, "Theft","Vice",98,99),
				new Graduate("Schreder","Hank",40,"Criminalistic","OBN",50,60,"How to catch Heisenberg"),
				new Teacher("White", "Walter ", 50, "Chemisrty ", 25),
				new Teacher("Diaz","Ricardo",50,"Weaspon distribution ",20),
				new Teacher("Schwazenegger","Arnold",78,"Heavy Metal",65)
			};
			//Specialisation
			Console.WriteLine(delimetr);
			for (int i = 0; i < group.Length; i++)
			{
				//group[i].Info();
				Console.WriteLine(group[i].ToString());
				Console.WriteLine(delimetr);
			}
			//Streamer streamer = new Streamer();
			//streamer.Save(group, "group.txt");
			//Save(group,@"group_data.txt");

			//string filename = @"group_data.txt";
			//Human[] loadedGroup = Load(filename); 
			//foreach (Human h in loadedGroup)
			//{
			//	Console.WriteLine(h.ToString()); 
			//}	


#endif
			Streamer streamer = new Streamer();
			Human[] group1= streamer.Load("group.txt");
			streamer.Print(group);
		}




	}	
}
	



		
		
	

