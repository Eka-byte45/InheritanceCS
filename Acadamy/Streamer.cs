using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	class Streamer
	{
		void SetDirectory()
		{
            Console.WriteLine(Directory.GetCurrentDirectory());
			string location = System.Windows.Forms.Application.ExecutablePath;
			Directory.SetCurrentDirectory($"{location}\\..\\..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
		}
		static readonly string delimetr = "\n----------------------------------------------------------------------------------------------------------------------------\n";

		public void Print(Human[] group)
		{

		    for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
				Console.WriteLine(delimetr);
			}
			Console.WriteLine();

		}
		public void Save(Human[] group, string fileName)
		{
			SetDirectory();
			StreamWriter writer = new StreamWriter(fileName);
			for (int i = 0; i < group.Length; i++)
			{
				writer.WriteLine(group[i].ToStringCSV());
			}
			writer.Close();
			System.Diagnostics.Process.Start("notepad", fileName);
		}

		public Human[] Load(string fileName)
		 {
			SetDirectory() ;
			List<Human> group = new List<Human>();
			StreamReader reader = new StreamReader(fileName);
			try
			{
				while (!reader.EndOfStream)
				{
					string buffer = reader.ReadLine();
					string[] values = buffer.Split(',');
					//Human human = HumanFactory(values.First());
					//human.Init(values);
					//group.Add(human);
					group.Add(HumanFactory.Create(values[0]).Init(values));

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			reader.Close();
			return group.ToArray();

		 }
	}
	

}
