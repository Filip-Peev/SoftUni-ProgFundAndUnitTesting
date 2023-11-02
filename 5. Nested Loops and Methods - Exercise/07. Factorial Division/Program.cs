int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

static int CalculateFactorial(int num)
{
	int factorial = 1;
	for (int i = 1; i <= num; i++)
	{
		factorial *= i;
	}
	return factorial;
}

int num1 = CalculateFactorial(firstNumber);
int num2 = CalculateFactorial(secondNumber);

Console.WriteLine(num1/num2);