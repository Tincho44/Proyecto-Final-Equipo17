using System;
using System.Collections.Generic;

namespace Project
 {

    public class Contract 
    {
        public Services service;
        public User user;

        public  Contract (Services service, User user)
        {
            this.service = service;
            this.user = user;
        }
    }
}