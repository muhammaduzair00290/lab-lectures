// See https://aka.ms/new-console-template for more information
// program no 1 : array sorting without using array.sort().
//int[] arr = { 2, 3, 9, 6, 8, 7 };
//for (int i = 0; i < arr.Length-1; i++)
//{
//    for (int j = 0; j < arr.Length-i-1; j++)
//    {
//        if (arr[j] > arr[j+1])
//        {
//            int temp = arr[j+1];
//            arr[j+1] = arr[j];
//            arr[j] = temp;
//        }
//    }
//}

//Console.WriteLine("Sorted array:");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}


// program no 2 to find the index of an element in array :

//int[] arr1 = { 2, 3, 9, 6, 8, 7, 8 };
//int search = 8;


//int index = Array.IndexOf(arr1, search);
//if (index != 0)
//{
//    Console.WriteLine($" found number  {search} at index  {index} ");

//}
//else
//{
//    Console.WriteLine(" NOT FOUND ");

//}
int[] arr1 = { 2, 3, 9, 6, 8, 7, 8 };
Console.WriteLine(" enter the no to find ");
int find = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr1.Length; i++)
{
    if (find == arr1[i])
    { Console.WriteLine($" found at index {i}"); }
}

