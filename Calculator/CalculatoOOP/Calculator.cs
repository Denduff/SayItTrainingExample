using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoOOP
{
    public class Calculator
    {
        public float tal1 { get; set; }
        public float tal2 { get; set; }

        public Calculator()
        {

        }

        public void Addition()
        {
            SaveResult(tal1 + tal2);
        }

        public void Subtraction()
        {
            SaveResult(tal1 - tal2);
        }

        public void Multiplikation()
        {
            SaveResult(tal1 * tal2);
        }

        public int Division(int numerator, int denominator) //integer limitations
        {
            return numerator / denominator;
        }

        public void Division() // introduction to different number variables / kommatal 
        {
            SaveResult(tal1 / tal2);
        }

        private void SaveResult(float result)
        {
            GUI.Results.Add(result);
        }

    }
}
