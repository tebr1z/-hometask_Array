// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region task1
//int[] numbers = { 34,55 };

//int sum = 0;    

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
// Console.WriteLine(sum);
#endregion

#region task2

int[] numbers = { 1, 2, 3, 4, 5, 6 };

int cem = numbers[0] + numbers[numbers.Length-1];
Console.WriteLine(cem);


#endregion



int[] arr = { 22, 55, 44, 66, 88, 47, 5 };
int boyuqarr = arr[0];

for (int i = 1; i<arr.Length; i++)
{
    if (arr[i]>boyuqarr)
    {
        boyuqarr = arr[i];
    }
}
Console.WriteLine(boyuqarr);
