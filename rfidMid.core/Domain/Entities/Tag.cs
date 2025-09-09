using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rfidMid.core.Domain.Entities
{
    public class Tag
    {
        public string Id { get; set; }=string.Empty;
        public DateTime Timestamp { get; set; }=DateTime.Now;

    }
}
