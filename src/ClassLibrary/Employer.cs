using System;
using System.Collections.Generic;

namespace Project
{
    /// <summary>
    /// 
    /// </summary>
    public class Employer : User
    {
         public Employer(string name, string surname, int identity, string email, string location) : base(name,surname,identity,email,location)
        {
    
        }
        public void CalificateEmployee(Employee employee)
        {
          // Califica a un Employee
        }

        public void ContactEmployee(Employee employee)
        {
            // Se contacta a un employee por sus servicios
        }

    }
} 
