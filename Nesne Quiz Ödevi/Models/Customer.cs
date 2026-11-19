using System;

namespace Nesne_Quiz_Odevi.Models
{
    public class Customer
    {
        // 1. Private alanlar (Gizli kutularımız)
        // 1. Private alanlar (Gizli kutularımız)
        private int _id;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _phone = string.Empty;
        private string _licenseNumber = string.Empty;

        // 2. Property yapıları (Kutulara güvenli ulaşım yolları)
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set { _licenseNumber = value; }
        }

        // 3. Constructor (Müşteri oluşturma makinemiz)
        public Customer(int id, string firstName, string lastName, string phone, string licenseNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            LicenseNumber = licenseNumber;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}