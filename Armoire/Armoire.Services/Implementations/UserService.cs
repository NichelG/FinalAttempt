using System;
using Armoire.Common;
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
                FirstName = vm.FirstnameRF,
                LastName = vm.LastnameRF,
                Username = vm.UsernameRF,
                Password = vm.PasswordRF,
                AccountStatus = "Active",
                Email = vm.EmailRF,
                Address = "Unknown",
                City = "Unknown",
                Phone = "Unknown",
                State = "Unknown",
                Zip = "Unknown",
                AccountType = 2,
                Image = vm.ImageRF,
                DateCreated = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow
            };
            _nhSession.Save(newUser);
        }
    }
}
