using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend
{
    internal class Friend
    {
        public string Firstame { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Friend(string firstame, string lastname, string email)
        {

        }

        public static class Factory 
        {
            public static Friend SetRandomFriend()
            {

            }
        }
    }
    
}
