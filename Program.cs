using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
	public class Program
	{
		static void Main(string[] args)

		{
			try
			{
			StreamWriter streamWriter = new StreamWriter("project.txt");
				int count = int.Parse(Console.ReadLine());
				List<Profession> list = new List<Profession>();
				for (int i = 0; i < count; i++)
				{
					var danni = Console.ReadLine().Split();
					Profession profession = new Profession(int.Parse(danni[0]), danni[1], danni[2],int.Parse( danni[3]), danni[4]);
					list.Add(profession);
					using (streamWriter)
					{
						streamWriter.Write(danni[0]);
						streamWriter.Write(danni[1]);
						streamWriter.Write(danni[2]);
						streamWriter.Write(danni[3]);
					}
				}

				list.Sort();
				Console.WriteLine(list.Select(x =>x.Age).Min());
				list.ForEach(x => x.Print());
			}
			catch (ArgumentException exception)
			{
				Console.WriteLine($"ArgException: {exception.Message}");
				throw;
			}
			


		}
	}
}




