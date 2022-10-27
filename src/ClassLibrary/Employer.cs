using System;
using System.Collections.Generic;

namespace Project
{
    /// <summary>
    /// 
    /// </summary>
    public class Employer : User
    {
         public Employer(string name, string surname, int identification, string email, string location, int cellphone) : base(name,surname,identification,email,location, cellphone)
        {
    
        }
        public void QualifyEmployee(Employee employee)
        {
          // Califica a un Employee
        }

        public void ContactEmployee(Services service)
        {
            // Se contacta a un employee por sus servicios
        }

    }
} 
