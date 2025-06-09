//Binary Search
//int[] nums = [-1, 0, 3, 5, 9, 12];
//int target = -1;
//int left = 0;
//int right = nums.Length - 1;

//while (right>=left)
//{
//    int mid = (left + right) / 2;

//    if (nums[mid] == target)
//    {
//        Console.WriteLine($"Topildi: nums({mid})={nums[mid]} , Index: {mid}");
//        break;
//    }

//    else if (nums[mid] < target)
//    {
//        left = mid + 1;
//    }
//    else
//    {
//        right = mid - 1;
//    }
//}
//Console.WriteLine("Topilmadi!!!");

//Bubble Sort

int[] arr = { 5, 1, 4, 2, 8 };

for(int y = 0; y < arr.Length; y++)
{
    for(int x = 0; x < arr.Length-1-y; x++)
    {
        int temp = arr[x];
        if(arr[x] >= arr[x+1])
        {
            arr[x] = arr[x+1];
            arr[x+1] = temp;
        }
    }
}

foreach(int x in arr)
{
    Console.WriteLine(x);
}