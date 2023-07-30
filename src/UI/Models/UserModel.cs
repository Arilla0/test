using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Models
{
    public class UserModel
    {
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
    }
}
