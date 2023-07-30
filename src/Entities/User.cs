using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Psw { get; set; }
    }
}
