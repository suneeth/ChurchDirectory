using System;
using System.Collections.Generic;
using STOCI.App;

namespace STOCI.App.DataService
{
    public interface IDataService
    {
        List<Contact> GetAllContacts();
    }

    public class DataService : IDataService
    {
        public List<Contact> GetAllContacts()
        {
            return new List<Contact>
        {
            new Contact {  FirstName = "James", LastName= "Norris",
                         PhoneNumber = "488-555-1212", NickName="J", FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                         Image="http://placebear.com/178/300",
                         Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", Zip = "92115" } },
            new Contact {  FirstName = "Mary",LastName= "Lamb", PhoneNumber = "337-555-1212",NickName="Little Lamp",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Image="http://placebear.com/184/193",
                          Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", Zip = "49245" } },
            new Contact { FirstName = "Robert",LastName="Shoemaker", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/222",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Danny",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/223",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Alex",LastName="Hunter", PhoneNumber ="732-425-5608",
                           Image="http://placebear.com/195/229",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Michael",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/227",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },

            new Contact {  FirstName = "Frank", LastName= "Norris",
                         PhoneNumber = "488-555-1212", NickName="J", FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                         Image="http://placebear.com/178/228",
                         Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", Zip = "92115" } },
            new Contact {  FirstName = "Bob",LastName= "Lamb", PhoneNumber = "337-555-1212",NickName="Little Lamp",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Image="http://placebear.com/184/193",
                          Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", Zip = "49245" } },
            new Contact { FirstName = "Cris",LastName="Shoemaker", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/222",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Edward",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/223",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "George",LastName="Hunter", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/229",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Hary",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/227",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },

              new Contact {  FirstName = "Ian", LastName= "Norris",
                         PhoneNumber = "488-555-1212", NickName="J", FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                         Image="http://placebear.com/178/228",
                         Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", Zip = "92115" } },
            new Contact {  FirstName = "Jacob",LastName= "Lamb", PhoneNumber = "337-555-1212",NickName="Little Lamp",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Image="http://placebear.com/184/193",
                          Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", Zip = "49245" } },
            new Contact { FirstName = "Kevin",LastName="Shoemaker", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/222",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Larry",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/223",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Ninan",LastName="Hunter", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/229",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Oommen",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/227",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },

                new Contact {  FirstName = "Peter", LastName= "Norris",
                         PhoneNumber = "488-555-1212", NickName="J", FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                         Image="http://placebear.com/178/228",
                         Address = new Address { Street = "4627 Sunset Ave", City = "San Diego", State = "CA", Zip = "92115" } },
            new Contact {  FirstName = "Suneeth",LastName= "Varghese", PhoneNumber = "337-555-1212",NickName="Little Lamp",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Image="http://placebear.com/184/193",
                          Address = new Address { Street = "1111 Industrial Way", City = "Dallas", State = "TX", Zip = "49245" } },
            new Contact { FirstName = "Tony",LastName="Shoemaker", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/222",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Ulahannan",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/223",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "Varghese",LastName="Hunter", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/229",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },
            new Contact { FirstName = "William",LastName="Williams", PhoneNumber ="732-425-5608",
                          Image="http://placebear.com/195/227",NickName="Bob",FamilyMembers= "Estrella Harrington,Cordell Garza,Chad Ballard" ,
                          Address = new Address { Street = "201 N Squirrel Rd", City = "Auburn Hills", State = "MI", Zip = "48326" } },



        };



        }
    }
}
