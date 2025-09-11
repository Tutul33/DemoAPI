using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.FileManagement
{
    public class FileValidationException : Exception
    {
        public FileValidationException(string message) : base(message) { }
    }

}
