using System;
using System.Globalization;



namespace stringchar
{
    class Program
    {

        static void Main(string[] args)
        {
        string s1 = "Hello Summer";
            Console.WriteLine(s1);
        string s2 = null;
            Console.WriteLine(s2);
        string s3 = new String('c', 3);
            Console.WriteLine(s3);
        string s4 = new String(new char[] { 'C', 'a','t','A','n','d','D','o','g' });
            Console.WriteLine(s4);

            char ch1 = s1[1];
            Console.WriteLine(ch1);
            Console.WriteLine(s1.Length);

            string s5 = s1.ToLower();
            Console.WriteLine(s5);
            string s6 = s1.ToUpper();
            Console.WriteLine(s6);

            string s7 = s1 + " " + s5 + " " + s6;
            Console.WriteLine(s7);

            string s8 = String.Concat(s1, "!!!");
            Console.WriteLine(s8);

            string[] values = new string[] { s3, s4 }; 
            string s9 = String.Join("", values);
            Console.WriteLine(s9);

            // сравнеине строк с помощью метода Compare
            int result = String.Compare(s1, s4);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 находится перед строкой s4");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 находится после строки s4");
            }
            else
            {
                Console.WriteLine("Строка s1 и s4 одинаковый");
            }

            // поиск в строке
            char ch = 'S';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine(indexOfChar);

            string sudString = "mer";
            int indexOfSubString = s1.IndexOf(sudString);
            Console.WriteLine(indexOfSubString);

            // разделение строк при помощи функции Split
            string text = "Всё к лучшему или к деньгам";
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
                {
                Console.WriteLine(s);
            }

            // обрезка строки при помощи функции Trim -обрезка пробела начального и конечного пробелов, обрезка первого и последнего символа
            string tex = " Отличный день ";
            tex = tex.Trim();
            tex = tex.Trim(new char[] { 'О', 'ь' });
            Console.WriteLine(tex);

            // обрезка при помощи функции Substring
            string text1 = "Всё лучшее впереди";
            text1 = text1.Substring(6);
            Console.WriteLine(text1);

            string text2 = "От заката до рассвета";
            text2 = text2.Substring(0, text2.Length - 5);
            Console.WriteLine(text2);

            // вставка одной строки в другую при помощи Insert
            string text3 = "От Земли";
            string subString = " и до Луны";
            text3 = text3.Insert(8, subString);
            Console.WriteLine(text3);

            // удаление части строки при помощи Remove
            int ind = text3.Length - 2;
            text3 = text3.Remove(ind);
            Console.WriteLine(text3);

            text3 = text3.Remove(0, 5); // удаление первых 5 символов
            Console.WriteLine(text3);

            // замена символов или подстрок на другие при помощи Replase
            string text5 = "Венера и Марс";
            text5 = text5.Replace("Венера", "Юпитер");
            Console.WriteLine(text5);

            text5 = text5.Replace("р", "Р");
            Console.WriteLine(text5);

            // смена регистра 
            Console.WriteLine(text5.ToLower());
            Console.WriteLine(text5.ToUpper());

            // форматирование с помощью # ?????
            long number = 375005550055;
            string result0 = String.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine(result0);

            // форматирование с помощью d
            int number1 = 123;
            string result1 = String.Format("{0:d}", number1);
            Console.WriteLine(result1);
            
            string result2 = String.Format("{0:d6}", number1);
            Console.WriteLine(result2);

            // форматирование с помощью f
            string result3 = String.Format("{0:f}", number1);
            Console.WriteLine(result3);

            double number2 = 123.567;
            string result4 = String.Format("{0:f5}", number2);
            Console.WriteLine(result4);

            string result5 = String.Format("{0:f2}", number2);
            Console.WriteLine(result5);

            //формат % с помощью р
            decimal number3 = 0.987655m;
            Console.WriteLine("{0:P2}", number3);

            // вывод в денежной единице с помощью ToString 
            double money = 17.1;
            Console.WriteLine(money.ToString("C2"));

            // использование $
            int a = 1;
            int b = 5;
            string result6 = $"{a} + {b} = {a + b}";
            Console.WriteLine(result6);

            // текст будет написан в столбец
            string text6 = "Hello, night!"; 
            foreach (char c in text6)
            {
                Console.WriteLine(c);
            }

            //вывод ? через юникод
            char sim = (char)'\u2103';
            Console.WriteLine(sim);

            // проверка символа соответствующей категории
            char symbol = '3';
            if (char.IsLetter(symbol))
            {
                Console.WriteLine("Это буква");
            }
            
                else
            {
                Console.WriteLine("Это цифра");
            }

            var sumbol1 = 'a';
            Console.WriteLine(char.ToUpperInvariant(sumbol1)); // буква будет прописанна большой

            Console.WriteLine(char.ToLowerInvariant(sumbol1)); // буква будет прописана мальнькой

            var cultureInfo = CultureInfo.GetCultureInfo("tr"); // вывод буквы с точкой сверху
            Console.WriteLine(char.ToUpper(sumbol1, cultureInfo));

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\u00F6");

            var cc = 'K'; // преобразование символа в строку
            var ss = cc.ToString();
            Console.WriteLine(ss);

            Console.ReadKey();
        }
    }
}
