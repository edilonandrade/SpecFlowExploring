using System;

namespace SpecFlowAssistHelpers.Models
{
    public class Account
    {
        public string Name { get; set; } 
	    public DateTime Birthdate { get; set; }
	    public int HeightInInches { get; set; }
	    public float BankAccountBalance { get; set; }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
