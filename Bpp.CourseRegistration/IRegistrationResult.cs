using System;
using System.Collections.Generic;
using System.Text;

namespace Bpp.CourseRegistration
{
    public interface IRegistrationResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
