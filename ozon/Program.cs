
//int q = int.Parse(Console.ReadLine());
//while (q )
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

using System.Text.RegularExpressions;

string number = Console.ReadLine();
////char [] auto = number.ToCharArray();
//char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
//foreach (int i in letters )

Regex regex = new Regex("[abcehkmoptxy][0 - 9]{3}[abcehkmoptxy] { 2}\r\n[0-9] {2,3}") ;
Console.WriteLine(regex.IsMatch(number));
//{"'0'", letters[i]}

