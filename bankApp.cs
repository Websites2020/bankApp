using System;

public class Checkbook
{
	public static void Main()
	{
		double beginingBal = 1000.00;
		double deposit = Method1();
		double withdrawl = Method2();
		Method3(beginingBal, deposit, withdrawl);
	}

	public static double Method1()
	{
		string stringDeposit;
		double deposit;

		Console.Out.Write("Enter amount you are depositing. ");
		stringDeposit = Console.ReadLine();
		deposit = Convert.ToDouble(stringDeposit);

		return deposit;
	}

	public static double Method2()
	{
		string stringWithdrawl;
		double withdrawl;

		Console.Out.Write("Enter amount you are withdrawing. ");
		stringWithdrawl = Console.ReadLine();
		withdrawl = Convert.ToDouble(stringWithdrawl);

		return withdrawl;
	}

	public static void Method3(double a, double b, double c)
	{
		double endingBalance;

		Console.WriteLine("Your begining balance is {0}", a);
		Console.WriteLine("You deposited {0}", b);
		Console.WriteLine("You withdrew {0}", c);

		endingBalance = a + b - c;

		Console.WriteLine("Your ending balance is {0}", endingBalance);

		return;
	}
}