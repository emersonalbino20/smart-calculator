namespace SmartCalculator
{
	class Program
	{
		private static int Atoi(string s)
		{
			return (int.TryParse(s, out int n) ? int.Parse(s) : 0);
		}

		private static void ShowOptions()
		{
			Console.WriteLine("======Operations======");
			Console.WriteLine("Addition (+):        1");
			Console.WriteLine("Subtraction (-):     2");
			Console.WriteLine("Multiplication (x):  3");
			Console.WriteLine("Division (/):        4");
			Console.WriteLine("Stop:                5");
			Console.WriteLine("======================");
		}

		private static void AuxCalculate(int option)
		{
			int n1, n2;
			Operations math = new Operations();

			Console.WriteLine("insert first value: ");
			n1 = Atoi(Console.ReadLine());
			Console.Write("insert second value: ");
			n2 = Atoi(Console.ReadLine());
			Console.Clear();
			if (option == 1)
				Console.WriteLine($"{n1} + {n2} = {math.Add(n1, n2)}");
			else if (option == 2)
				Console.WriteLine($"{n1} - {n2} = {math.Sub(n1, n2)}");
			else if (option == 3)
				Console.WriteLine($"{n1} x {n2} = {math.Mul(n1, n2)}");
			else
				Console.WriteLine($"{n1} / {n2} = {math.Div(n1, n2)}");
		}
	
		private static void Calculate()
		{
			int option;

			Console.WriteLine("warning: if not pass a valid integer number, it will treat as zero (0).");
			do{
				ShowOptions();
				Console.Write("insert option:  ");
				option = Atoi(Console.ReadLine());
				switch (option)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("You chose Addition (+)");
						AuxCalculate(option);
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("You chose Subtraction (-)");
						AuxCalculate(option);
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("You chose Multiplication (x)");
						AuxCalculate(option);
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("You chose Division (/)");
						AuxCalculate(option);
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Program Finished");
						break;
					default:
						Console.Clear();
						Console.WriteLine("Invalid Option");
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
