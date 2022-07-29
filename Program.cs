// ************ 30 Days Challenge ************
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
// int n = Convert.ToInt32(Console.ReadLine().Trim());
// List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
// int swapCount = 0;
// for(int i = 0; i < n; i++)
// {            
//     for(int j = 0; j < n - 1; j++)
//     {
//         if(a[j] > a[j + 1])
//         {
//             var temp = a[j];
//             a[j] = a[j + 1];
//             a[j + 1] = temp;
//             swapCount++;
//         }
//     }
    
//     if(swapCount == 0)
//         break;
// }
// Console.WriteLine("Array is sorted in {0} swaps.", swapCount);
// Console.WriteLine("First Element: " + a.FirstOrDefault());
// Console.WriteLine("Last Element: " + a.LastOrDefault());

// Day 21: Generics
// public static void PrintArray<T>(T[] data)
// {
//     foreach(var item in data)
//     {
//         Console.WriteLine(item);
//     }
// }

// Day 22: Binary Search Trees
// static int getHeight(Node root){
//     if(root == null)
//         return -1;
//     return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
// }

// Day 23: BST Level-Order Traversal
// Node root = null;
// int T=Int32.Parse(Console.ReadLine());
// while(T-->0){
//     int data=Int32.Parse(Console.ReadLine());
//     root=insert(root,data);            
// }
// levelOrder(root);

// static void levelOrder(Node root){
//     Queue<Node> queue = new Queue<Node>();
//     queue.Enqueue(root);
//     while(queue.Count > 0)
//     {
//         Node currentNode = queue.Dequeue();
//         Console.Write(currentNode.data + " "); 
        
//         if(currentNode.left != null)
//             queue.Enqueue(currentNode.left);
//         if(currentNode.right != null)
//             queue.Enqueue(currentNode.right);
//     }
// }

// static Node insert(Node root, int data){
//     if(root==null){
//         return new Node(data);
//     }
//     else{
//         Node cur;
//         if(data<=root.data){
//             cur=insert(root.left,data);
//             root.left=cur;
//         }
//         else{
//             cur=insert(root.right,data);
//             root.right=cur;
//         }
//         return root;
//     }
// }
// class Node
// {
//     public int data;
//     public Node left;
//     public Node right;
//     public Node(int d)
//     {
//         data = d;
//         left = null;
//         right = null;
//     }
// }

// Day 24: More Linked Lists
// Node head=null;
// int T=Int32.Parse(Console.ReadLine());
// while(T-- > 0){
//     int data=Int32.Parse(Console.ReadLine());
//     head=insert(head,data);
// }
// head=removeDuplicates(head);
// display(head);

// static Node removeDuplicates(Node head){
    // Node current = head;
    // while(current != null && current.next != null)
    // {
    //     if(current.data == current.next.data)
    //     {
    //         current.next = current.next.next;
    //     }
    //     else
    //     {
    //         current = current.next;
    //     }
    // }
    // return head;
// }
// static  Node insert(Node head,int data)
// {
//     Node p=new Node(data);
    
    
//     if(head==null)
//         head=p;
//     else if(head.next==null)
//         head.next=p;
//     else
//     {
//         Node start=head;
//         while(start.next!=null)
//             start=start.next;
//         start.next=p;
        
//     }
//     return head;
// }
// static void display(Node head)
// {
//     Node start=head;
//     while(start!=null)
//     {
//         Console.Write(start.data+" ");
//         start=start.next;
//     }
// }
// class Node
// {
//     public int data;
//     public Node next;
//     public Node(int d)
//     {
//         data = d;
//         next = null;
//     }
// }

// Day 25: Running Time and Complexity
// int n = int.Parse(Console.ReadLine());
// for(int i = 0; i < n; i++)
// {
//     Console.WriteLine(IsPrime(Convert.ToInt32(Console.ReadLine())) ? "Prime" : "Not prime");
// }

// static bool IsPrime(int n)
// {
//     if (n <= 1) return false;
//     if (n == 2) return true;
//     if (n % 2 == 0) return false;
//     for (int i = 3; i <= Math.Sqrt(n); i += 2)
//     {
//         if (n % i == 0)
//             return false;
//     }
//     return true;
// }

// Day 26: Nested Logic
// List<int> ReturnDate = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
// List<int> DueDate = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
// DateTime ReturnDateTime = new DateTime(ReturnDate[2], ReturnDate[1], ReturnDate[0]);
// DateTime DueDateTime = new DateTime(DueDate[2], DueDate[1], DueDate[0]);
// Console.WriteLine(GetExpiryDateFee(ReturnDateTime, DueDateTime));
// static int GetExpiryDateFee(DateTime ReturnDateTime, DateTime DueDateTime)
// {
//     int expiryFee = 0;
//     if (ReturnDateTime <= DueDateTime)
//     {
//         expiryFee = 0;
//     }
//     else if(ReturnDateTime.Month == DueDateTime.Month && ReturnDateTime.Year == DueDateTime.Year)
//     {
//         expiryFee = 15 * (ReturnDateTime.Day - DueDateTime.Day);
//     }
//     else if(ReturnDateTime.Year == DueDateTime.Year)
//     {
//         expiryFee = 500 * (ReturnDateTime.Month - DueDateTime.Month);
//     }
//     else
//     {
//         expiryFee = 10000;
//     }
//     return expiryFee;
// }

// Day 27: Testing (C++)
// class TestDataEmptyArray
// {
//     public:
//         static vector<int> get_array()
//         {
//             vector<int> v;
//             return v;
//         }
// };

// class TestDataUniqueValues
// {
//     public:
//         static vector<int> get_array()
//         {
//             vector<int> v = { 1, 2, 3 };
//             return v;
//         }
        
//         static int get_expected_result()
//         {
//             return 0;
//         }
// };

// class TestDataExactlyTwoDifferentMinimums
// {
//     public:
//         static vector<int> get_array()
//         {
//             vector<int> v = { 1, 1, 2, 3 };
//             return v;
//         }
        
//         static int get_expected_result()
//         {
//             return 0;
//         }
// };

// Day 28: RegEx, Patterns, and Intro to Databases
// using System.Text.RegularExpressions;
// int N = Convert.ToInt32(Console.ReadLine().Trim());
// List<string> UserList = new List<string>();
// for (int NItr = 0; NItr < N; NItr++)
// {
//     string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//     string firstName = firstMultipleInput[0];    
//     string emailID = firstMultipleInput[1];
//     if(IsValidUserName(firstName) && IsValidEmail(emailID))
//     {
//         UserList.Add(firstName);
//     }
// }
// UserList.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
// static bool IsValidUserName(string s)
// {
//     Regex regex = new Regex(@"^(?!^.{21})[a-z]\D*$");
//     return regex.IsMatch(s);
// }

// static bool IsValidEmail(string s)
// {
//     Regex regex = new Regex(@"^(?!^.{51})[a-z.]+@[gmail]+\.[com]+\D*$");
//     return regex.IsMatch(s);
// }

// Day 29: Bitwise AND
// int t = Convert.ToInt32(Console.ReadLine().Trim());
// for (int tItr = 0; tItr < t; tItr++)
// {
//     string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
//     int count = Convert.ToInt32(firstMultipleInput[0]);
//     int lim = Convert.ToInt32(firstMultipleInput[1]);
//     int res = Result.bitwiseAnd(count, lim);
//     Console.WriteLine(res);
// }

// class Result
// {
//     public static int bitwiseAnd(int N, int K)
//     {
//         var max = int.MinValue;
//         for (int i = 1; i < N; i++)
//         {
//             for (int j = i + 1; j <= N; j++)
//             {
//                 var curr = i & j;
//                 if(curr < K)
//                     max = Math.Max(max, curr);
//             }
//         }
//         return max;
//     }
// }

// ************ 30 Days Challenge End ************

// ************ C# Basic Test ************
// Question 1:
// var notesStoreObj = new NotesStore();
// var n = int.Parse(Console.ReadLine());
// for (var i = 0; i < n; i++) {
//     var operationInfo = Console.ReadLine().Split(' ');
//     try
//     {
//         if (operationInfo[0] == "AddNote")
//             notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
//         else if (operationInfo[0] == "GetNotes")
//         {
//             var result = notesStoreObj.GetNotes(operationInfo[1]);
//             if (result.Count == 0)
//                 Console.WriteLine("No Notes");
//             else
//                 Console.WriteLine(string.Join(",", result));
//         } else {
//             Console.WriteLine("Invalid Parameter");
//         }
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine("Error: " + e.Message);
//     }
// }

// public class NotesStore
// {
//     public List<string> ActiveNotes = new List<string>();
//     public List<string> CompletedNotes = new List<string>();
//     public List<string> OtherNotes  = new List<string>();
//     public NotesStore() {}
//     public void AddNote(String state, String name) 
//     {
//         if(string.IsNullOrEmpty(name))
//             throw new Exception("Name cannot be empty");
//         if(!(state == "active" || state == "completed" || state == "others"))
//             throw new Exception("Invalid state " + state);
//         switch(state)
//         {
//             case "active":
//                 ActiveNotes.Add(name);
//                 break;
//             case "completed":
//                 CompletedNotes.Add(name);
//                 break;
//             case "others":
//                 OtherNotes.Add(name);
//                 break;
//         }
//     }
//     public List<String> GetNotes(String state) 
//     {
//         if(!(state == "active" || state == "completed" || state == "others"))
//             throw new Exception("Invalid state " + state);
//         switch(state)
//         {
//             case "active":
//                 return ActiveNotes;
//             case "completed":
//                 return CompletedNotes;
//             case "others":
//                 return OtherNotes;
//             default:
//                 return new List<string>();
//         }
//     }
// }

// Question 2:
// int countOfEmployees = int.Parse(Console.ReadLine());

// var employees = new List<Employee>();

// for (int i = 0; i < countOfEmployees; i++)
// {
//     string str = Console.ReadLine();
//     string[] strArr = str.Split(' ');
//     employees.Add(new Employee { 
//         FirstName = strArr[0], 
//         LastName = strArr[1], 
//         Company = strArr[2], 
//         Age = int.Parse(strArr[3]) 
//         });
// }

// foreach (var emp in AverageAgeForEachCompany(employees))
// {
//     Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
// }

// foreach (var emp in CountOfEmployeesForEachCompany(employees))
// {
//     Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
// }

// foreach (var emp in OldestAgeForEachCompany(employees))
// {
//     Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
// }

// static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
// {
//     var result = new Dictionary<string, int>();
//     var companyList = new Dictionary<string, int>();
//     employees.Sort((x, y) => x.Company.CompareTo(y.Company));
//     foreach(var employee in employees)
//     {
//         if(result.ContainsKey(employee.Company))
//         {
//             result[employee.Company] += employee.Age;
//             companyList[employee.Company] += 1;
//         }
            
//         else
//         {
//             result.Add(employee.Company, employee.Age);
//             companyList.Add(employee.Company, 1);
//         }
//     }
//     foreach (var item in result)
//     {
//         result[item.Key] = (int)Math.Round((decimal)item.Value / companyList[item.Key]);
//     }

//     return result;
// }

// static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
// {
//     employees.Sort((x, y) => x.Company.CompareTo(y.Company));
//     var result = new Dictionary<string, int>();
//     foreach(var employee in employees)
//     {
//         if(result.ContainsKey(employee.Company))
//         {
//             result[employee.Company] += 1;
//         }            
//         else
//         {
//             result.Add(employee.Company, 1);
//         }
//     }
//     return result;
// }

// static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
// {
//     var result = new Dictionary<string, Employee>();
//     employees.Sort((x, y) => x.Company.CompareTo(y.Company));
//     foreach(var employee in employees)
//     {
//         if(result.ContainsKey(employee.Company))
//         {
//             if(employee.Age > result[employee.Company].Age)
//             {
//                 result[employee.Company] = employee;
//             }
//         }
//         else
//         {
//             result.Add(employee.Company, employee);
//         }
//     }
//     return result;  

// }

// public class Employee
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }
//     public string Company { get; set; }
// }

// ************ C# Basic Test End ************


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
//     DateTime  date = DateTime.Parse(s);
//     return date.ToString("HH:mm:ss");
// }
// Console.WriteLine(timeConversion("12:45:54PM"));

// Day 1 - Mock Test - Find Median
// Console.WriteLine(Result.findMedian(new List<int> { 0, 1, 2, 3, 4, 5, 6 }));
// class Result
// {
//     public static int findMedian(List<int> arr)
//     {
//         var count = arr.Count();
//         if(count % 2 == 0)
//         {
//             return arr[count / 2] + arr[count / 2 - 1] / 2;
//         }
//         else
//         {
//             return arr[count / 2];
//         }
//     }
// }

// Day 2 - Lonely Integer
// Console.WriteLine(Result.lonelyinteger(new List<int> { 1, 2, 3, 4, 3, 2, 1 }));
// class Result
// {
//     public static int lonelyinteger(List<int> a)
//     {
//         return a.Distinct().First(x => a.Count(y => y == x) == 1);
//     }
// }

// Day 2 - Diagonal Difference
// Console.WriteLine(Result.diagonalDifference(new List<List<int>> { new List<int> { 11, 2, 4 }, new List<int> { 4, 5, 6 }, new List<int> { 10, 8, -12 } }));
// class Result
// {
//     public static int diagonalDifference(List<List<int>> arr)
//     {
//         var count = arr.Count();
//         int rightDiagonal = 0, leftDiagonal = 0;
//         for (int i = 0; i < count; i++)
//         {
//             rightDiagonal += arr[i][i];
//             leftDiagonal += arr[i][count - i - 1];
//         }
//         return Math.Abs(rightDiagonal - leftDiagonal);
//     }
// }

// Day 2 - Counting Sort 1
// var result = Result.countingSort(new List<int> {    63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99,
//                                                     12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30,
//                                                     27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23,
//                                                     41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33,
//                                                     60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 });
// Console.WriteLine(string.Join(", ", result));
// class Result
// {
//     public static List<int> countingSort(List<int> arr)
//     {
//         arr.Sort();
//         var count = arr.Count();
//         var result = new int[100];
//         for (int i = 0; i < count; i++)
//         {
//             result[arr[i]]++;
//         }
//         return result.ToList();
//     }
// }

// Day 2 - Mock Test - Flipping the Matrix
Console.WriteLine(Result.flippingMatrix(new List<List<int>> {   new List<int> { 112, 42, 83, 119 },
                                                                new List<int> { 56, 125, 56, 49 },
                                                                new List<int> { 15, 78, 101, 43 },
                                                                new List<int> { 62, 98, 114, 108 } }));
class Result
{
    public static int flippingMatrix(List<List<int>> matrix)
    {
        return matrix.Select(x => x.Sum()).Sum();
    }
}