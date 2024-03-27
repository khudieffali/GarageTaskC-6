using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_TaskC_6
{
    internal class GarageTaskC_12
    {
        static void Main(string[] args)
        {
            #region Task1
            //GetReverse();
            #endregion
            #region Task 2
            //head:
            //Console.WriteLine("Reqem daxil edin");
            //string input = Console.ReadLine();
            //bool num = int.TryParse(input, out int number);
            //if (num == false)
            //{
            //    goto head;
            //}
            //SimpleNumber(getFibonacci(number));
            #endregion
        }

        #region Task1
        //static void GetReverse()
        //{
        //head:
        //    Console.WriteLine("Eded daxil edin");
        //    bool input = int.TryParse(Console.ReadLine(), out int result);
        //    int endNum;

        //    int reverseInt = 0;
        //    if (input == false)
        //    {
        //        goto head;
        //    }

        //    while (result > 0)
        //    {
        //        endNum = result % 10;
        //        result /= 10;
        //        reverseInt = reverseInt * 10 + endNum;
        //    }
        //    Console.WriteLine(reverseInt);
        //}

        //}
        #endregion
        #region Task 2
        //static int getFibonacci(int number)
        //{
        //    int[] arr = new int[number];
        //    int count = 0;
        //    int sum = 0;
        //    if (number > 0)
        //    {
        //        arr[0] = count;
        //        arr[1] = count + 1;
        //        sum = arr[1];
        //        for (int i = 2; i < number; i++)
        //        {
        //            if ((arr[i - 2] + arr[i - 1]) > 100)
        //            {
        //                break;
        //            }
        //            arr[i] = arr[i - 2] + arr[i - 1];

        //            sum += arr[i];
        //        }
        //    }
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("reqemlerin cemi : " + sum);
        //    return sum;
        //}

        //static void SimpleNumber(int sum)
        //{
        //    int counter = 0;
        //    for (int i = 2; i <= sum; i++)
        //    {
        //        if (sum % i == 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    if (counter == 1)
        //    {
        //        Console.WriteLine("Sade ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Murekkeb ededdir");
        //    }
        //}
        #endregion


    }
}
