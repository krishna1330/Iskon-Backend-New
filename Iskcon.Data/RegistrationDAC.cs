using Iskcon.Business;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskcon.Data
{
    public class RegistrationDAC
    {
        public async Task<string> NewRegistrationAsync(IskconDbContext DbContext, RegisteredMembers registeredMember, IFormFile photo, IFormFile signature)
        {
            string photoPath = string.Empty;
            string signaturePath = string.Empty;

            photoPath = photo != null ? SaveImage(photo) : string.Empty;
            signaturePath = signature != null ? SaveImage(signature) : string.Empty;

            RegisteredMembers newRegistration = new RegisteredMembers
            {
                EnrollmentDate = DateTime.Now,
                FirstName = registeredMember.FirstName,
                LastName = registeredMember.LastName,
                DOB = registeredMember.DOB,
                Email = registeredMember.Email,
                Phone = registeredMember.Phone,
                Photo = photoPath,
                Signature = signaturePath,
                FatherName = registeredMember.FatherName,
                FatherDOB = registeredMember.FatherDOB,
                MotherName = registeredMember.MotherName,
                MotherDOB = registeredMember.MotherDOB,
                SpouseName = registeredMember.SpouseName,
                SpouseDOB = registeredMember.SpouseDOB,
                Child1_Name = registeredMember.Child1_Name,
                Child1_DOB = registeredMember.Child1_DOB,
                Child2_Name = registeredMember.Child2_Name,
                Child2_DOB = registeredMember.Child2_DOB,
                ResidenceDoorNumber = registeredMember.ResidenceDoorNumber,
                ResidenceStreet = registeredMember.ResidenceStreet,
                ResidenceLandmark = registeredMember.ResidenceLandmark,
                ResidenceDistrict = registeredMember.ResidenceDistrict,
                ResidencePincode = registeredMember.ResidencePincode,
                ResidenceState = registeredMember.ResidenceState,
                Occupation = registeredMember.Occupation,
                CompanyName = registeredMember.CompanyName,
                WorkDoorNumber = registeredMember.WorkDoorNumber,
                WorkStreet = registeredMember.WorkStreet,
                WorkLandmark = registeredMember?.WorkLandmark,
                WorkDistrict = registeredMember?.WorkDistrict,
                WorkPincode = registeredMember?.WorkPincode,
                WorkState = registeredMember?.WorkState
            };

            DbContext.RegisteredMembers.Add(newRegistration);
            await DbContext.SaveChangesAsync().ConfigureAwait(false);

            return "Successfully Registered.";
        }

        public string SaveImage(IFormFile thumbnail)
        {
            var imageName = $"{Guid.NewGuid()}_{thumbnail.FileName}";
            var filePath = Path.Combine("E:\\Projects\\Iskon-Backend\\Iskcon-Api\\Images", imageName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                thumbnail.CopyTo(stream);
            }

            return filePath;
        }
    }
}
