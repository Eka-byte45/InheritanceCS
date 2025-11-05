
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Teacher : Human
	{
		public string Speciality {  get; set; }
		public int Experience { get; set; }
		public Teacher(string lastName,string firstName, int age, string speciality, int experience): base(lastName,firstName,age)
		{
			Speciality = speciality;
			Experience = experience;
            //Console.WriteLine($"TConstructor:\t{GetHashCode()}");

		}
		public Teacher(Human human, string spesiality,int experience):base(human)
		{
			Speciality= spesiality;
			Experience = experience;
			//Console.WriteLine($"TConstructor:\t{GetHashCode()}");
		}
		~Teacher()
		{
			//Console.WriteLine($"TConstructor:\t{GetHashCode()}");
		}
		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{ Speciality} { Experience}");
			
		}

		public override string ToString()
		{
			return
			base.ToString() +
			$"{Speciality.PadRight(22)}{Experience.ToString().PadRight(5)}";
		}

	}
}
