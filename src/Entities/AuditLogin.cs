using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AuditLogin
    {
        public int Id { get; set; }
        public DateTime ts { get; set; }
        public string Login { get; set; }
        public string Message { get; set; }
    }
}
