using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADACHA1.Models
{
    internal class Country
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public int Population { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Страна - {Name}")
                .AppendLine($"Площадь - {Area}")
                .AppendLine($"Население - {Population}")
                .ToString();
        }
    }
}
