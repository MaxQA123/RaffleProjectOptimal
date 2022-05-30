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
    }
}
