using System;

namespace CaseEkol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" (*) çıkmasını beklediğiniz karakter sayısını giriniz(n)");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("String Veriyi Giriniz(aabbbistanbulaaassskkkk b bbbbbcacaankara)");
            string veri = Console.ReadLine();
            Console.WriteLine(ReplaceDuplicateChars(veri,n));
            Console.ReadLine();
        }

        public static string ReplaceDuplicateChars(string s,int n)
        {
            string newstr = "";
            string temp = "";
            for (int i = 1; i <= s.Length; ++i)
            {
                if (s.Length != i)
                {
                    if (s[i] == s[i - 1])
                        temp += s[i - 1];
                    else
                    {
                        string tempTemp = "";
                        if (temp != "")
                            temp += s[i - 1];
                        else
                            tempTemp += s[i - 1];

                        if (temp.Length >= n)
                        {
                            for (int t = 0; t < temp.Length; t++)
                                tempTemp += "*";
                            temp = "";
                        }
                        else
                        {
                            if (tempTemp == "")
                                tempTemp += temp;
                            temp = "";
                        }
                        newstr += tempTemp;
                    }
                }
                else
                    newstr += s[i - 1];
            }

            return newstr;
        }


    }
}
