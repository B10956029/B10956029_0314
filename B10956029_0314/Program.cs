using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10956029_0314
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] studentNo = {1,2,3,4,5};
            string[] studentName = {"Jack","Mary","Tom","Grace","Alice"};
            int[] computerScore = {80,65,100,98,83};
            int[] progarmScore = {75,67,93,25,82};
            int[] animationScore = {60,62,91,50,87};

            while (true)
            {
                Console.WriteLine("請輸入座號");
                String input = Console.ReadLine();
                int inputstudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, inputstudentNo);

                if (arrayIndex>-1)
                {
                    Console.WriteLine("姓名:"+studentName[arrayIndex]);
                    Console.WriteLine("電腦概論:"+ computerScore[arrayIndex]);
                    Console.WriteLine("程式設計:"+ progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計:"+ animationScore[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("沒有座號");
                }
            }
            

            Console.ReadLine();

            //Console.WriteLine("請輸入數字");
            //String input = Console.ReadLine();
            //int n = int.Parse(input);
            //for( var A=0; A < n; A++)
            //{
            //    for (var A1 = 0;  A1 < A; A1++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //   Console.WriteLine();
            //}

            //Console.WriteLine("請輸入數字");
            //String N1 = Console.ReadLine();
            //int N = int.Parse(N1);
            //Console.WriteLine(N+"*1="+(N * 1));
            //Console.WriteLine(N+"*1="+(N * 2));
            //Console.WriteLine(N+"*1="+(N * 3));

            //Console.WriteLine("九九乘法表");
            //for (int i=1;i<10;i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine(i+"*"+j+"="+(i*j)); 
            //    }
            //}


            //int a = 5;

            //if (a%2==1)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if(a<2 && a>5)
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else if(a < 6 && a > 20)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else
            //{
            //    Console.WriteLine("Not Weird");
            //}

            //switch (a) 
            //{
            //    case 5:
            //        Console.WriteLine("Weird");
            //        break;

            //    default:
            //        Console.WriteLine("Weird");
            //        break;
            //}


            //for (int b=1;b<=10;b++)
            //{
            //    Console.WriteLine("Weird");
            //}

            //int i= 0;
            //while(i<=10)
            //{
            //    Console.WriteLine("Weird");
            //    i++;
            //}


            //try
            //{
            //    //......
            //    Console.WriteLine("Weird");
            //}
            //catch(Exception e)
            //{
            //    //記錄錯誤
            //}

            //int[] arr = { 1, 3, 5, 7 };
            //Console.WriteLine(arr.Length);

            

        }
    }
}
