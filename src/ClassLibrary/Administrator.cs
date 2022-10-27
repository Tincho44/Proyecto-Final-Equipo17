using System;
using System.Collections.Generic;

namespace Project
{

    /// <summary>
    /// Clase encagada del usuario tipo Admin (Hereda de User)
    /// </summary>
    public class Administrator : User
    {

        
        public Administrator(string name, string surname, int identification, string email, string location, int cellphone) : base(name,surname,identification,email,location, cellphone)
        {
    
        }
        public void AddCategories(Categories category) 
        {
            //Este método debe añadir nuevas categorías 
        }

        /// <summary>
        /// // Admin remueve un servicio
        /// </summary>
        /// <param name="service"></param>
        public void RemoveCategories(Categories category) 
        {
            //Debe eliminar categorías existentes
        }

/// <summary>
/// El admin habla con el oferente para que no proponga servicios que no estan disponibles
/// </summary>
/// 
        public void NotifyOfferer(Services service)// Puede ser que tenga como parámetro employee o ambos
        {
            //Este método debe eliminar un servicio y comunicarse con el empleador 
            //para transmitirle porqué se sugiere hacerle cambios al servicio
        }
    }
}