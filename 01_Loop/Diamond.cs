using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01_Loop
{
    public class Diamond
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        private int count;
        public int Count { get { return count; } }

        /// <summary>
        /// 1이 아니고 홀수를 입력할 때까지 반복하는 생성자
        /// </summary>
        /// <param name="num"></param>
        public Diamond(int num)
        {
            while (num == 1)
            {
                Console.WriteLine("1이 아닌 값을 입력하시오 : ");
                int.TryParse(sr.ReadLine(), out num);
            }
            while (num % 2 == 0)
            {
                Console.WriteLine("홀수를 입력하세요 : ");
                int.TryParse(sr.ReadLine(), out num);
            }
            count = num;
        }

        public string Drow() { return "*"; }

        /// <summary>
        /// 다이아몬드 반복문
        /// 1. 다이아몬드를 반으로 나누어 * 개수가 증가하는 삼각형 그리기
        /// 2. 가장 긴 가로줄 만들기
        /// 3. * 개수가 감소하는 삼각형 그리기
        /// </summary>
        /// <returns></returns>
        public StringBuilder DiamondLoop()
        {
            StringBuilder sb = new StringBuilder();
            int half = count / 2;
            // 증가하는 삼각형
            for(int y = 0, star = 1; y < half; y++, star+=2)
            {
                for(int x = 0, drawS = star; x < count; x++)
                {
                    if ((count - star) / 2 > x)             // 앞 줄의 비어있는 칸 확인
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        if (drawS > 0)                      // 그려야하는 별의 개수가 남아있다면
                        {
                            sb.Append(Drow());
                            drawS--;
                        }
                        else                                // 다 그렸다면
                        {
                            sb.Append(" ");             
                        }
                    }
                }
                sb.AppendLine();
            }
            // 중간의 한 줄
            for (int x = 0; x < count; x++)
            {
                sb.Append(Drow());
            }
            sb.AppendLine();
            // 감소하는 삼각형

            for(int y = half, star = count - 2; y < count; y++, star -=2)
            {
                for(int x = 0, drawS = star; x < count; x++)
                {
                    if((count- drawS) / 2 > x) { sb.Append(" "); }
                    else
                    {
                        if (drawS > 0)
                        {
                            sb.Append(Drow());
                            drawS--;
                        }
                        else { sb.Append(" ");}
                    }
                }
                sb.AppendLine();
            }
            return sb;
        }
    }
}
