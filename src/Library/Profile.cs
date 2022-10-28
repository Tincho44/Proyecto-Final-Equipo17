using System;
using System.Collections.Generic;

namespace Project
{
    class Profile : User //Perfil visual de los usuarios que heredaría atributos de la clase user
    {
       /* //declaramos los atributos:
        private string name ;
        public string surname { get;set; } 
        
        public string location { get;set; }
        */
        public int reputation { get;set; }
        //metodo constructor:
        public Profile (string name,string surname,int identity, string email, string location, int reputation)
        {
            this.name = name;
            this.surname = surname;
            this.identity = identity;
            this.email = email;
            this.location = location;
            this.reputation = reputation;           
        }
        //en caso de que queramos hacer privado algún atributo privado por ejemplo name podria hacer esto: 
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public void GetInformation ()
        {
            //este método debería recolectar la info del perfil.

        }

        public void ShowProfile ()
        {
            //prepara el perfil para mostrarlo.

        }



    }
}