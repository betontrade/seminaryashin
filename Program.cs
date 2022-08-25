
//________________Домашнее задание Яшин Евгений__________


//______________________________Задача 10________________________
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int VtoroeChislo (int trehzn)
{
    int oststo = trehzn % 100;
    int ostdec = oststo/10;
    return ostdec;
}

Console.WriteLine("Начало работы программы, которая показывает вторую цифру трехзначного числа");
Console.WriteLine(" ");
Console.Write("Пожалуйста введите трехзначное число: ");

int trizn = Convert.ToInt32( Console.ReadLine());

int resull = (VtoroeChislo(trizn));

Console.WriteLine(" ");

Console.WriteLine($"Вторая цифра трехзначного числа {trizn}, равна: {resull}");


*/



//______________________________Задача 13________________________
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int delitter (int cifra)
{ 
    int dell = 1;

    while (dell <= (cifra/100))
        {
            dell = dell *10;
        }

    int bezlevyh = cifra % dell; // убрали цифры слева от третьего числа

    while (bezlevyh >10)  // убираем все цифры справа, после первого числа (циклом, деля на 10)
        {
         bezlevyh = bezlevyh / 10 ;
        }
    return bezlevyh;
}


Console.WriteLine("Введите число: ");

int cifra =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

int itog = delitter(cifra);

if (cifra  >= 100)
{
    Console.WriteLine($"Третья цифра числа {cifra} равна: {itog}");
}
else
{
    Console.WriteLine($"Третьей цифры в  числе {cifra} нет");
}
Console.WriteLine(" ");

Console.WriteLine("Программа завершена");


*/


//______________________________Задача 15________________________
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

/*

bool DenNedely (int number)
{
    if (number <= 5 & number >=1) 
    return false;
    if (number == 6)
    return true;
    if (number == 7)
    return true;
    else
    return false;

}

Console.WriteLine("Начало работы программы");
Console.WriteLine(" ");
Console.Write("Пожалуйста введите день недели, и мы проверим выходной это или нет: ");
int numberday = Convert.ToInt32( Console.ReadLine());

bool otvet = DenNedely(numberday);

if (otvet)
{
Console.WriteLine($"{numberday} -> Да");
}
else
{
    Console.WriteLine($"{numberday} -> Нет");
}

*/

// ________________________Конец домашнего задания_______________________________