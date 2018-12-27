using System;
using System.Collections.Generic;

namespace STOCI.App
{
   

    public class Address
    {
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }


        public  override string ToString()
        {
           return $"{Street} \n{City},{State},{Zip}";
        }
    }

    public class Contact
    {
        private string _fullName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FamilyMembers { get; set; }
        public string NickName { get; set; }

        public string FullName { get => $"{FirstName} {LastName}";  }

        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public string Image { get; set; }
    }
}
