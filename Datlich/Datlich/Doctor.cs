using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datlich
{
    public class Doctor
    {
        int id;
        string name;
        string price;
        string major;
        public static int cap = 1;
        public Doctor() { }
        public void setDoctor(Doctor d) {
            this.id = d.getID();
            this.name = d.getName();
            this.price = d.getPrice();
            this.major = d.getMajor();
        }
        public void setDoctor(int id, string name, string price, string major)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.major = major;
        }
        public int getID() {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getPrice()
        {
            return price;
        }
        public string getMajor()
        {
            return major;
        }
    }
}
