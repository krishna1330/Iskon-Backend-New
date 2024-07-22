using System.ComponentModel.DataAnnotations;

namespace Iskcon.Business
{
    public class RegisteredMembers
    {
        [Key]
        public int? PatronshipNumber { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Photo { get; set; }
        public string? Signature { get; set; }
        public string? FatherName { get; set; }
        public DateTime? FatherDOB { get; set; }
        public string? MotherName { get; set; }
        public DateTime? MotherDOB { get; set; }
        public string? SpouseName { get; set; }
        public DateTime? SpouseDOB { get; set; }
        public string? Child1_Name { get; set; }
        public DateTime? Child1_DOB { get; set; }
        public string? Child2_Name { get; set; }
        public DateTime? Child2_DOB { get; set; }
        public string? ResidenceDoorNumber { get; set; }
        public string? ResidenceStreet { get; set; }
        public string? ResidenceLandmark { get; set; }
        public string? ResidenceDistrict { get; set; }
        public string? ResidencePincode { get; set; }
        public string? ResidenceState { get; set; }
        public string? Occupation { get; set; }
        public string? CompanyName { get; set; }
        public string? WorkDoorNumber { get; set; }
        public string? WorkStreet { get; set; }
        public string? WorkLandmark { get; set; }
        public string? WorkDistrict { get; set; }
        public string? WorkPincode { get; set; }
        public string? WorkState { get; set; }
    }
}
