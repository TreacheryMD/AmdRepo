using System;

namespace NUnitTesting.Clients
{
    public enum GenderType { Male, Female }
    public class Person
    {
        public string FirstName { get; protected internal set; }
        public string LastName { get; protected internal set; }
        public DateTime BirthDateTime { get; protected internal set; }
        public string FiscalCode { get; protected internal set; }
        public GenderType Gender { get; protected internal set; }

        public Person(string firstName, string lastName, DateTime birthDateTime, string fiscalCode, GenderType gender)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentNullException(nameof(lastName));
            if (string.IsNullOrWhiteSpace(fiscalCode))  throw new ArgumentNullException(nameof(fiscalCode)); 
            if (birthDateTime < DateTime.Now.AddYears(-125))throw new Exception($"Invalid field:{nameof(birthDateTime)}");

            FirstName = firstName;
            LastName = lastName;
            BirthDateTime = birthDateTime;
            FiscalCode = fiscalCode;
            Gender = gender;
        }

        public Person()
        {
            FirstName = "NoFirstName";
            LastName = "NoLastName";
            BirthDateTime = DateTime.Now;
            FiscalCode = "0000000000000";
            Gender = GenderType.Male;
        }

        public override string ToString()
        {
            return $"{FirstName};{LastName};{BirthDateTime.ToShortDateString()};{FiscalCode};{Gender}";
        }
    }
}
