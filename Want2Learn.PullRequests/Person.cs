using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.PullRequests
{
    class Person
    {
        private string fullName;
        private DateTime birthday;

        public string GetFullName()
        {
            return fullName;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }


        public void SetFullName(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                return;
            }
            this.fullName = fullName;
        }

        public void SetBirthday(DateTime birthday)
        {
            if (birthday > DateTime.Now)
            {
                return;
            }
            this.birthday = birthday;
        }
    }
}
