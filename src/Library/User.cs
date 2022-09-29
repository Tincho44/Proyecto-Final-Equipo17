using System;
using System.Collections.Generic;

namespace Project
{
    public class User//superclase usuario de las que heredan administrador, empleado y empleador
    {
    
        protected string name; 
        private string surname;
        private  int identity;
        private  string email;
        private  string location;

        // private List<string> Usuarios {get; set;} 
        // por el momento este atributo lo dejamos simplemente comentado, pero a futuro lo vamos a usar, no se si en esta clase u otra. 

    public User (string name,string surname,int identity, string email, string location)
        {
            this.name = name;
            this.surname = surname;
            this.identity = identity;
            this.email = email;
            this.location = location;
        }

    public string Name{get{return this.name;}}
    public string Surname{get{return this.surname;}}
    public int Identity{get{return this.identity;}}
    public string Email{get{return this.email;}set{this.email = value;}}
    public string Location{get{return this.location;}set{this.location = value;}}

    // Seteamos setters y getters, para name, surname e identidad solo pusimos getters dado que no es necesario cambiarlos
    // Para la ubicacion y el email, que son datos cambiables, decidimos poner setters tambien

    }         
}
