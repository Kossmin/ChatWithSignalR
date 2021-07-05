using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Message
    {
        public string chatterName { get; set; }
        public string content { get; set; }
        public DateTime sendAt { get; set; }
    }
}
