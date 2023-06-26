Console.Clear();
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(A);
Console.WriteLine($"{A} -> {sumNumbers}");

int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
    }
    return sum; 
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write("Введите целое число A: ");
        if(int.TryParse(Console.ReadLine(), out int userNumber))
        return userNumber;

        Console.WriteLine(errorMessage);
    }
}