using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmRegister.Domain.Entities
{
    public class AuditEvent
    {
        string action;
        string date;
        Operators operators;
    }
}
