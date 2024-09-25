using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cargo : EntityBase
    {
        public string Title { get; set; }
        public int Weight { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
