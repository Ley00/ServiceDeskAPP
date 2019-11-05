using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Model
{
    public class Token
    {
        public int Id { get; set; }
        public string acess_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }
        public Token() { }
    }
}
