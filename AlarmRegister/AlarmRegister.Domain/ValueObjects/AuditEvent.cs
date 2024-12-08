using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmRegister.Domain.Entities
{
    public class AuditEvent
    {
        string action { get; set; }
        string date;
        Operators operators;
    }
}
