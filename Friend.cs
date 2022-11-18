using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V1UPGF;

namespace Friend
{
    internal class Friend
    {
        private string Firstame { get; set; }
        private string Lastname { get; set; }
        private string Email { get; set; }
        private Adress Adress { get; set; }
        public Friend(string firstame, string lastname, string email, Adress adress) 
        {
            this.Lastname = lastname;
            this.Firstame = firstame;
            this.Email = email;
            this.Adress = adress;
        }
        public override string ToString()
        {
            return Firstame + " " + Lastname + " " + Email + ". located att: " + Adress;
        }
        public static class Factory
        {
            

            public static Friend SetRandomFriend()
            {
                var choice = new Random();
                string[] firstnamearray = { "johan", "nicklas", "erik", "thomas", "ricardo" };
                string[] lastnamearray = { "johansson", "Eriksson", "Ricardosson", "thomasson" };
                string[] emailarray = { "@Gmail.com", "@Live.se", "@Hotmail.com" };

                string firstname = firstnamearray[choice.Next(firstnamearray.Length)];
                string lastname = lastnamearray[choice.Next(firstnamearray.Length-1)];
                string email = ($"{firstname}.{lastname}{emailarray[choice.Next(emailarray.Length)]}");

                //varför kunde jag inte hämta Adress direkt med var adress = Adress.Factory.CreateAdress utan att sätta properties?
                var friend = new Friend(firstname, lastname, email, Adress.Factory.CreateAdress());
                
               
                return friend;
            }
        }
    }
    
}
