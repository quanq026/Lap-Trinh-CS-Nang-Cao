//bai 1

using System;
using System.Collections.Generic;

Console.WriteLine("Hello World!");
int a;
int b;
int c;
Console.Write("nhap a: ");
a = Convert.ToInt32(Console.ReadLine());
while (true)
{
  Console.Write("nhap b: ");
  try
  {
    b = Convert.ToInt32(Console.ReadLine());
    break;
  }
  catch (Exception)
  {
    Console.WriteLine("nhap sai, nhap lai");
  }
}
while (true)
{
  Console.Write("nhap c: ");
  bool k = int.TryParse(Console.ReadLine(), out c);
  if (k)

    break;
  else
    Console.WriteLine("nhap sai, nhap lai");
}



Console.WriteLine($"a+b+c={a + b + c}");
