using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTL_CNPM
{
    class Benhan
    {
        int ID;
        string chuandoan;
        string dando;
        string donthuoc;
        public void addBenhan(int ID, string chuandoan, string dando, string donthuoc)
        {
            this.ID = ID;
            this.chuandoan = chuandoan;
            this.dando = dando;
            this.donthuoc = donthuoc;
        }
        public int getID() { return this.ID;}
        public string getChuandoan() { return this.chuandoan; }
        public string getDando() { return this.dando; }
        public string getDonthuoc() { return this.donthuoc; }

    }
}
