using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    internal class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS Отправлено!");
        }
    }
}
