using System;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Linq;

//Задание 1 a
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//Regex sub = new Regex(@"abcd(2023)[1]{7}0\1");
//string substr = new string("^abcd2023111111102023$");
//Regex reg = new Regex("2023");
//Console.WriteLine(Regex.IsMatch(str, substr));
//str = reg.Replace(str, "happy new year");
//Console.WriteLine(str);

// Задание 1 b
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//string sub = "[0-9]+";
//Regex rg = new Regex(sub);
//MatchCollection arr = rg.Matches(str);
//List<int> arr1 = new List<int>();
//int sum = 0;
//foreach(Match m in arr)
//{
//    arr1.Add(int.Parse(m.Value));
//}
//for (int i = 0; i < arr1.Count; i++)
//{
//    Console.WriteLine(arr1[i].ToString());
//    sum += arr1[i];
//}
//Console.WriteLine("Sum=" + sum);
//Console.WriteLine("Max=" + arr1.Max() + " Index=" + arr1.IndexOf(arr1.Max()));

//Задание 1 с
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//string sub = @"[+-\\d]?[0-9]+\.?\,?[0-9]+";
//string sub1 = @"[+-\\d]?[0-9]+\.+[0-9]+";
//string sub2= @"[+-\\d]?[0-9]+\,+[0-9]+";
//Regex rg = new Regex(sub);
//Regex rg1 = new Regex(sub1);
//Regex rg2 = new Regex(sub2);
//MatchCollection arr = rg.Matches(str);
//for (int i = 0; i < arr.Count; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//str = rg1.Replace(str,"number");
//str = rg2.Replace(str,"number");
//Console.WriteLine(str);

//Задание 1 d
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//string sub = @"[0-9a-z]+[.,;!?]*[0-9a-z]*";
//Regex rg = new Regex(sub, RegexOptions.IgnoreCase);
//MatchCollection arr = rg.Matches(str);
//for (int i = 0; i < arr.Count; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Задание 1е
//string subpassword = @"(?=[0][1-9].*[/][0][1-9][/][1-9][6-9][0-9][0-9]){1,}|(?=[1-2][0-9].*[/][0][1-9][/][1-9][6-9][0-9][0-9]){1,}|(?=[3][0].*[/][0][^2][/][1-9][6-9][0-9][0-9]){1,}|(?=[3][0].*[/][1][012][/][1-9][6-9][0-9][0-9]){1,}|(?=[3][1].*[/][1][02][/][1-9][6-9][0-9][0-9]){1,}|(?=[3][1].*[/][0][13578][/][1-9][6-9][0-9][0-9]){1,}|(?=[0][1-9].*[/][0][1-9][/][2-9][0-9][0-9][0-9]){1,}|(?=[1-2][0-9].*[/][0][1-9][/][2-9][0-9][0-9][0-9]){1,}|(?=[3][0].*[/][0][^2][/][2-9][0-9][0-9][0-9]){1,}|(?=[3][0].*[/][1][012][/][2-9][0-9][0-9][0-9]){1,}|(?=[3][1].*[/][1][02][/][2-9][0-9][0-9][0-9]){1,}|(?=[3][1].*[/][0][13578][/][2-9][0-9][0-9][0-9]){1,}";
//Regex rg = new Regex(subpassword);
//Console.WriteLine("Введите дату");
//string str = Console.ReadLine();
//Console.WriteLine(rg.IsMatch(str));

//Задание 2a
//string sub = "cat";
//Regex rg = new Regex(sub, RegexOptions.IgnoreCase);
//int n=5;
//string[] str=new string[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите строку");
//    str[i] = Console.ReadLine();
//}
//Console.WriteLine("Верные строки:");
//for(int i = 0; i < n; i++)
//{
//    if (rg.Matches(str[i]).Count == 2)
//    {
//        Console.WriteLine(str[i]);
//    }
//}


//Задание 2b
//string sub = "[a-zа-я]{10}[a-zа - я]{0,}";
//Regex rg = new Regex(sub, RegexOptions.IgnoreCase);
//int n = 1;
//string[] str = new string[n];
//string[] str1 = new string[n];
//string[] str2 = new string[n];
//string[] str3 = new string[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите строку");
//    str[i] = Console.ReadLine();
//    str1[i] = rg.Replace(str[i], "* ");
//}
//for (int i = 0; i < n; i++)
//{
//    MatchCollection arr = rg.Matches(str[i]);
//    for (int j = 0; j < arr.ToArray().Length; j++)
//    {
//        str2[i] = rg.Replace(str[i], (pattern=>pattern.Value.Substring(0,1)));
//        str3[i] = rg.Replace(str[i], (pattern => new string(Convert.ToChar(pattern.Value.Substring(0, 1)), pattern.Value.ToString().Length)));
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(str1[i]);
//}
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(str2[i]);
//}
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(str3[i]);
//}


//Задание 2с
//string sub = "ик";
//Regex rg = new Regex(sub);
//int n = 5;
//string[] str = new string[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите строку");
//    str[i] = Console.ReadLine();
//}
//Console.WriteLine("Верные строки:");
//for (int i = 0; i < n; i++)
//{
//    str[i] = rg.Replace(str[i], "");
//    Console.WriteLine(str[i]);
//}

//Задание 2d
//string sub = @"^#[A-Z0-9]{6}$";
//Regex rg = new Regex(sub);
//int n = 5;
//string[] str = new string[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите строку");
//    str[i] = Console.ReadLine();
//    Console.WriteLine(rg.IsMatch(str[i]));
//}

//Задание 2d
//string sub = @"^[a-z0-9]{8}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{4}[-][a-z0-9]{12}$";
//Regex rg = new Regex(sub);
//int n = 5;
//string[] str = new string[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Введите строку");
//    str[i] = Console.ReadLine();
//    Console.WriteLine(rg.IsMatch(str[i]));
//}

//Задание 3
//string subpassword = @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}";
//Regex rg =new Regex(subpassword);
//Console.WriteLine("Введите password");
//string str = Console.ReadLine();
//Console.WriteLine(rg.IsMatch(str));

//Задание 4
//string subpassword = @"(?=[0-9].*[+]){1,}";
//Regex rg = new Regex(subpassword);
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//Console.WriteLine(rg.IsMatch(str)); 