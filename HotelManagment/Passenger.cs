using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment
{
    class Passenger
    {
        private string _firstName;
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = RemoveExtraSpace(value); }
        }

        private string _lastName;
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = RemoveExtraSpace(value); }
        }

        private double _nationalCode;
        public double nationalCode
        {
            set { if ((value.ToString()).Length == 10) _nationalCode = value; else throw new ExecutionEngineException("کد ملی نامعتبر است."); }
            get { return _nationalCode; }
        }

        private string _phoneNumber;
        public string phoneNumber
        {
            set { if (value.Length == 11 && value.StartsWith("0")) _phoneNumber = value; else throw new ExecutionEngineException("شماره تلفن نامعتبر است."); }
            get { return _phoneNumber; }
        }

        public string address;

        public string RemoveExtraSpace(string str)
        {
            if (str == null || str.Length == 0)
                return str;
            str = str.Trim();
            int startIndex = 0;
            int index = str.IndexOf(' ');
            while (index != -1)
            {
                while (index + 1 < str.Length && str[index + 1] == ' ')
                    str = str.Remove(index, 1);
                startIndex = index + 1;
                index = str.IndexOf(' ', startIndex);
            }
            return str;
        }
    }
}
