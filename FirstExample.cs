using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        //Koda departman eklemesi yapılmasında da çalışmaktadır.Çalışma prensibi main fonksyonumuzda
        ///cevap anahtarları ve diğer girdiler alınarak (hangi bölüme gitmek istediği-adı gibi
        ///işlemleri yaptırdığı fonksyona atılıyor yeni öğrenci eklemesi veya değişmesi sorun yaşatmaz 
        ///çünkü get.lenght diyerek dinamik (değişen) forlar ile işlemler yapılıyor.
        static void CalculatePoint(char[,] answers, string[,] candidates, string[,] departments)
        {
            int a = 0;
            int catchx = 0;
            int[] point = new int[answers.GetLength(0)];
            int[] sort = new int[point.Length];
            int[] quota = new int[departments.GetLength(0)];
            String[,] department = new String[departments.GetLength(0), 4];
            String[,] candi = new string[candidates.GetLength(0), candidates.GetLength(1)];
            char[] key = { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' };
            for (int i = 0; i < answers.GetLength(0); i++)
            {
                for (int j = 0; j < answers.GetLength(1); j++)
                {
                    if (answers[i, j] == key[j]) { point[i] = point[i] + 5; }
                    else if (answers[i, j] != key[j] && answers[i, j] != ' ') { point[i] = point[i] - 2; }
                }
            }
            int max = 0;
            do
            {
                for (int z = 0; z < point.Length; z++)
                {
                    if (max < point[z]) { max = point[z]; catchx = z; }
                }
                sort[a] = max;
                max = 0;
                point[catchx] = 0;
                for (int k = 0; k < candi.GetLength(0); k++)
                {
                    candi[a, k] = candidates[catchx, k];
                }
                a++;
            } while (answers.GetLength(0) != a);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Number");
            Console.SetCursorPosition(14, 0);
            Console.WriteLine("Name & Surname");
            Console.SetCursorPosition(35, 0);
            Console.WriteLine("Score");
            for (int f = 0; f < sort.Length; f++)
            {
                Console.WriteLine(candi[f, 0] + "          " + candi[f, 1]);
                Console.SetCursorPosition(35, f + 1);
                Console.WriteLine(sort[f]);
                for (int i = 0; i < departments.GetLength(0); i++)
                {
                    if (candi[f, 2] == departments[i, 0] && quota[i] < 4 && sort[f] >= 50) { department[i, quota[i]] = candi[f, 0]; quota[i] = quota[i] + 1; candi[f, 0] = ""; }
                    else if (candi[f, 3] == departments[i, 0] && quota[i] < 4 && sort[f] >= 50) { department[i, quota[i]] = candi[f, 0]; quota[i] = quota[i] + 1; candi[f, 0] = ""; }
                    else if (candi[f, 4] == departments[i, 0] && quota[i] < 4 && sort[f] >= 50) { department[i, quota[i]] = candi[f, 0]; quota[i] = quota[i] + 1; candi[f, 0] = ""; }
                }
            }
            Console.WriteLine();
            for (int d = 0; d < department.GetLength(0); d++)
            {
                Console.SetCursorPosition(0, 6 + d);
                Console.Write(departments[d, 0]);
                Console.SetCursorPosition(2, 6 + d);
                Console.Write(departments[d, 1]);
                Console.WriteLine(" " + department[d, 0] + " " + department[d, 1] + " " + department[d, 2] + " " + department[d, 3]);
            }
        }
        ///Eğer puanı 50'nin altındaysa da yerleşemez.
        static void Main(string[] args)
        {
            char[,] answers ={{'A','D','B','B',' ','C','A','A','B',' ','A','B','A','A','A','A','C','A','C','D'},
                 {'A','B','B','C','D','C','D','A','B','C','D','B','A','A','B','A','C','A','C','D'},
                 {'A','D','A','B','D','C','A','A','B','C','A','B','A','B',' ','C','C','A',' ','D'},
                 { 'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' },
                 {'F',' ','F','F','D','D','D','D','D','C','D','D','D',' ','B','D','C','A','D','D'} };
            string[,] candidates = {{"2005","Ali Terim","4","6","1"},
                        {"1844","Ece Yaman","1","4",""},
                        {"3020","Ege Soylu","5","",""},
                        {"1010","Emirhan Bilge Bulut","1","5",""},
                        {"2280","Ahmet Akkoyun","4","3","5"} };
            string[,] departments = {{"1","COMPUTER ENGINEERING"},
                         {"2","ELECTRONICS ENGINEERING"},
                         {"3","MEDICINE"},
                         {"4","DENTISTRY"},
                         {"5","VET" } };
            CalculatePoint(answers, candidates, departments);
            Console.Read();
        }
    }
}
