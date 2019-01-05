﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class Journal
    {
        public string JournalMessage = "Welcome to my Journal";
        private string journalPassword = "1234";
        private bool journalUnlocked = false;

        private JournalEntry entry = new JournalEntry();
        public JournalEntry Entry
        {
            get
            {
                if (journalUnlocked)
                    return entry;
                else
                    return null;
            }
        }
        public bool UnlockJournal(string password)
        {
            if (journalPassword == password)
            {
                journalUnlocked = true;
                return true;
            }
            else
                return false;
        }
        public void LockJournal()
        {
            journalUnlocked = false;
        }
    }
}