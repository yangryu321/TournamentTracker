using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel //Name has been changed 
    {
        public int Id { get; set; } //ID of the member/person
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailaddress { get; set; }
        public string CellphoneNumber { get; set; }

        public string Fullname 
        { 
            get
            {
                return ($"{Firstname} {Lastname}");
            }
            
        }

        public PersonModel()
        {

        }

        public PersonModel(string firstname, string lastname, string emailaddress, string cellphoneNumber)
        {
            Firstname = firstname;
            Lastname = lastname;
            Emailaddress = emailaddress;
            CellphoneNumber = cellphoneNumber;
               
        }

    }
}
