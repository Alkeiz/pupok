using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Frequency { get; set; }

        public Magazine(string title, string publisher, int year, int issueNumber, string frequency)
            : base(title, publisher, year)
        {
            IssueNumber = issueNumber;
            Frequency = frequency;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Журнал, Номер: {IssueNumber}, Периодичность: {Frequency}");
        }
    }
}
