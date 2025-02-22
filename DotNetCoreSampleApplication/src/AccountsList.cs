﻿using System.Collections.Generic;

namespace SampleApplication
{
    public class AccountsList
    {
        public int AvailableItems { get; set; }
        public List<Account> Items { get; set; }
    }

    public class Account
    {
        public string AccountId { get; set; }
        // add additional fields as needed to fully describe the account structure.

    }
}