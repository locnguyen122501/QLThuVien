using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public partial class Model
    {
        public static string maTT;

        public static Boolean checkValid(string text)
        {
            Boolean f = false;
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    f = false;
                }
                else
                {
                    f = true;
                }
            }
            return f;
        }
    }
}
