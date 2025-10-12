using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Enums
{
    public static class QueTypeEnum
    {
        public enum QueType
        {
            MultipleChoice = 1,
            TrueFalse = 2,
            ShortAnswer = 3,
            FillInTheBlank = 4
        }
    }
}
