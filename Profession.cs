using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
	public class Profession: Danni,IComparable<Profession>
	{
		private string profrsiq;
		public string Profesiq
		{
			get { return profrsiq; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Error");
				}
				this.profrsiq = value;
			}
		}
		private int age;
		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException(
						"value"
					);
				}
				this.age = value;
			}
		}
		private string address;
		public string Аddress
		{
			get { return address; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException(
						"value"
					);
				}
				this.address = value;
			}

		}
		public Profession(int phonenumber, string name,string profesiq, int age, string address) : base( phonenumber,  name )
		{
			this.Profesiq = profesiq;
			this.Age = age;
			this.Аddress = address;

			
		}
		public int CompareTo(Profession obj)
		{
			int result = this.profrsiq.CompareTo(obj.profrsiq);
			if (result == 0)
				result = this.Name.CompareTo(obj.Name);
			return result;
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{this.profrsiq} {this.age}{this.address} ");
		}
	}
}
  