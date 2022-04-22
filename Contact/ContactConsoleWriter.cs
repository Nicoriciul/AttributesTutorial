using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Contact
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

       // [Obsolete("This will be removed in version 2", true)]
        public void Write()
        {
            WriteFirstName();
            WriteAge();

        }

        private void WriteFirstName()
        {
            WriteLine(_contact.FirstName);
        }

        private void WriteAge()
        {
            OutputDebugInfo();
            OutputExtraInfo();

            WriteLine(_contact.AgeInYears);
        }

        [Conditional("EXTRA")]
        private void OutputExtraInfo()
        {
            WriteLine("***EXTRA INFO***");
        }

        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            WriteLine("***DEBUG MODE***");
        }
    }
}
