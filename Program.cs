using System;
using System.Collections.Generic;
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
				int count = int.Parse(Console.ReadLine());
				List<Danni> list = new List<Danni>();
				for (int i = 0; i < count; i++)
				{
					var danni = Console.ReadLine().Split();
					Danni profession = new Profession(int.Parse(danni[0]), danni[1], int.Parse(danni[2]), danni[3], danni[4]);
					list.Add(profession);
				}

				list.Sort();
				Console.WriteLine(list.Select(x => x.Age).Min());
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




