using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capnhap
{
    class NewInfos
    {
        private string phone;
        private string email;
        private string hometown_addr;
        private string house_addr;
        public void addNewInfos( string phone, string email, string hometown_addr, string house_addr)
        {
            this.phone = phone;
            this.email = email;
            this.hometown_addr = hometown_addr;
            this.house_addr = house_addr;
        }
        public string getPhone() { return this.phone; }
        public string getEmail() { return this.email; }
        public string getHometown_addr() { return this.hometown_addr; }
        public string getHouse_addr() { return this.house_addr; }
    }
}
