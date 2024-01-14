using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Provider : AuditableBaseEntity
    {
        public string NIT { get; set; }
        public string BusinessName { get; set; }
        public string Address  { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
    }
}