using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Store_Type
{
    

        public class MainLogger
        {
            public virtual void Log(string message)
            {
                Console.WriteLine(message);
            }

            public virtual void Info(string message)
            {
                Console.WriteLine(message);
            }

            public virtual void Debug(string message)
            {
                Console.WriteLine(message);
            }
        }





    public class DevLogger:MainLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }

        public override void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public override void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }


    public class ReleaseLogger:MainLogger 
    {
        public override void Log(string message)
        {
            Console.WriteLine($"Please ... :{message}");
        }

        public override void Info(string message)
        {
            Console.WriteLine($"This is : {message}");
        }

        public override void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }


}
