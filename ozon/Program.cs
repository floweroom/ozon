
//var number = int.Parse(Console.ReadLine());

//for (var i = 0; i < number; i++)

//{
//    //Console.WriteLine("Введите дату");
//    string massive;
//    massive = Console.ReadLine();

//    string separators = " ";

//    string[] year = massive.Split(separators, StringSplitOptions.RemoveEmptyEntries);

//    int y = Convert.ToInt32(year[year.Length - 1]);
//    bool t = true;
//    t = y % 4 == 0 || y % 400 == 0;
//    Console.WriteLine(t ? "yes" : "no");
//}


//return;


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


using static System.Runtime.InteropServices.JavaScript.JSType;

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

int day = int.Parse(Console.ReadLine()); 
for (var i = 0; i < day; i++)
{
    int max = 30;
    int min = 15;
    int worker = int.Parse(Console.ReadLine());
    for (var j = 0; j < worker; j++)
    {
        
    }


}

//4 1 >= 30 6 >= 18 <= 23 >= 20 <= 27 <= 21 >= 28

