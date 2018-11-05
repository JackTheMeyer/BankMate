using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMate
{
    public class BankingSystem
    {
       
        private List<User> _userList = new List<User>();
        public BankingSystem()
        {
            
        }

        public void AddUser()
        {
            User dad = new User("Hello", "world");
            _userList.Add(dad);
        }
        public List<User> Users
        {
            get
            {
                return _userList;
            }
        }
       
    }
}
