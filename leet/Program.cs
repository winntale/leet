using static System.Console;


static int Factorial(int num)
{
    if (num <= 1)
    {
        return num;
    }
    else
    {
        checked
        {
            num *= Factorial(num - 1);
        }

        return num;
    }
}

WriteLine(Factorial(5));

static void RunFactorial(int maxNum)
{
    checked
    {
        int resultFactorial = 1;
        for (int i = 0; i <= maxNum; ++i)
        {
            resultFactorial = Factorial(i);
            WriteLine($"{i}! = {resultFactorial:N0}");
        }

        resultFactorial++;
        WriteLine(resultFactorial);
    }
}

RunFactorial(15);