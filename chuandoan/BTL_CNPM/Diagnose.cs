using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_chuandoan
{
    class Symptom
    {
        private string symptom;
        public string setSymptom(string sym) { return this.symptom = sym; }
        public string getSymptom() { return this.symptom; }
    }
}
