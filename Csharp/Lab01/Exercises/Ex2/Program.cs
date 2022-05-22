string str1 = "C# is great";
string str2 = (string)str1.Clone();

Console.WriteLine(str1);
Console.WriteLine(str2);

string str3 = string.Concat(str1,str2);

Console.WriteLine(str3);
Console.WriteLine(str3.EndsWith('t'));
Console.WriteLine(str3.ToLower());

char[] cArr;
cArr = str3.ToCharArray();
Console.WriteLine(cArr);

string str4 = "abacate;banana;abobrinha";
string[] str5 = str4.Split(';');

foreach (string s in str5)
{
    Console.WriteLine(s);
}

string str6 = str4.Replace('a', 'A');
Console.WriteLine(str6);