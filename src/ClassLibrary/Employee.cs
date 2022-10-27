using System;
using System.Collections.Generic;

namespace Project
{
    public class Employee : User
    {
       
        public Employee(string name, string surname, int identification, string email, string location, int cellphone) : base(name,surname,identification,email,location, cellphone)
        {
    
        }
        public void QualifyEmployer(Employer employer, Qualification calification)
        {
            // En este metodo el employee le da una calificacion a un employer
        }

        public void OfferService(Services service)
        {
            // En este metodo se busca que el employee pueda ofrecer alguno de sus servicios, agregando una vacante
            // en la clase servicios
        }
        public void AcceptService(Employer employer)
        {
            // En este metodo se busca que el employee pueda aceptar la solicitud de servicio del employer
            //tiene que ser capaz de ver la reputación del employer antes de aceptar o no
        }
    }
}
