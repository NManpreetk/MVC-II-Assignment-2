using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_2.Models;

namespace Assignment_2.Models.Extensions
{
    public static class ExtensionMethod
    {
        public static DateTime ToAge(this DateTime birth)
        {
            for (int Day = 0; Day < 365; Day++)
            {
                DateTime Birth = new DateTime(1960, 1, 1);
                Birth = Birth.AddDays(Day);


                DateTime Today = DateTime.Now.Date;


                TimeSpan Span = Today - Birth;


                DateTime Age = DateTime.MinValue + Span;


                int Years = Age.Year - 1;
                int Months = Age.Month - 1;
                int Days = Age.Day - 1;
                Console.WriteLine(Birth.ToShortDateString() + ": " + Years.ToString() + " Years, " + Months.ToString() + " Months, " + Days.ToString() + " Days<br />");
                return;
            }
        }

        public static int ToDigitsOnly(this Digits digit)
        {
            string a = "str123";
            string b = string.Empty;
            int val;

            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    b += a[i];
            }

            if (b.Length > 0)
                val = int.Parse(b);

            return;
        }
    }
}