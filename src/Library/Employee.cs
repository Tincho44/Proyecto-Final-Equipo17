using System;
using System.Collections.Generic;

namespace Project
{
    public class Employee : User
    {

        public void CalificateEmployer(Employer employer, Qualification calification)
        {
            // En este metodo el employee le da una calificacion a un employer
        }

        public void OfferService(Services service)
        {
            // En este metodo se busca que el employee pueda ofrecer alguno de sus servicios, agregando una vacante
            // en la clase servicios
        }
    }
}
