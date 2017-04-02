using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Account
    {
        private long id;
        private String type;
        private long amountOfMoney;
        private DateTime dateOfCreation;
        private long personalNumericCode;
        public Account()
        {

        }

        public Account(long id, String type, long amountOfMoney, DateTime dateOfCreation, long personalNumericCode)
        {
            this.id = id;
            this.type = type;
            this.amountOfMoney = amountOfMoney;
            this.dateOfCreation = dateOfCreation;
            this.personalNumericCode = personalNumericCode;
        }

        public Account(String type, long amountOfMoney, DateTime dateOfCreation, long personalNumericCode)
        {
            this.type = type;
            this.amountOfMoney = amountOfMoney;
            this.dateOfCreation = dateOfCreation;
            this.personalNumericCode = personalNumericCode;
        }

        public String toString()
        {
            return "Account [id=" + id + ", type=" + type + ", amountOfMoney=" + amountOfMoney + ", dateOfCreation="
                    + dateOfCreation + ", personalNumericCode=" + personalNumericCode + "]";
        }

        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public long getAmountOfMoney()
        {
            return amountOfMoney;
        }

        public void setAmountOfMoney(long amountOfMoney)
        {
            this.amountOfMoney = amountOfMoney;
        }

        public DateTime getDateOfCreation()
        {
            return dateOfCreation;
        }

        public void setDateOfCreation(DateTime dateOfCreation)
        {
            this.dateOfCreation = dateOfCreation;
        }

        public long getPersonalNumericCode()
        {
            return personalNumericCode;
        }

        public void setPersonalNumericCode(long personalNumericCode)
        {
            this.personalNumericCode = personalNumericCode;
        }

    }
}
