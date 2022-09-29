using System;
using System.Collections.Generic;

namespace Project
{
    public abstract class User//superclase usuario de las que heredan administrador, empleado y empleador
    {
    
        private  string name; 
        private  string surname;
        private  int identity;
        private  string email;
        private  string Location;

        // private List<string> Usuarios {get; set;} 
        // por el momento este atributo lo dejamos simplemente comentado, pero a futuro lo vamos a usar, no se si en esta clase u otra. 

    }

    public User (string name,string surname,string location)
        {
            this.name = name;
            this.surname = surname;
            this.location = location;
        }

    public string name
        {
            get { return name; }
        }

    public string GetName(string name)
        {
            get {return name} 
        }    
}
