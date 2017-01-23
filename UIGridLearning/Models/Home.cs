using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIGridLearning.Models
{
    public class Home
    {
        public static string Lang { get { return _Lang; } set { _Lang = value; } }
        private static string _Lang = "zh-cn";
    }
}