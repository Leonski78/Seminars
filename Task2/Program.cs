// Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив[6, 7, 19, 345, 3]->нет

// 3; массив[6, 7, 19, 345, 3]->да*/

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}