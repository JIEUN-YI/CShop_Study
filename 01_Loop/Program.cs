using System.Text;

namespace _01_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            #region 다양한 삼각형 그리기
            // TriangleLoop triangleLoop = new TriangleLoop();
            // Console.WriteLine("Number 1");
            // sb.Append(triangleLoop.Number1(5));
            // Console.WriteLine("Number 2");
            // sb.Append(triangleLoop.Number2(5));
            // Console.WriteLine("Number 3");
            // sb.Append(triangleLoop.Number3(5));
            // Console.WriteLine("Number 4");
            // sb.Append(triangleLoop.Number4(5));
            // Console.WriteLine(sb.ToString());
            #endregion

            #region 다이아몬드 그리기
            Console.WriteLine("출력할 다이아몬드를 홀수로 입력 : ");
            int.TryParse(Console.ReadLine(), out int num);
            Diamond diamond = new Diamond(num);
            sb = diamond.DiamondLoop();

            Console.WriteLine(sb);
            #endregion
        }

    }
}
