using System;
using System.Collections.Generic;
using System.Linq;
using Armoire.Common;
using Armoire.Common.ViewModels;
using Armoire.Entities;
using NHibernate;

namespace Armoire.Services
{
    public class UserService: IUserService
    {
        private readonly ISession _nhSession;

        public UserService(ISession nhSession)
        {
            _nhSession = nhSession;
        }

        public void Register(RegisterViewModel vm)
        {
            var newUser = new Patron()
            {
                FirstName = vm.Firstname,
                LastName = vm.Lastname,
                Username = vm.Username,
                Password = vm.Password,
                AccountStatus = "Active",
                Email = vm.Email,
                Address = "Unknown",
                City = "Unknown",
                Phone = "Unknown",
                State = "Unknown",
                Zip = "Unknown",
                AccountType = "User",
                Image = vm.Image,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            };
            _nhSession.Save(newUser);
        }

        //Checks login credentials
        public bool IsUser(LoginViewModel lm)
        {
            List<Patron> User = new List<Patron>();

            User = _nhSession.Query<Patron>().Where(x => x.Username == lm.Username).ToList();

            if (User.Count > 0)
            {
                foreach (var items in User)
                {
                    if (lm.Username == items.Username && lm.Password == items.Password)
                    {

                        return true;
                    }

                }

            }
            return false;

        }
    }
}
