using System.ComponentModel.DataAnnotations;
using StudentsManagementShared.Models;

namespace StudentsManagementBlazor.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string RegistrationNo { get; set; }
        public /*required*/ string FirstName { get; set; }
        public /*required*/ string MiddleName { get; set; }
        public /*required*/ string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public /*required*/ string EmailAddress { get; set; }
        public /*required*/ string Address { get; set; }
        public /*required*/ string PhoneNumber { get; set; }
        public int CountryId { get; set; }
        //public /*required*/ string Country { get; set; }
        public Country Country { get; set; }
        public int GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
