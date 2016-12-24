using System;
using System.Collections.Generic;
using SoftwareWizard.TeaForPoco.SampleEnum;

namespace SoftwareWizard.TeaForPoco.SampleDto
{
    public class UserDto : BaseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public bool IsMarried { get; set; }

        public int? ShoeSize { get; set; }

        public DateTime DateOfBirth { get; set; }

        public double Sallary { get; set; }

        public IList<Permission> Permissions { get; set; }

        public Language Language { get; set; }

        public UserRole UserRole { get; set; }
    }
}
