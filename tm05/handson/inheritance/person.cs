using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class person
	{
		private String FirstName, LastName, Emailid;
		private DateTime DateofBirth;
		private int k;
		public person()
		{ }
		public person(String fn, String ln, String emailid, DateTime dob)
		{
			this.FirstName = fn;
			this.LastName = ln;
			this.DateofBirth = dob;
			this.Emailid = emailid;
			TimeSpan age = DateTime.Today - DateofBirth;
			k = (int)Math.Floor(age.Days / (365.255));
		}
		public bool isAdult
		{
			get
			{
				if (k > 18)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public string SunSign
		{
			get
			{
				if ((DateofBirth.Month == 1) && (DateofBirth.Day >= 22) || (DateofBirth.Month == 2) && (DateofBirth.Day <= 19))
				{
					string x = "sunsign is Aquarius";
					return x;
				}

				else if ((DateofBirth.Month == 2) && (DateofBirth.Day >= 20) || (DateofBirth.Month == 3) && (DateofBirth.Day <= 20))
				{
					string x = "sunsign is Pisces";
					return x;
				}

				else if ((DateofBirth.Month == 3) && (DateofBirth.Day >= 21) || (DateofBirth.Month == 4) && (DateofBirth.Day <= 20))
				{
					string x = "sunsign is Aries";
					return x;
				}

				else if ((DateofBirth.Month == 4) && (DateofBirth.Day >= 21) || (DateofBirth.Month == 5) && (DateofBirth.Day <= 20))
				{
					string x = "sunsign is Taurus";
					return x;
				}

				else if ((DateofBirth.Month == 5) && (DateofBirth.Day >= 21) || (DateofBirth.Month == 6) && (DateofBirth.Day <= 21))
				{
					string x = "sunsign is Gemini";
					return x;
				}

				else if ((DateofBirth.Month == 6) && (DateofBirth.Day >= 22) || (DateofBirth.Month == 7) && (DateofBirth.Day <= 22))
				{
					string x = "sunsign is Cancer";
					return x;
				}

				else if ((DateofBirth.Month == 7) && (DateofBirth.Day >= 23) || (DateofBirth.Month == 8) && (DateofBirth.Day <= 23))
				{
					string x = "sunsign is Leo";
					return x;
				}

				else if ((DateofBirth.Month == 8) && (DateofBirth.Day >= 24) || (DateofBirth.Month == 9) && (DateofBirth.Day <= 23))
				{
					string x = "sunsign is Virgo";
					return x;
				}

				else if ((DateofBirth.Month == 9) && (DateofBirth.Day >= 24) || (DateofBirth.Month == 10) && (DateofBirth.Day <= 23))
				{
					string x = "sunsign is Libra";
					return x;
				}

				else if ((DateofBirth.Month == 10) && (DateofBirth.Day >= 24) || (DateofBirth.Month == 11) && (DateofBirth.Day <= 22))
				{
					string x = "sunsign is Scorpio";
					return x;
				}

				else if ((DateofBirth.Month == 11) && (DateofBirth.Day >= 23) || (DateofBirth.Month == 12) && (DateofBirth.Day <= 21))
				{
					string x = "sunsign is Sagittarius";
					return x;
				}

				else
				{
					string x = "sunsign is Capricorn";
					return x;
				}
			}
	
		}
		public bool isbirthday
        {
            get { if(DateTime.Today==DateofBirth)
                {
					return true;
                }
                else
                {
					return false;
                }
            }
        }
		public string screenname
        {
			get
			{
				String a = LastName[0].ToString();
				int b = DateofBirth.Month;
				int c = DateofBirth.Day;
				string r = a + FirstName + c + b;
				return r;
			}
        }
		

		class Employee:person
		{
			double salary;
			
			static void Main(String[] args)
			{
				DateTime dateTime = new DateTime(2000, 2, 14);
				Employee e = new Employee();

				person p1  = new person("vishal", "paranisuresh", "p.vishal140220@gmail.com", dateTime);
				bool u = e.isAdult;
				Console.WriteLine("Isadult : {0}", u);
				string v = e.SunSign;
				Console.WriteLine("Sunsign : {0}", v);
				bool h = e.isbirthday;
				Console.WriteLine("Isbirthday : {0}", h);
				string d = p1.screenname;
				Console.WriteLine("Screen name : {0}", d);
			
			}
		}

	}
}
