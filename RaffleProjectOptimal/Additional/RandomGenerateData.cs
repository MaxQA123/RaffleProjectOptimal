using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Additional
{
    public class RandomGenerateData
    {
        public static string RandomStringForFirstLastName(int size)
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjklzxcvbnm";
            string firstLastName = new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string stringBuilder = ti.ToTitleCase(firstLastName);
            return stringBuilder;
        }
        public static string RandomString()
        {
            Random random = new Random();
            const string chars = "qwertyuioplkjhgfdsazxcvbnm";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomStringTitle(int size)
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjklzxcvbnm";
            string firstLastName = new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string stringBuilder = ti.ToTitleCase(firstLastName);
            return stringBuilder;
        }
        public static string RandomStringSubTitle(int size)
        {
            Random random = new Random();
            const string chars = "qw ertyui oplkjhg fdsaz xcvb nm";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomStringDescription(int size)
        {
            Random random = new Random();
            const string chars = "qw ertyui oplkjhg fdsaz xcvb nm";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}