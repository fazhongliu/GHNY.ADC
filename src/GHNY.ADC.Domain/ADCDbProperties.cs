using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHNY.ADC
{
    public static class ADCDbProperties
    {
        public static string DbTablePrefix { get; set; } = "ADC";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "ADC";

        public const string ConnectionBakStringName = "ADC_Bak";
    }
}
