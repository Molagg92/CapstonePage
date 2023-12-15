using System.Globalization;

namespace Capstone.Models
{
    public class CleaningLady
    {
        // Properties
        public string Name { get; set; }
        public int Phone { get; set; }

        // Constructor with two arguments
        public CleaningLady(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}