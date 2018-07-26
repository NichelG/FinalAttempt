using Armoire.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Armoire.Common
{
    public interface IUserService
    {
        void Register(RegisterViewModel vm);
        bool IsUser(LoginViewModel lm);
    }
}
