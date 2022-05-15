﻿// ************ 30 Days Challenge ************
// Day 1: Data Types
// int first = Convert.ToInt16(Console.ReadLine());
// double second = Convert.ToDouble(Console.ReadLine());
// string third = Console.ReadLine();
// first = first + (int) Math.Round(second);
// second = second + second;
// third = "HackerRank " + third;
// Console.WriteLine("\n" + first);
// Console.WriteLine(string.Format("{0:0.0}", second));
// Console.WriteLine(third);

// Day 2: Operators
// static void solve(double meal_cost, int tip_percent, int tax_percent)
// {
//     double tip = (meal_cost / 100) * tip_percent;
//     double tax = (meal_cost / 100) * tax_percent;
//     Console.Write(Math.Round(meal_cost + tip + tax));
// }
// solve(12, 20, 8);

// Day 3: Intro to Conditional Statements
// int N = Convert.ToInt32(Console.ReadLine().Trim());
// if(N % 2 == 0 && (N >= 2 && N <= 5) || (N % 2 == 0 && N > 20))
// {
//     Console.WriteLine("Not Weird");
// }
// else
// {
//     Console.WriteLine("Weird");
// }

// Day 4: Class vs. Instance
// class Person {
//     public int age;     
// 	public Person(int initialAge) {
//         if(initialAge < 0)
//             Console.WriteLine("Age is not valid, setting age to 0.");
//         this.age = (initialAge < 0 ? 0 : initialAge);
//     }
//     public void amIOld() {
//         if(age < 13)
//             Console.WriteLine("You are young.");
//         else if(age >= 13 && age < 18)
//             Console.WriteLine("You are a teenager.");
//         else
//             Console.WriteLine("You are old.");
//     }

//     public void yearPasses() {
//         age++;
//     }
// }

// Day 5: Loops
// int n = Convert.ToInt32(Console.ReadLine().Trim());
// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(n + " x " + i + " = " + n * i);
// }

// Day 6: Let's Review
int num = 2;
string s1 = "Hacker";
string s2 = "Rank";
char[] carr1 = s1.ToCharArray();
char[] carr2 = s2.ToCharArray();
char[] oddArr;
char[] evenArr;
for (int i = 0; i < carr1.Count(); i++)
{
    if(i % 2 == 0)
        oddArr[i] = carr1[i];
    else
        evenArr[i] = carr1[i];
        
}
// fs1 = fs1 + " ";
// for (int i = 1; i < carr1.Count(); i += 2)
// {
//     fs1 += carr1[i];
// }

Console.ReadKey();

// ************ 1 Week Preparation Kit ************
// Day 1 - Plus Minus
// using System.Linq;
// static void plusMinus(List<int> arr)
// {
//     Console.WriteLine(string.Format("{0:0.000000}", (double) arr.Where(x => x > 0).Count() / arr.Count()));
//     Console.WriteLine(string.Format("{0:0.000000}", (double) arr.Where(x => x < 0).Count() / arr.Count()));
//     Console.WriteLine(string.Format("{0:0.000000}", (double) arr.Where(x => x == 0).Count() / arr.Count()));
// }
// List<int> arr = new List<int> { 1, 2, 3, -1, -2, -3, 0, 0 };
// plusMinus(arr);

// Day 1 - Mini-Max Sum
// using System.Linq;
// static void miniMaxSum(List<int> arr)
// {
//     uint sum = 0;    
//     arr.ForEach(x => sum += (uint) x);
//     List<long> res = new List<long> { sum - arr.OrderBy(x => x).Last(), sum - arr.OrderBy(x => x).First() };
//     res.ForEach(x => Console.Write("{0} ", x));
// }
// List<int> arr = new List<int> { 539674108, 549382170, 270968351, 746219035, 140597628 };
// miniMaxSum(arr);

// Day 1 - Time Conversion
// static string timeConversion(string s)
// {
//     List<string> stringList = s.Split(':').ToList();
//     int hour = stringList[2].Contains("PM") && Convert.ToInt16(stringList[0]) + 12 != 24 ? (Convert.ToInt16(stringList[0]) == 12 ? 0 : Convert.ToInt16(stringList[0]) + 12) : (Convert.ToInt16(stringList[0]) == 12 ? 0 : Convert.ToInt16(stringList[0]) );
//     if(stringList[2].Contains("PM") && Convert.ToInt16(stringList[0]) == 12) // !* This controll will be add up later
//     {
//         hour = 12;
//     }
//     int minute = Convert.ToInt16(stringList[1]);
//     int seconds = Convert.ToInt16(stringList[2].Remove(stringList[2].Length - 2));
//     return hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + seconds.ToString("D2");
// }
// Console.WriteLine(timeConversion("12:45:54PM"));

// Day 1 - Mock Test - Find Median
// using System.Linq;
// static int findMedian(List<int> arr)
// {
//     return arr.OrderBy(x => x).Skip((arr.Count() - 1) / 2).First();
// }
// Console.WriteLine(findMedian(new List<int> { 0, 1, 2, 3, 4, 5, 6 }));