using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FridgeTracker
{
// This is for later login functionality 
    class UserAccount
    {
        #region Properties
        public int UserID { get; set; }

        public string EmailAddress { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsLockedOut { get; set; }

        public int NumberOfBadAttemptsLeft { get; set; }

        public DateTime LastSuccessfulLoginDateTime { get; set; }
        #endregion

        #region Constructors
        public UserAccount(string emailAddress, string userName, string name, string password, bool isLockedOut)
        {
            EmailAddress = emailAddress;
            UserName = userName;
            Name = name;
            Password = password;
            IsLockedOut = isLockedOut;
            NumberOfBadAttemptsLeft = 5;
        }
        #endregion
    }
}
