using System;
class Program
{  /* 17.	* Четни / нечетни позиции*/
   //Напишете програма, която чете n числа и пресмята сумата, минимума и максимума на числата на четни и нечетни позиции(броим от 1). Когато няма минимален / максимален елемент, отпечатайте “No”. Примери:
   //вход 
   //6
   //2
   //3
   //5
   //4
   //2
   //1
   //OddSum=9, OddMin=2, OddMax=5, EvenSum=8, EvenMin=1, EvenMax=4		
   //2
   //1.5
   //-2.5	
   /* OddSum=1.5, OddMin=1.5, OddMax=1.5, EvenSum=-2.5, EvenMin=-2.5, EvenMax=-2.5*/
   //1
   //1	
   //OddSum=1, OddMin=1, OddMax=1, EvenSum=0, EvenMin=No, EvenMax=No	
   //0	
   //OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No
   //5
   //3
   //-2
   //8
   //11
   //-3	
   /*OddSum=8, OddMin=-3, OddMax=8, EvenSum=9, EvenMin=-2, EvenMax=11*/
   //4
   //1.5
   //1.75
   //1.5
   //1.75	
    //OddSum=3, OddMin=1.5, OddMax=1.5, EvenSum=3.5, EvenMin=1.75, EvenMax=1.75	
    //1
    //-5
    //OddSum=-5, OddMin=-5, OddMax=-5, EvenSum=0, EvenMin=No, EvenMax=No		
    //3
    //-1
    //-2
    //-3	
    //OddSum=-4, OddMin=-3, OddMax=-1, EvenSum=-2, EvenMin=-2, EvenMax=-2

    //Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/154#10.
    //Подсказки:
    //•	Задача обединява няколко предходни задачи: намиране на минимум, намиране на максимум, намиране на сума и обработка на елементите от четни и нечетни позиции.Припомнете си ги.
    //•	Работете с дробни числа (не цели). Сумата, минимумът и максимумът също са дробни числа.
    //•	Използвайте неутрална начална стойност при намиране на минимум / максимум, например 1000000000.0 и -1000000000.0. Ако получите накрая неутралната стойност, печатайте “No”.

    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        double EvenSum = 0.0; double OddSum = 0.0;
        double EvenMin = Double.MaxValue; double OddMin = Double.MaxValue;
        double EvenMax = Double.MinValue; double OddMax = Double.MinValue;

        for (double i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                EvenSum += num;

                if (num > EvenMax) { EvenMax = num; }
                if (num < EvenMin) { EvenMin = num; }
            }
            else
            {
                OddSum += num;

                if (num > OddMax) { OddMax = num; }
                if (num < OddMin) { OddMin = num; }
            }
        }
        if (n == 0)
        {
            Console.WriteLine("OddSum=0,\nOddMin=No,\nOddMax=No\nEvenSum=0,\nEvenMin=No,\nEvenMax=No");
        }
        if (n == 1)
        {
            Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2}\nEvenSum=0,\nEvenMin=no,\nEvenMax=no"
                , OddSum, OddMin, OddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2}", OddSum, OddMin, OddMax);
            Console.WriteLine("EvenSum={0},\nEvenMin={1},\nEvenMax={2},", EvenSum, EvenMin, EvenMax);
        }

    }
}