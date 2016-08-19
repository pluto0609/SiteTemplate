using System.Text;

namespace Jaap.Framework
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string GetMd5(this string str)
        {
            return Md5Helper.GetMd5ByString(str);
        }

        public static string GetMd5(this string str, Encoding encoding)
        {
            return Md5Helper.GetMd5ByString(str, encoding);
        }
    }
}