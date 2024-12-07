using AlarmRegister.Domain.Types;
using AlarmRegister.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmRegister.Domain.Entities
{
    public class Alarm
    {
        public string OcurrenceDate;
        public RecoveryDate a;
        public Priority type_priority;
        public float OutRange;
        public Var var;
        public bool isactive() { }
    }
}
