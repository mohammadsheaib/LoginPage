using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.EF
{
    public class AuthenticationEFDataManager
    {
        AppDbContext _context;

        public AuthenticationEFDataManager()
        {

        }
        //public AuthenticationEFDataManager(AppDbContext context)
        //{
        //    _context = context;
        //}

        public bool ValidateCredentials(string username, string password)
        {
            //var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            // return user != null;

            return username == "username" && password == "pass";
        }
    }
}
