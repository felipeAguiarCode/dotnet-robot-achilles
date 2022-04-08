using System;
using src.core.domain;

namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
           WebDriverAdmin admin = new WebDriverAdmin();
           admin.Login();
        }
    }
}
