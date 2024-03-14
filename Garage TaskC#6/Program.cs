//Task 1.Array-dəki fərqli elementləri çap et


//int[] arr = { 4, 5, 8, 10, 12, 4, 8, 11, 24, 12 };
//int[] arr2;
//int num;
//int count=0;
//foreach (var item in arr)
//{
//    num = item;
//    foreach (var item1 in arr)
//    {
//        if (num != item1)
//        {
//            count++;
//            if (count == 1)
//            {
//                Console.WriteLine(num);
//            }
//        }

//    }
//    count=0;
//}



//Task 2.Bir array-in elementlərini digər bir array-ə kopyala

//int[] arr = { 4, 5, 8, 10, 12, 4, 8, 11, 24, 12 };
//int[] arr2 = { };
//foreach (var item in arr)
//{
//   arr2=arr2.Append(item).ToArray();
//}
//foreach (var items in arr2)
//{
//    Console.WriteLine(items);
//}



//Task 3.Array-dəki hər elementin sayını tap.

//int[] arr = { 4, 5, 12, 4 ,11, 24, 12 };
//int[] arr2 = { };
//int count = 0;
//int counter = 0;


//for (int i = 0; i < arr.Length; i++)
//{
//    count = 0;
//    counter = 0;
//    for (int j = 0; j < arr.Length; j++)
//    {

//        if (arr[i] == arr[j])
//        {
//            count++;
//        }

//    }
//    arr2 = arr2.Append(arr[i]).ToArray();
//    for (int k = 0; k < arr2.Length; k++)
//    {
//        if (arr[i] == arr2[k])
//        {
//            counter++;
//        }
//    }
//    if (counter == 1)
//    {
//        Console.WriteLine(arr2[i] + "-" + count);
//    }
//}




