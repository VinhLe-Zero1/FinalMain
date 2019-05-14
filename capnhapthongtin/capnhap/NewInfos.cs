﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capnhap
{
    class NewInfos
    {
        private string personal_ID;
        private string phone;
        private string date_of_birth;
        private string email;
        private string hometown_addr;
        private string house_addr;
        public void addNewInfos(string personal_ID, string phone, string date_of_birth, string email, string hometown_addr, string house_addr)
        {
            this.personal_ID = personal_ID;
            this.phone = phone;
            this.date_of_birth = date_of_birth;
            this.email = email;
            this.hometown_addr = hometown_addr;
            this.house_addr = house_addr;
        }
        public string getPersonal_ID() { return this.personal_ID; }
        public string getPhone() { return this.phone; }
        public string getDate_of_birth() { return this.date_of_birth; }
        public string getEmail() { return this.email; }
        public string getHometown_addr() { return this.hometown_addr; }
        public string getHouse_addr() { return this.house_addr; }
    }
}
