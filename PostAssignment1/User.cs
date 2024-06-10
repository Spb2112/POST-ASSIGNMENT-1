using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostAssignment1
{
    public class User : BaseEntity
    {

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

       
    }
}
