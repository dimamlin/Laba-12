using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace laba_12
{

    class Program
    {
        static void Main(string[] args)
        {
            // №1

            Reflector.ToFile("MyVector", "info");
            Reflector.ToFile("Time", "time");
            Reflector.ToFile("Software", "soft");

            // №2

            Reflector.GetPublicMethods("MyVector");
            Reflector.GetPublicMethods("Time");

            // №3

            Reflector.GetField("MyVector");

            // №4 

            Reflector.GetInterfaces("MyVector");

            // №5 

            Reflector.GetMethodsByParam("MyVector", "System.String");

            // №6 

            Time tm = new Time("dimamlin", 31, 200);
            Reflector._CallMethodFromFile<Time>(tm);
        }
    }

}