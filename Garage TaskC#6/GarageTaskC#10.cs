
#region Task1

//int n = 9;
//int count = 10;
//int result = 0;
//for (int i = 1; i <= count; i++)
//{
//    if (2 <= n && n <= 20)
//    {
//        result = n * i;
//        Console.WriteLine(n + "x" + i + "=" + result);
//    }
//}
#endregion

#region Task2


//int[] arr = { 5, 4, 8, 7, 6, 10, 15, 41, 28 , 37,48,52,78 };
//int count = 0;

//int[] arr1 = new int[arr.Length % 3 >= 1 ? arr.Length / 3 + 1:arr.Length/3];
//int[] arr2 = new int[arr.Length % 3 >= 2 ? arr.Length / 3 + 1: arr.Length/3];
//int[] arr3 = new int[arr.Length/3];
//  for (int i = 0; i < arr.Length; i++)
//    {
//        arr1[count] = arr[i];
//        i++;
//    if (i < arr.Length)
//      {
//        arr2[count] = arr[i];
//        i++;
//      }
//    if(i < arr.Length)
//    {
//        arr3[count] = arr[i];
//    }
//           count++;
//    }

//foreach (var item1 in arr1)
//{
//    Console.Write(item1 + ", ");
//}
//  Console.Write("\n-------------------------------\n");
//foreach (var item2 in arr2)
//{
//    Console.Write(item2 + ", ");
//}
//Console.Write("\n-------------------------------\n");

//foreach (var item3 in arr3)
//{
//    Console.Write(item3 + ", ");
//}
//Console.Write("\n-------------------------------");





#endregion


#region Task3
//string[] names = { "Vahid", "Nicat", "Murguz", "Gözəl", "Ulduz", "Famil", "Dadaş", "Vagif", "Ümid", "Durna","Murtuz" };
//string[] newName = new string[names.Length];
//int count = 0;
//int counter = 0;
//for (int i = 0; i < names.Length; i++)
//{
//        counter = 0;
//    foreach (var item in names[i])
//    {
//        if (item == 'u')
//        {
//            counter++;
//          if(counter == 1)
//          {
//              newName[count++] = names[i];
//           }
//        }

//    }
   

//}
//for (int i = 0; i < newName.Length; i++)
//{
//    if (newName[i] != null)
//    {
//        char[] arr = new char[newName[i].Length];
//        for (int j = 0; j < newName[i].Length; j++)
//        {
//            arr[j] = newName[i][j];
//            if (arr[j] == 'u' || arr[j] == 'U')
//            {
//                arr[j] = 'e';
//            }
//        }
//        newName[i] = new string(arr);
//    }

//}

//foreach (var item in newName)
//{
//    Console.WriteLine(item);    
//}
#endregion

