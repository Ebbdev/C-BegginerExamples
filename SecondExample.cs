using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonk
{
    class Program
    {
        public static bool f;
        public static bool t;
        ///Çalışma mantığı 
        ///4 kural için 4 fonksyon bulunmaktadır ve dönüş değerleri true false olarak ayarladım sebebi ise kural 1'e giren bazen 2. kurala da girebiliyordu fakat booleanlar ile
        ///bu durumun önüne geçtim.true false çevirerekten sırası ile 1-2-3-4. kuralları kontrol ediyor.

        static bool FirstRule(string[] first)
        {
            ///Birinci kuralda olumsuz olanlar kelimeleri kontrol ediyor
            string[] negative_word = { "stress", "depression", "sad", "angr", "hate", "pain", "abnormal", "abort", "abuse", "brittle", "hurt", "scared", "afraid", "upset", "confused", "lonely", "tired", "vulnerable", "guilty", "anxiety", "disappointment", "regret", "awful", "sick", "regretful", "unhappy", "sorrowful", "troubled", "worried", "worried", "annoyed" };
            bool first_bool = true;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < negative_word.Length; j++)
                {
                    if (first[i] == negative_word[j])
                    {
                        Console.WriteLine("Computer : Being " + first[i] + " is bad for your health. How long do you feel " + first[i] + "?" + " Why do you feel " + first[i] + "?");
                        first_bool = false;
                        break;
                    }
                }
            }
            return first_bool;
        }
        static bool SecondRule(string[] second)
        {
            ///Soru kelimelerinin bulunup bulunmamasına göre random atamaları yapıyor.
            bool second_bool = true;
            string[] questions_tag = { "why", "who", "when", "where", "what", "how" };
            string[] question_repeat = { "Do you often think about this question?", "Why do you want to know" };
            Random ques = new Random();
            int ques_number;
            for (int i = 0; i < second.Length; i++)
            {
                for (int c = 0; c < questions_tag.Length; c++)
                {
                    if (questions_tag[c] == second[i])
                    {
                        ques_number = ques.Next(0, 2);
                        Console.WriteLine("Computer : " + question_repeat[ques_number]);
                        second_bool = false;
                        break;
                    }
                }
            }
            return second_bool;
        }
        static bool ThirdRule(string[] third)
        {
            ///stop wordler dışında kalan kısımları sayaç ile kontrol ettirip gerekli cevabı döndürüyor.
            bool third_bool = true;
            string[] stop_words = { "a"," ","after", "again", "all", "all", "am", "and", "any", "are", "as", "at", "be", "been", "before", "between",
                "both", "but", "by", "can", "could", "for", "from", "had", "has", "he", "her", "here", "him", "in", "into", "I", "is", "it", "me", "my",
                "of", "on", "our", "she", "so", "than", "that", "the", "then", "they", "this", "to", "until", "we", "were", "was", "with", "you" };
            int counter = 0;
            for (int i = 0; i < third.Length; i++)
            {
                for (int j = 0; j < stop_words.Length; j++)
                {
                    if (third[i] == stop_words[j])
                    {
                        third[i] = " ";
                    }
                }
            }
            for (int i = 0; i < third.Length; i++)
            {
                for (int j = i + 1; j < third.Length; j++)
                {
                    if (third[i] == third[j] && third[i] != " ")
                    {
                        counter++;
                    }
                }
                if (counter > 2)
                {
                    Console.Write("Computer : Do you love " + third[i]);
                    Console.WriteLine();
                    counter = 0;
                    third_bool = false;
                    break;
                }
            }
            return third_bool;
        }
        static bool ForthRule(string[] four)
        {
            ///Cevabın tekrar edilmesi,yeslerin kaldırılması ve random soru gelmesi bu kısımlarda yapılmaktadır.
            bool f = true;
            Random ques = new Random();
            int ques_number = ques.Next(0,2);
            string[] remove = { "yes", "yes." };
            string[] convert = { "ı", "my", "myself", "am", "me" };
            string[] convert_words = { "You", "your", "yourself", "are", "you" };
            for (int i = 0; i < four.Length; i++)
            {
                for (int j = 0; j < remove.Length; j++)
                {
                    if (four[i] == remove[j])
                        four[i] = null;
                }

            }
            Console.Write("Computer: ");
            ques_number = ques.Next(0, 2);
            string print = "";
            for (int i = 0; i < four.Length; i++)
            {
                for (int j = 0; j < convert.Length; j++)
                {
                    if (four[i] == convert[j])
                    {
                        four[i] = convert_words [j];  
                        f = false;
                    }   
                }
            }
            for (int i = 0; i < four.Length; i++)
            {
                print = print + four[i]+" ";
            }
            if(ques_number==0)
            {
                Console.Write("You say " + print);
            }
            else if(ques_number==1)
            {
                Console.Write(print + " right?");
            }
            Console.WriteLine();
            return f;
        }
        static void Main(string[] args)
        {
            ///Burda iflerde ve bağlacı kullanma sebebim varsayılan değerleri true olduğu için mantıksal doğrulamaların yapılması için gerekliydi
            ///örneğin 1 için false döndüğünde ikinci fonksyondaki varsayılan değer true olması 3. kuralı etkiliyordu
            ///Detaylı olarak çizildiğinde mantıksal doğrulama ve çalışması doğru noktaların da boşlukla girilmesi lazım
            string input;
            bool flag = true;
            bool s;
            while (flag!=false)
            {
                Console.Write("User     : ");
                input = Console.ReadLine();
                if(input=="I have to go now")
                {
                    flag = false;
                    break;
                }
                input = input.ToLower();
                string[] user_inputt = input.Split(' ');
                s = FirstRule(user_inputt);
                if (s == true)
                {
                    f = SecondRule(user_inputt);    
                }
                if (f == true && s == true)
                {
                    t = ThirdRule(user_inputt);
                }
                if(t == true && s==true )
                {
                    input = input.ToLower();
                    user_inputt = input.Split(' ');
                    ForthRule(user_inputt);
                }  
            }
            Console.ReadKey();
        }
    }
}
