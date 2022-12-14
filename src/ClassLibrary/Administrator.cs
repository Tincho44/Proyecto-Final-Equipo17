using System;
using System.Collections.Generic;

namespace Project
{

    /// <summary>
    /// Clase encagada del usuario tipo Admin (Hereda de User)
    /// </summary>
    public class Administrator : User
    {

        
        public Administrator(string name, string surname, int identity, string email, string location) : base(name,surname,identity,email,location)
        {
    
        }
        public void CreateCategories(Categories category) //da error por que falta crear la clase Categories
        {
            
        }

        /// <summary>
        /// // Admin remueve un servicio
        /// </summary>
        /// <param name="service"></param>
        public void RemoveService(Services service) // Lo mismo que categories, falta la clase Services
        {
            
        }

/// <summary>
/// El admin habla con el oferente para que no proponga servicios que no estan disponibles
/// </summary>
/// <param name="employee"></param>
        public void TalkToEmployee(Employee employee)
        {
    
        }
    }
}