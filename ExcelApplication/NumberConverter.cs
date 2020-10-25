using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApplication
{
    public struct Index
    {
        public int row;
        public int column;
    }

    public static class NumberConverter
    {
        public static string ConvertTo26System(int x)
        {
            int k = 0;
            int[] arr = new int[100];
            while (x > 25)
            {
                arr[k] = x / 26 - 1;
                k++;
               x = x % 26;
            }

            arr[k] = x;
            string result = "";
            for (int j = 0; j <= k; j++)
                result += ((char)('A' + arr[j])).ToString();

            return result;
        }

        public static Index ConvertFrom26System(string s)
        {
            Index index = new Index();
            index.column = 0;
            index.row = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] >= 64 && s[i] < 91)
                {
                    index.column *= 26;
                    index.column += s[i] - 64;
                }
                else if(s[i] > 47 && s[i] < 58)
                {
                    index.row *= 10;
                    index.row += s[i] - 48;
                }
            }
            index.column--;
            return index;
        }
    }
}
