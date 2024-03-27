using Garage_TaskC_6;
using System.Security.Cryptography;
static void Main(string[] args)

{
    //Human human1 = new("Hikmet", "Aliyev", 20, "Baku");
    //Human human2 = new("Ali", "Aliyev", 28, "Celilabad");
    //Human human3 = new("Server", "Aliyev", 23, "Baku");
    //Human human4 = new("Aziz", "Aliyev", 32, "Celilabad");
    //Human human5 = new("Aziz", "Aliyev", 32, "Xizi");
    //Human human6 = new("Aziz", "Aliyev", 32, "Gence");

    //Human human = new();
    //Human[] arr = new Human[] { human1, human2, human3, human4, human5, human6 };

    //Console.WriteLine(human1.Name + " " + human1.isStudent(human1.Age));
    //Console.WriteLine(human2.Name + " " + human2.isStudent(human2.Age));
    //Console.WriteLine(human3.Name + " " + human3.isStudent(human3.Age));
    //Console.WriteLine(human4.Name + " " + human4.isStudent(human4.Age));
    //version 1
    //human1.CheckCity(human1.City, human3.City);
    //human1.CheckCity(human2.City, human4.City);

    //version 2 with array
    //human1.CheckCity(arr);

    //GetCount Method
    //human1.GetCount(arr);

    //GetCounter Method
    //human.GetCounter(arr);







}



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








