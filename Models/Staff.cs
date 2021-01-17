using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pdsatracker.Models;

namespace pdsatracker.Models
{
    public class Staff
    {
        public string  Name { get; set; }
        public string Position { get; set; }
        public string StaffEmail { get; set; }
 
        public int Id { get; set; }
        public Staff()
        {

        }
        
        public Staff(string staff_name, string position, string staff_email)
        {
            Name = staff_name;
            Position = position;
            StaffEmail = staff_email;
        }
        
        public override string ToString()
        {
            return Name;
        }
        
    }
}
