using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal class StandardUserBuilder : IUserBuilder
    {
        private User _user;
        private AddressValidator _addressValidator;
        private AgeValidator _ageValidator;
        private EmailValidator _emailValidator;
        private NameValidator _nameValidator;
        private PhoneValidator _phoneValidator;
        private MiddleNameValidator _middleNameValidator;
        public StandardUserBuilder()
        {
            _addressValidator = new AddressValidator();
            _ageValidator = new AgeValidator();
            _emailValidator = new EmailValidator();
            _nameValidator = new NameValidator();
            _phoneValidator = new PhoneValidator();
            _middleNameValidator = new MiddleNameValidator();
            Reset();
        }
        public IUserBuilder AddAddress(string? address)
        {
            if (_addressValidator.Validate(address))
            {
                _user.Address = address;
            }
            return this;
        }

        public IUserBuilder AddBirthday(DateTime? birthday)
        {
            if (_ageValidator.Validate(birthday))
            {
                _user.Birthday = birthday;
            }
            return this;
        }

        public IUserBuilder AddEmail(string? email)
        {
            if (_emailValidator.Validate(email))
            {
                _user.Email = email;
            }
            return this;
        }

        public IUserBuilder AddFirstName(string firstname)
        {
            if (_nameValidator.Validate(firstname))
            {
                _user.FirstName = firstname;
            }
            return this;
        }

        public IUserBuilder AddLastName(string lastName)
        {
            if (_nameValidator.Validate(lastName))
            {
                _user.LastName = lastName;
            }
            return this;
        }
        public IUserBuilder AddMiddleName(string? middlename)
        {
            if (_middleNameValidator.Validate(middlename))
            {
                _user.MiddleName = middlename;
            }
            return this;
        }

        public IUserBuilder AddPhone(string? phone)
        {
            if (_phoneValidator.Validate(phone))
            {
                _user.Phone = phone;
            }
            return this;
        }

        public IUserBuilder Reset()
        {
            _user = new User();
            return this;
        }

        public User Build()
        {
            var obj = _user;

            Reset();

            return obj;
        }

    }
}