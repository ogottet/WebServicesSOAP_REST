using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UserManager
    {
        public static User GetUserById( int userId )
        {
            return UserDB.GetUserById( userId );
        }

        public static User GetUserByUsername( string username )
        {
            return UserDB.GetUserByUsername( username );
        }

        public static List<string> GetAllUsersData( string field )
        {
            return UserDB.GetAllUsersData( field );
        }

        public static List<User> GetAllUsers()
        {
            return UserDB.GetAllUsers();
        }

        public static List<Dictionary<string, object>> GetUsersTable()
        {
            return UserDB.GetUsersTable();
        }
    }
}
