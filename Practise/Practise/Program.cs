// See https://aka.ms/new-console-template for more information
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

//(1) Finding two numbers in an array that add up to a target
//(a)
//int [] nums = { 2, 7, 11, 15 };
//int target = 22;
//bool shouldBreak = false;
//for (int startnum = 0; startnum < nums.Length; startnum++)
//{
//    for (int j = startnum + 1; j < nums.Length; j++)
//    {
//        if (nums[startnum] + nums[j] == target)
//        {
//            shouldBreak = true;
//            Console.WriteLine(nums[startnum]);
//            Console.WriteLine(nums[j]);
//            break;
//        }
//    }
//    if (shouldBreak) { break; }
//}

//(b)
//int[] nums = { 2, 7, 15, 11 };
//int target = 18;
//HashSet<int> seen = new HashSet<int>();
//foreach (int num in nums)
//{
//    int needed = target - num;
//    if (seen.Contains(needed))
//    {
//        Console.WriteLine(needed);
//        Console.WriteLine(num);
//        break;
//    }
//    seen.Add(num);
//}

//(2) Reverse word in a string
//string input = "elston";
//char[] chars = input.ToCharArray();
//StringBuilder reversed = new StringBuilder(chars.Length);
//for (int i = chars.Length - 1; i >= 0; i--)
//{
//    reversed.Append(chars[i]);
//}
//Console.WriteLine(reversed.ToString());

//(3) Reverse Array
//int[] nums = { 2, 7, 11, 15 };
//List<int> rev=new List<int>();
//for (int i = nums.Length-1; i >= 0; i--)
//{
//    rev.Add(nums[i]);
//}
//Console.WriteLine("");