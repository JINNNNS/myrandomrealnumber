using System;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            

            while (true)
            {

                int answer = rand.Next(1, 300);
                Console.WriteLine(answer);
                Console.Write("숫자를 입력해주세요: ");
                int i = int.Parse(Console.ReadLine());

                if (i == answer)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }

                else if (i > answer)
                {
                    Console.WriteLine(i+"보다는 작은 숫자입니다.");

                }

                else if (i < answer)
                {
                    Console.WriteLine(i+"보다는 큰 숫자입니다.");
                }
            }
        }
    }
}
