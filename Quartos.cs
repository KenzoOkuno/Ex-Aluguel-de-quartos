
using System.Globalization;

namespace PrimeiroProjetos
{
    internal class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Quartos(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }


    }

}
