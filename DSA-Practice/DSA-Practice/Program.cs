// See https://aka.ms/new-console-template for more information


using DSA_Practice.LeetCodeOwn.DailPractice.Hard;
using DSA_Practice.String;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        // 1. Reverse the string
        string str = "This string is going to be reversed";

        var reversedString = new ReverseString();
        reversedString.reverse(str);

        // 2. Find sub Arr K distinct count
        int[] nums = { 1, 2, 1, 2, 3 };
        int k = 2;

        SubArrKDistinct sub = new SubArrKDistinct();
        int result = sub.SubarraysWithKDistinct(nums, k);
        Console.WriteLine("Result: " + result);
    }
}



