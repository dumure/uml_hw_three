using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal interface IUserBuilder
    {
        public IUserBuilder AddFirstName(string firstname);
        public IUserBuilder AddLastName(string lastName);
        public IUserBuilder AddMiddleName(string? middlename);
        public IUserBuilder AddBirthday(DateTime? birthday);
        public IUserBuilder AddPhone(string? phone);
        public IUserBuilder AddEmail(string? email);
        public IUserBuilder AddAddress(string? address);
        public IUserBuilder Reset();
        public User Build();
    }
}
