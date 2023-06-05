       //Задача 25
// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.WriteLine("Введит число");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введит число");
//int b = Convert.ToInt32(Console.ReadLine());

//    while((a>0) && (b>0))
//    {
//        Console.WriteLine(Math.Pow(a,b));
//        break;
//    }


//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] array=new int[8];
int x=0;

for(int i =0;i<array.Length;i++)
{
    array[i]=new Random().Next(0,100);
    Console.Write(array[i]+" ");    
}
