using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class User
    {
        private String username;
        private String password;
        private String fullName;
        private String isAdmin;

        public User(String username, String password, String fullName, String isAdmin)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.isAdmin = isAdmin;
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getFullName()
        {
            return fullName;
        }

        public void setFullName(String fullName)
        {
            this.fullName= fullName;
        }

        public String Admin()
        {
            return isAdmin;
        }

        public void setAdmin(String isAdmin)
        {
            this.isAdmin = isAdmin;
        }

        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User");
            sb.Append("{username='").Append(username).Append('\'');
            sb.Append(", password='").Append(password).Append('\'');
            sb.Append(", fullName='").Append(fullName).Append('\'');
            sb.Append(", isAdmin=").Append(isAdmin);
            sb.Append("}");
            return sb.ToString();

        }

    }
}
