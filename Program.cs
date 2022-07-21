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
// int caseCount = Convert.ToInt32(Console.ReadLine().Trim());
// for (int i = 0; i < caseCount; i++)
// {
//     string s = Console.ReadLine();
//     SplitToChunks(s);
// }

// static void SplitToChunks(string s)
// {
//     string oddString = "";
//     string evenString = "";

//     for (int i = 0; i < s.Length; i++)
//     {
//         if( i % 2 == 0)
//           evenString += s[i];
//         else
//           oddString += s[i];
//     }

//     Console.WriteLine($"{evenString} {oddString}");
// }

// Day 7: Arrays
// int n = Convert.ToInt32(Console.ReadLine().Trim());
// List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
// arr.Reverse();
// arr.ForEach(x => Console.Write(x + " "));

// Day 8: Dictionaries and Maps
// Dictionary <string, string> phonebook = new Dictionary <string, string> ();
// int n = Convert.ToInt32(Console.ReadLine().Trim());
// for (int i = 0; i < n; i++)
// {
//     string[] split = Console.ReadLine().Split(' ');

//     phonebook.Add(split[0], split[1]);
// }

// string name = "";
// while(!String.IsNullOrEmpty(name = Console.ReadLine())) {
//     if(phonebook.ContainsKey(name))
//         Console.WriteLine(name + "=" + phonebook[name]);
//     else
//         Console.WriteLine("Not found");
// }
// Console.ReadKey();

// Day 9: Recursion 3
// static int factorial(int n)
// {
//     if(n <= 1)
//         return 1;
//     else
//         return n * factorial(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine().Trim());
// int result = factorial(n);
// Console.WriteLine(result);

// Day 10: Binary Numbers
// int n = Convert.ToInt32(Console.ReadLine().Trim());
// string s = "";
// while(n > 0)
// {
//     s = n % 2 + s;
//     n = n /2;
// }
// int consecutiveCount = 0;
// int tempConsecutiveCount = 0;
// for (int i = 0; i < s.Length; i++)
// {
//     if(s[i] == '1')
//     {
//         tempConsecutiveCount++;
//         // More professional option.
//         // consecutiveCount = Math.Max(consecutiveCount, tempConsecutiveCount);
//         if(consecutiveCount < tempConsecutiveCount)
//             consecutiveCount = tempConsecutiveCount;
//     }
//     else
//     {
//         tempConsecutiveCount = 0;
//     }
// }
// Console.WriteLine(consecutiveCount);

// Day 11: 2D Arrays
// List<List<int>> arr = new List<List<int>>()
// {
//     new List<int> { 0, -4, -6, 0, -7, -6 },
//     new List<int> { -1, -2, -6, -8, -3, -1 },
//     new List<int> { -8, -4, -2, -8, -8, -6 },
//     new List<int> { -3, -1, -2, -5, -7, -4, },
//     new List<int> { -3, -5, -3, -6, -6, -6 },
//     new List<int> { -3, -6, 0, -8, -6, -7 }
// };

// int hourglass = int.MinValue;
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         var temp =  arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
//                     arr[i + 1][j + 1] +
//                     arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j+ 2];
//         // Console.WriteLine($"{arr[i][j]}, {arr[i][j + 1]}, {arr[i][j + 2]} \n {arr[i + 1][j + 1]} \n {arr[i + 2][j]}, {arr[i + 2][j + 1]}, {arr[i + 2][j + 2]} \t = {test} \n");
//         hourglass = Math.Max(hourglass, temp);
//     }
// }
// Console.WriteLine(hourglass);

// Day 12: Inheritance
// class Person{
// 	protected string firstName;
// 	protected string lastName;
// 	protected int id;
	
// 	public Person(){}
// 	public Person(string firstName, string lastName, int identification){
// 			this.firstName = firstName;
// 			this.lastName = lastName;
// 			this.id = identification;
// 	}
// 	public void printPerson(){
// 		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
// 	}
// }
// class Student : Person{
//     private int[] testScores;  
  
//     /*	
//     *   Class Constructor
//     *   
//     *   Parameters: 
//     *   firstName - A string denoting the Person's first name.
//     *   lastName - A string denoting the Person's last name.
//     *   id - An integer denoting the Person's ID number.
//     *   scores - An array of integers denoting the Person's test scores.
//     */
//     // Write your constructor here
//     public Student(string firstName, string lastName, int identification, int[] testScores)
//     {
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.id = identification;
//         this.testScores = testScores;
//     }
    
//     /*	
//     *   Method Name: Calculate
//     *   Return: A character denoting the grade.
//     */
//     public char Calculate()
//     {
//         var score = this.testScores.Sum() / this.testScores.Count();
//         if(score >= 90 && score <= 100)
//             return 'O';
//         else if(score >= 80 && score < 90)
//             return 'E';
//         else if(score >= 70 && score < 80)
//             return 'A';
//         else if(score >= 55 && score < 70)
//             return 'P';
//         else if(score >= 40 && score < 55)
//             return 'D';
//         else
//             return 'T';
//     }
// }

// string[] inputs = Console.ReadLine().Split();
// string firstName = inputs[0];
// string lastName = inputs[1];
// int id = Convert.ToInt32(inputs[2]);
// int numScores = Convert.ToInt32(Console.ReadLine());
// inputs = Console.ReadLine().Split();
// int[] scores = new int[numScores];
// for(int i = 0; i < numScores; i++){
//     scores[i]= Convert.ToInt32(inputs[i]);
// } 

// Student s = new Student(firstName, lastName, id, scores);
// s.printPerson();
// Console.WriteLine("Grade: " + s.Calculate() + "\n");

// Day 13: Abstract Classes
// abstract class Book
// {
    
//     protected String title;
//     protected  String author;
    
//     public Book(String t,String a){
//         title=t;
//         author=a;
//     }
//     public abstract void display();


// }

// //Write MyBook class
// class MyBook : Book
// {
//     private int price = 0;
    
//     public MyBook(string title, string author, int price) : base(title, author)
//     {
//         this.price = price;
//     }
    
//     public override void display()
//     {
//         Console.WriteLine("Title: " + this.title);
//         Console.WriteLine("Author: " + this.author);
//         Console.WriteLine("Price: " + this.price);
//     }
// }

// Day 14: Scope
// Difference d = new Difference(new int[] { 8, 19, 3, 2, 7 });
// d.computeDifference();
// Console.Write(d.maximumDifference);

// class Difference {
//     private int[] elements;
//     public int maximumDifference;

// 	// Add your code here
//     public Difference(int[] elements)
//     {
//         this.elements = elements;
//     }
    
//     public void computeDifference()
//     {
//         while(elements.Count() > 1)
//         {
//             for(int i = 0; i < elements.Length; i++)
//             {
//                 maximumDifference = Math.Max(Math.Abs(elements.FirstOrDefault() - elements[i]), maximumDifference);                
//             }
//             elements = elements.Where(x => x != elements.FirstOrDefault()).ToArray();
//         }
//     }
// }

// Day 15: Linked List
// static  Node insert(Node head,int data)
// {
//     if(head == null)
//     {
//         return new Node(data);
//     }
//     var currentNode = head;
//     while(currentNode.next != null)
//     {
//         currentNode = currentNode.next;
//     }
//     currentNode.next = new Node(data);
//     return head;
// }
// class Node
// {
// 	public int data;
// 	public Node next;
//     public Node(int d){
//         data=d;
//         next=null;
//     }		
// }

// Day 16: Exceptions - String to Integer
// try
// {
//     string S = Console.ReadLine();
//     Console.WriteLine(Convert.ToInt32(S));
// }
// catch(System.Exception ex)
// {
//     Console.WriteLine("Bad String");
// }

// Day 17: More Exceptions
// public class Calculator
// {
//     public int power(int n, int p)
//     {
//         if(n < 0 || p < 0)
//             throw new Exception("n and p should be non-negative");
//         else
//             return Convert.ToInt32(Math.Pow(n, p));
//     }
// }

// Day 18: Queues and Stacks
// Stack<char> stack = new Stack<char>();
// Queue<char> queue = new Queue<char>();

// void pushCharacter(char ch)
// {
//     stack.Push(ch);
// }

// void enqueueCharacter(char ch)
// {
//     queue.Enqueue(ch);
// }

// char popCharacter()
// {
//     return stack.Pop();
// }

// char dequeueCharacter()
// {
//     return queue.Dequeue();
// }

// Day 19: Interfaces
// public class Calculator : AdvancedArithmetic
// {
//     public int divisorSum(int n)
//     {
//         int temp = 0;
//         for(int i = 1; i <= n; i++)
//         {
//             temp += n % i == 0 ? i : 0;
//         }
//         return temp;
//     }
// }

// Day 20: Sorting



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

