// Задача 19

/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21*/

Console.Clear();

Console.WriteLine("Введите целое число");
int ourNumberInt = int.Parse(Console.ReadLine()!);

if (ourNumberInt.ToString().Length != 5)
{
    Console.WriteLine("this is not a five digit number");
    return;
}
else
{

    if ( ourNumberInt/10000 == ourNumberInt%10 && ourNumberInt/1000%10 == ourNumberInt%100/10)
    {
        Console.WriteLine("Yes, it's a polindrom");
    }
    else
    {
         Console.WriteLine("No, it's not a polindrom");

    }

}


//проверяем на ввод строк, неверных чисел, и отрицательных - создадим метод (для тренировки новыз навыков) -
// метод не работает, простите, что здесь в комментариях оставила, боюсь потерять. пожалуйста, дальше не читайте. Потом попробую починить!

/*void testIncomDataForError( string a, int checkedNumber)
{

bool testIncomeForError = int.TryParse(a, out checkedNumber);

if (testIncomeForError)
{
    Console.WriteLine("It's a number");
   checkedNumber = int.Parse(a);
}
else
{
    Console.WriteLine("Input error");
    return;

}

if ( checkedNumber <0)
{
     checkedNumber = - checkedNumber;
}
}

//start the programm
Console.WriteLine("Введите целое пятизначное число");
var ourNumber = Console.ReadLine();

int ourNumberInt = 0;
testIncomDataForError(ourNumber, ourNumberInt);
Console.WriteLine($"your number is {ourNumberInt}");
Console.WriteLine(ourNumberInt.ToString().Length );
if (ourNumberInt.ToString().Length != 5)
{
    Console.WriteLine("this is not a five digit number");
    return;
}
else
{

    if ( ourNumberInt/10000 == ourNumberInt%10 && ourNumberInt/1000%10 == ourNumberInt%100/10)
    {
        Console.WriteLine("Yes, it's a polindrom");
    }
    else
    {
         Console.WriteLine("No, it's not a polindrom");

    }

}*/


