using System.Diagnostics;
namespace Contact
{
    internal class ContactDebugDisplay
    {
        private readonly Contact _contact;
        public ContactDebugDisplay(Contact contact)
        {
            _contact = contact;
        }

        public string UpperNmae => _contact.FirstName.ToUpperInvariant();

        public string AgeInHex => _contact.AgeInYears.ToString("X");
    }
}