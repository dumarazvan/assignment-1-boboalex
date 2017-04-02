using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Classes
{
    class Client
    {
        private String firstName;
        private String lastName;
        private String address;
        private long personalNumericalCode;
        private String identityCardNumber;
        private List<Account> accounts;

        public Client()
        {

        }

        public Client(String firstName, String lastName, String address, long personalNumericalCode,
                      String identityCardNumber, List<Account> accounts)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.personalNumericalCode = personalNumericalCode;
            this.identityCardNumber = identityCardNumber;
            this.accounts = accounts;
        }

        public Client(String firstName, String lastName, long personalNumericalCode, String address,
                      String identityCardNumber)
        {
            this.personalNumericalCode = personalNumericalCode;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.identityCardNumber = identityCardNumber;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public long getPersonalNumericalCode()
        {
            return personalNumericalCode;
        }

        public void setPersonalNumericalCode(long personalNumericalCode)
        {
            this.personalNumericalCode = personalNumericalCode;
        }

        public String getIdentityCardNumber()
        {
            return identityCardNumber;
        }

        public void setIdentityCardNumber(String identityCardNumber)
        {
            this.identityCardNumber = identityCardNumber;
        }

        public List<Account> getAccounts()
        {
            return accounts;
        }

        public void setAccounts(List<Account> accounts)
        {
            this.accounts = accounts;
        }

        public String toString()
        {
            return "Client [firstName=" + firstName + ", lastName=" + lastName + ", address=" + address
                    + ", personalNumericalCode=" + personalNumericalCode + ", identityCardNumber=" + identityCardNumber
                    + ", accounts=" + accounts + "]";
        }

    }
}
