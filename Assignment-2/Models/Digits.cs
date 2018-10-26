using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_2.Models.Extensions;

namespace Assignment_2.Models
{
    public class Digits
    {
        string a = "abc123".ToDigitsOnly();
        string x = "z1x2c3v4".ToDigitsOnly();
        string y = "#$ss223%^".ToDigitsOnly();

    }
}