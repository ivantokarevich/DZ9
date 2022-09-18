// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

/* int NumbersToMN(int number1, int number2)
{
	if (number1 > number2) return number2;
	else
	{
		Console.Write(number1 + " ");
		number1++;
	}
	return NumbersToMN(number1, number2);
}

Console.WriteLine("Введите N: ");
int numFinish = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int numStart = Convert.ToInt32(Console.ReadLine());


NumbersToMN(numStart, numFinish); */



// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int InputNum(string a)
{
	Console.WriteLine(a);
	return Convert.ToInt32(Console.ReadLine());
}

int SummNaturalNumbers(int start, int finish)
{
	if (start == finish) return finish;
	int summ = start;
	start++;
	return summ + SummNaturalNumbers(start, finish);
}


int numStart = InputNum("Введите M: ");
int numFinish = InputNum("Введите N: ");
Console.WriteLine(SummNaturalNumbers(numStart, numFinish)); */




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


int InputNum(string a)
{
	Console.WriteLine(a);
	return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int n, int m)
{
	if (n == 0) return m + 1;
	else if ((n != 0) && (m == 0)) return Ackerman(n - 1, 1);
	else return Ackerman(n - 1, Ackerman(n, m - 1));
}

int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
Console.WriteLine(Ackerman(n, m));