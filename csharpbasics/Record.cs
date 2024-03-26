using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    public enum Gender
    {
        Male, 
        Female
    }
    public record User(string Name, string Surname, Gender Gender);
}
