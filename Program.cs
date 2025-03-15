using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstVariableWithoutMeaning = 127;
            short secondVariableWithoutMeaning = short.MaxValue;
            int thirdVariableWithoutMeaning = -2147483648;
            long fourthVariableWithoutMeaning = long.MinValue;
            float fifthVariableWithoutMeaning = 0.0f;
            double sixthVariableWithoutMeaning = 0.0;
            bool seventhVariableWithoutMeaning = Convert.ToBoolean(1);
            uint eighthVariableWithoutMeaning = 4294967295;
            String tenthVariableExplanation = "Пробую класс, просто для теста";
            Program programmInstance = new Program();
        }
    }
}
