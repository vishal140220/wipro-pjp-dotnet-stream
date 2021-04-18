using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
	interface Account
	{
		void calculate_interest();
	}
	class SBAccount : Account
	{
		double interest_rate, amount;
		public void calculate_interest()
		{
			Console.WriteLine("Enter the Average amount in your account");
			amount = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Interest Rate : For normal account it is 4% and for nri account it is 6%");
			interest_rate = double.Parse(Console.ReadLine());
			Console.WriteLine("Interest gained:Rs." + (amount * interest_rate) / 100);
		}
	}
	class FDAccount : Account
	{
		double interest_rate, amount;
		double net;
		int No_of_days, age;
		public void calculate_interest()
		{
			try
			{
				Console.WriteLine("Enter the FD Amount");
				amount = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter no of days:");
				No_of_days = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter your age:");
				age = int.Parse(Console.ReadLine());
				if (No_of_days > 0)
				{
					if (amount <= 10000000)
					{
						if (age > 60)
						{
							if (No_of_days >= 7 && No_of_days <= 14)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 5) / 100);
							}
							else if (No_of_days >= 15 && No_of_days <= 29)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 5.25) / 100);
							}
							else if (No_of_days >= 30 && No_of_days <= 45)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 6) / 100);
							}
							else if (No_of_days >= 45 && No_of_days <= 60)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 7.50) / 100);
							}
							else if (No_of_days >= 61 && No_of_days <= 184)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8) / 100);
							}
							else if (No_of_days >= 184 && No_of_days <= 366)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.50) / 100);
							}

						}
                        else
                        {

							if (No_of_days >= 7 && No_of_days <= 14)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 4.50) / 100);
							}
							else if (No_of_days >= 15 && No_of_days <= 29)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 4.75) / 100);
							}
							else if (No_of_days >= 30 && No_of_days <= 45)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 5.50) / 100);
							}
							else if (No_of_days >= 45 && No_of_days <= 60)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 7) / 100);
							}
							else if (No_of_days >= 61 && No_of_days <= 184)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 7.50) / 100);
							}
							else if (No_of_days >= 184 && No_of_days <= 366)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8) / 100);
							}
						}
					}
					else
                    {
						if (No_of_days >= 7 && No_of_days <= 14)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 6.5) / 100);
						}
						else if (No_of_days >= 15 && No_of_days <= 29)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 6.75) / 100);
						}
						else if (No_of_days >= 30 && No_of_days <= 45)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 6.75) / 100);
						}
						else if (No_of_days >= 45 && No_of_days <= 60)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 8) / 100);
						}
						else if (No_of_days >= 61 && No_of_days <= 184)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.50) / 100);
						}
						else if (No_of_days >= 184 && No_of_days <= 366)
						{
							Console.WriteLine("Interest gained is:Rs." + (this.amount * 10) / 100);
						}
					}
				}
                else
                {
					throw new myexception();
                }
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	class myexception:Exception
        {
            public override string Message 
            {
                get { return "invalid input for no of days"; }
            }
        }
		class RDAccount : Account
		{
			double interest_rate, amount;
			int months, age;
			public void calculate_interest()
			{
				try
				{
					Console.WriteLine("Enter the RD Amount");
					amount = double.Parse(Console.ReadLine());
					Console.WriteLine("Enter no of quarterly months starting from 6:");
					months = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter your age:");
					age = int.Parse(Console.ReadLine());
					if (months > 0)
					{
						if (age > 60)
						{
							if (months == 6)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 7.5) / 100);
							}
							else if (months==9)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 7.75) / 100);
							}
							else if (months==12)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8) / 100);
							}
							else if (months==15)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.25) / 100);
							}
							else if (months==18)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.5) / 100);
							}
							else if (months==21)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.75) / 100);
							}
						}
						else
                        {
							if (months == 6)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8) / 100);
							}
							else if (months == 9)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.25) / 100);
							}
							else if (months == 12)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.5) / 100);
							}
							else if (months == 15)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 8.75) / 100);
							}
							else if (months == 18)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 9) / 100);
							}
							else if (months == 21)
							{
								Console.WriteLine("Interest gained is:Rs." + (this.amount * 9.25) / 100);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
		class Program
		{

			static void Main(String[] args)
			{
				Console.WriteLine("Select the option" + "\n" + "     1.  Interest Calculator-SB" + "\n" + "     2.  Interest Calculator-FD" + "\n" + "     3.  Interest Calculator-RD" + "\n" + "     4.  Exit");

				bool close = true;
				while (close)
				{
					int Option = int.Parse(Console.ReadLine());
					if (Option == 1)
					{
						SBAccount sb = new SBAccount();
						sb.calculate_interest();
						break;
					}
					else if (Option == 2)
					{
						
						FDAccount fd = new FDAccount();
						fd.calculate_interest();
						break;
					}
					else if (Option == 3)
					{
						RDAccount rd = new RDAccount();
						rd.calculate_interest();
						break;
					}
					else if (Option == 4)
					{
						close = true;
						break;
					}
					else
					{
						Console.WriteLine("Please Enter Correct Option");
						break;
					}
				}
				Console.ReadKey();
			}

		}

	}
}




	


