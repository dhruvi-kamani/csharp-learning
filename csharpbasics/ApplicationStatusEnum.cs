using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    public enum ApplicationStatus
    {
        Stopped,
        Starting,
        Running,
        Stopping =4, // if we assign value in between then following sequence will continue
        Inactive
    }
}
