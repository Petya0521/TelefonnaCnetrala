using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneExchange
{
	public abstract class Danni:IPrint
	{
		private int phonenumber;
		public int PhoneNumber
		{
			get { return phonenumber; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException(
						"value"
					);
				}
				this.phonenumber = value;
			}

		}
		private string name;
		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException(
						"value"
					);
				}
				this.name = value;
			}
		}
		
		
		public Danni(int phonenumber, string name)
		{
			this.PhoneNumber = phonenumber;
			this.Name = name;
			
			
		}

		public virtual void Print()
		{
			Console.WriteLine($"{this.phonenumber} {this.name} ");
		}
	}
}



