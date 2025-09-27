using System.Text;

namespace _01_Loop
{
    internal class TriangleLoop
    {
        /// <summary>
        /// StringBuilder에 *을 저장
        /// </summary>
        /// <returns></returns>
        public string Drow() { return "*"; }

        /// <summary>
        /// 출력예시
        /// *
        /// **
        /// ***
        /// ****
        /// *****
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string Number1(int line)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number1\n====================");
            for (int count = 0; count < line; count++)
            {
                for (int star = 1; star <= count + 1; star++)
                {
                    sb.Append(Drow());
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 출력예시
        ///      *
        ///     **
        ///    ***
        ///   ****
        ///  *****
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string Number2(int line)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number2\n====================");
            for (int y = 0, star = 1; y < line; y++, star++)
            {
                for (int x = 0; x < line; x++)
                {
                    if (x < line - star)
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(Drow());
                    }
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 출력예시
        /// *****
        /// ****
        /// ***
        /// **
        /// *
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string Number3(int line)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number3\n====================");
            for (int y = 0; y < line; y++)
            {
                for (int x = line - y; x > 0; x--)
                {
                    sb.Append(Drow());
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 출력예시
        /// *****
        ///  ****
        ///   ***
        ///    **
        ///     *
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string Number4(int line)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number4\n====================");
            for (int y = 0, star = 5; y < line; y++, star--)
            {
                for (int x = 0; x < line; x++)
                {
                    if (line - x <= star)
                    {
                        sb.Append(Drow());
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
