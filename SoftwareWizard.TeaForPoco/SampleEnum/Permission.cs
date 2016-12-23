using System;

namespace SoftwareWizard.TeaForPoco.SampleEnum
{
    [Flags]
    public enum Permission : long
    {
        None = 0,

        ReadUsers = 1 << 1,
        WriteUsers = 1 << 2,

        ReadGlobalValues = 1 << 3,
        WriteGlobalValues = 1 << 4,

        Extreme = 1 << 5
    }
}
