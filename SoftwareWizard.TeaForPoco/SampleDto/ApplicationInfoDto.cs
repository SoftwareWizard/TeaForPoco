using System.Collections.Generic;

namespace SoftwareWizard.TeaForPoco.SampleDto
{
    public class ApplicationInfoDto
    {
        public string Product { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public string Version { get; set; }

        public string Copyright { get; set; }

        public string Description { get; set; }

        public IList<UserSummaryDto> UserSummaryDtos { get; set; }
    }
}
