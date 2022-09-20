// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5  // 78 -> третьей цифры нет  // 32679 -> 6
Console.Clear();
Console.Write("Enter numbers:");

int num = Convert.ToInt32(Console.ReadLine());

string numInText = Convert.ToString(num);

if (numInText.Length > 2)
{
  Console.WriteLine("Third nubmer:" + numInText[2]);
}
else {
  Console.WriteLine("NO THIRD DIGIT !");
} 
/* 
// Что я узнал:
int a = 12345;                                                                    // присваеваем переменной "а" значение 12345
string Text_a = Convert.ToString(a);                                              // так мы переводим число 12345 в строку! (и кладем в переменную Text_a)
Console.WriteLine($"длина массива(текста) =  {Text_a.Length}");                   // вывел длину массива (строки Text_a)
Console.WriteLine($"первая цифра= {Text_a[0]}  вторая цифра= {Text_a[1]}");       // могу обращаться к любому элементу строчного массива  
  */