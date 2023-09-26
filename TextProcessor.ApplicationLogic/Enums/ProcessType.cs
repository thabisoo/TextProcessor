using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor.ApplicationLogic.Enums
{
    public enum ProcessType
    {
        [Description("0")]
        INVALID_OPERATION = 0,

        [Description("1")]
        DUPLICATE_CHECKER = 1,

        [Description("2")]
        VOWEL_COUNTER = 2,

        [Description("3")]
        VOWEL_VERSUS_NON_VOWEL = 3

    }
}
