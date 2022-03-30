using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Class1
    {
        public bool CheckMark(string mark)
        {
            string text = "abekmhopctyx";
            if (!text.Contains(mark[0].ToString()))
            {
                return false;
            }

            if (!char.IsDigit(mark[1]) || !char.IsDigit(mark[2]) || !char.IsDigit(mark[3]))
            {
                return false;
            }

            if (!text.Contains(mark[4].ToString()) || !text.Contains(mark[5].ToString()))
            {
                return false;
            }

            if (!char.IsDigit(mark[6]))
            {
                return false;
            }

            if (mark.Length >= 7 && !char.IsDigit(mark[7]))
            {
                return false;
            }

            if (mark.Length >= 8 && !char.IsDigit(mark[7]))
            {
                return false;
            }

            return true;
        }

        public string GetNextMarkAfter(string mark)
        {
            string result = "";
            string text = "abekmhopctyx";
            string text2 = mark[0].ToString();
            string str = mark.Substring(6, mark.Length - 6);
            string text3 = mark.Substring(0, 6);
            string text4 = mark.Substring(1, 3);
            string text5 = mark.Substring(4, 2);
            if (text4 == "999")
            {
                text4 = "000";
                if (text5[1] == 'x')
                {
                    if (text5[0] == 'x')
                    {
                        text5 = "aa";
                        if (!(text2 != "x"))
                        {
                            return "out of stock";
                        }

                        text2 = text[text.IndexOf(text2) + 1].ToString();
                        result = text2 + text4 + text5 + str;
                    }
                }
                else
                {
                    text5 = text5[0].ToString() + text[text.IndexOf(text5[1]) + 1];
                    result = text2 + text4 + text5 + str;
                }
            }
            else
            {
                int num = int.Parse(text4);
                text4 = (num + 1).ToString();
                if (text4.Length < 3)
                {
                    text4 = "0" + text4;
                }

                if (text4.Length < 3)
                {
                    text4 = "0" + text4;
                }

                result = text2 + text4 + text5 + str;
            }

            return result;
        }

        public string GetNextMarkAfterInRange(string prevMark, string rangeStart, string rangeEnd)
        {
            if (prevMark == rangeStart)
            {
                return rangeStart;
            }

            if (prevMark == rangeEnd)
            {
                return rangeEnd;
            }

            string text = "";
            char c = prevMark[0];
            string text2 = prevMark.Substring(6, prevMark.Length - 6);
            string text3 = prevMark.Substring(0, 6);
            string s = prevMark.Substring(1, 3);
            int num = int.Parse(s);
            string text4 = prevMark.Substring(4, 2);
            char c2 = rangeStart[0];
            string text5 = rangeStart.Substring(0, 6);
            string s2 = rangeStart.Substring(1, 3);
            string text6 = rangeStart.Substring(4, 2);
            int num2 = int.Parse(s2);
            char c3 = rangeEnd[0];
            string text7 = rangeEnd.Substring(0, 6);
            string s3 = rangeEnd.Substring(1, 3);
            string text8 = rangeEnd.Substring(4, 2);
            int num3 = int.Parse(s3);
            text = ((rangeStart == rangeEnd) ? rangeStart : ((c > c2) ? GetNextMarkAfter(prevMark) : ((num > num2) ? GetNextMarkAfter(prevMark) : ((text4[0] > text6[0]) ? GetNextMarkAfter(prevMark) : ((text4[1] > text6[1]) ? GetNextMarkAfter(prevMark) : ((!(rangeStart == prevMark)) ? GetNextMarkAfter(rangeStart) : rangeStart))))));
            if (text == "out of stock")
            {
                return text;
            }

            c = text[0];
            text2 = text.Substring(6, text.Length - 6);
            text3 = text.Substring(0, 6);
            s = text.Substring(1, 3);
            num = int.Parse(s);
            text4 = text.Substring(4, 2);
            if (c > c3)
            {
                return "out of stock";
            }

            if (num > num3)
            {
                return "out of stock";
            }

            if (text4[0] > text8[0])
            {
                return "out of stock";
            }

            if (text4[1] > text8[1])
            {
                return "out of stock";
            }

            return text;
        }
    }
}
