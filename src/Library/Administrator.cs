using System;
using System.Collections.Generic;

namespace Project
{
    public class Administrator : User
    {

        public void CreateCategories(Categories category) //da error por que falta crear la clase Categories
        {
            // Admin crea una categoria como dice la letra
        }

        public void RemoveService(Services service) // Lo mismo que categories, falta la clase Services
        {
            // Admin remueve un servicio
        }

        public void TalkToEmployee(Employee employee)
        {
            // El admin habla con el oferente para que no proponga servicios que no estan disponibles
        }
    }
}
