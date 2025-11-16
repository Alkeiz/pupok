using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message[] mes = { new Email(), new SMS(), new Message() };
            foreach (var me in mes) me.Send();
        }
    }
}
