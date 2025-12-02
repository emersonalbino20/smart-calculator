using static System.Console;

namespace SmartCalculator
{
	class Program
	{
		private static int Atoi(string? s)
		{
			return (int.TryParse(s, out var n) ? int.Parse(s) : 0);
		}

		private static void ShowOptions()
		{
			WriteLine("======Operations======");
			WriteLine("Addition (+):        1");
			WriteLine("Subtraction (-):     2");
			WriteLine("Multiplication (x):  3");
			WriteLine("Division (/):        4");
			WriteLine("Stop:                5");
			WriteLine("======================");
		}

		private static void AuxCalculate(int option)
		{
			var math = new Operations();

			Write("insert first value: ");
			var n1 = Atoi(ReadLine());
			Write("insert second value: ");
			var n2 = Atoi(ReadLine());
			Clear();
			if (option == 1)
				WriteLine($"{n1} + {n2} = {math.Add(n1, n2)}");
			else if (option == 2)
				WriteLine($"{n1} - {n2} = {math.Sub(n1, n2)}");
			else if (option == 3)
				WriteLine($"{n1} x {n2} = {math.Mul(n1, n2)}");
			else
				WriteLine($"{n1} / {n2} = {math.Div(n1, n2)}");
		}
	
		private static void Calculate()
		{
			int option;

			WriteLine("warning: if not pass a valid integer number, it will be treated as zero (0).");
			do{
				ShowOptions();
				Write("insert option:  ");
				option = Atoi(ReadLine());
				switch (option)
				{
					case 1:
						Clear();
						WriteLine("You chose Addition (+)");
						AuxCalculate(option);
						break;
					case 2:
						Clear();
						WriteLine("You chose Subtraction (-)");
						AuxCalculate(option);
						break;
					case 3:
						Clear();
						WriteLine("You chose Multiplication (x)");
						AuxCalculate(option);
						break;
					case 4:
						Clear();
						WriteLine("You chose Division (/)");
						AuxCalculate(option);
						break;
					case 5:
						Clear();
						WriteLine("Program Finished");
						break;
					default:
						Clear();
						WriteLine("Invalid Option");
						break;
				}
			}while (option != 5);
		}

		public static void Main(string[] args)
		{
			Calculate();
		}
	}
}
