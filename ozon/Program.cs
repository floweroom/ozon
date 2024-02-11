using System.ComponentModel.Design;

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());
var number = int.Parse(input.ReadLine());

for (var i = 0; i < number; i++)

{

    var massive = input.ReadLine();


    string separators = " ";

    string[] year = massive.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    
    
    if (Convert.ToInt32(year[year.Length - 2]) == 1 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {
        Console.WriteLine("yes");
    }

    else if (Convert.ToInt32(year[year.Length - 2]) == 3 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 4 && Convert.ToInt32(year[year.Length - 3]) <= 30)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 5 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 6 && Convert.ToInt32(year[year.Length - 3]) <= 30)
    {
        Console.WriteLine("yes");
    }

    else if (Convert.ToInt32(year[year.Length - 2]) == 7 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {

        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 8 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {

        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 9 && Convert.ToInt32(year[year.Length - 3]) <= 30)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 10 && Convert.ToInt32(year[year.Length - 3]) <= 31)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 11 && Convert.ToInt32(year[year.Length - 3]) <= 30)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 12 && Convert.ToInt32(year[year.Length - 3]) <= 31)

    {
        Console.WriteLine("yes");
    }

    else if (Convert.ToInt32(year[year.Length - 2]) == 2 && Convert.ToInt32(year[year.Length - 3]) <= 29 && Convert.ToInt32(year[year.Length - 1]) % 4 == 0 || Convert.ToInt32(year[year.Length - 1]) % 400 == 0)
    {
        Console.WriteLine("yes");
    }
    else if (Convert.ToInt32(year[year.Length - 2]) == 2 && Convert.ToInt32(year[year.Length - 3]) <= 28 && Convert.ToInt32(year[year.Length - 1]) % 4 != 0 || Convert.ToInt32(year[year.Length - 1]) % 400 != 0)
    {
        Console.WriteLine("yes");
    }



    else
    {
        Console.WriteLine("no");
    }


}

    
return;


//string number = Console.ReadLine();
//char[] auto = number.ToCharArray();
//char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
////foreach (int i in letters)
//
//    using System.Text.RegularExpressions;

//var input = new StreamReader(Console.OpenStandardInput());
//var output = new StreamWriter(Console.OpenStandardOutput());

//var number = int.Parse(input.ReadLine());

//for (var i = 0; i < number; i++)
//{
//    var st = input.ReadLine();

//    var index = 0;
//    var fail = false;
//    var num = 0;
//    var result = "";
//    foreach (Match m in Regex.Matches(st, "[A-Z][0-9]{1,2}[A-Z]{2}"))
//    {
//        if (m.Index != index)
//        {
//            fail = true;
//            break;
//        }

//        if (num > 0)
//        {
//            result += " ";
//        }

//        result += m.Value;

//        num++;
//        index += m.Length;
//    }
//    if (fail || st.Length != index)
//        Console.WriteLine("-");
//    else
//        Console.WriteLine(result);
//}





/*
var s = input.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
output.Write(a + b);
*/



//string str = input.ReadToEnd();

//foreach (Match m in Regex.Matches(str, "[A-Z][0-9]{1,2}[A-Z]{2}"))

//    output.WriteLine(m);


//using static System.Runtime.InteropServices.JavaScript.JSType;

//using var input = new StreamReader(Console.OpenStandardInput());
//using var output = new StreamWriter(Console.OpenStandardOutput());

//int day = int.Parse(Console.ReadLine());
//for (var i = 0; i < day; i++)
//{
//    int max = 30;
//    int min = 15;
//    int worker = int.Parse(Console.ReadLine());
//    for (var j = 0; j < worker; j++)
//    {
//        string temp = Console.ReadLine();
//        string separators = " ";

//        string[] temperatur = temp.Split(separators, StringSplitOptions.RemoveEmptyEntries);

//        max = Math.Min(temperatur[1], max);


//        //    if (temperatur[0].EndsWith(">=") && int.Parse(temperatur[1]) > 15)
//        //    {
//        //        Console.WriteLine(temperatur[1]);
//        //    }

//        //          if (temperatur[0].EndsWith(">=") && int.Parse(temperatur[1]) > )


//        //         if (y > max)
//        //            {
//        //              -1;
//        //            }
//        //                  if (temp < min)
//        //{

//        //}
//    }


//}

//// 6 >= 18 <= 23 >= 20 <= 27 <= 21 >= 28

