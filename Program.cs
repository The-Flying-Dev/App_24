namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        double interestRate,
            amount,
            years,
            annualCompound;

        Console.Write("Enter the initial amount: ");
        amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Interest Rate: ");
        interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter the number of years: ");
        years = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nimber of times the Interest will be Compounded: ");
        annualCompound = Convert.ToDouble(Console.ReadLine());

        for (int t = 1; t < years + 1; t++)
        {
            total = amount * Math.Pow((1 + interestRate / annualCompound), (annualCompound * t));

            Console.Write("Your total for year {0} " + "is {1}. \n", t, Math.Round(total, 2));
        }

        Console.ReadLine();
    }
}
