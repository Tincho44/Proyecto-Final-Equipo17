using System;
using System.Collections.Generic;

namespace Project
{
    public abstract class User//superclase usuario de las que heredan administrador, empleado y empleador
    {
    
        protected string name; 
        private string surname;
        private  int identification;
        private  string email;
        private  string location;
        private int cellphone;

        // private List<string> Usuarios {get; set;} 
        // por el momento este atributo lo dejamos simplemente comentado, pero a futuro lo vamos a usar, no se si en esta clase u otra. 

    public abstract User (string name,string surname,int identification, string email, string location, int cellphone)
        {
            this.name = name;
            this.surname = surname;
            this.identification = identification;
            this.email = email;
            this.location = location;
            this.cellphone = cellphone;
        }

    public string Name{get{return this.name;}}
    public string Surname{get{return this.surname;}}
    public int Identification{get{return this.identification;}}
    public string Email{get{return this.email;}set{this.email = value;}}
    public string Location{get{return this.location;}set{this.location = value;}}
    public int Cellphone{get{return this.cellphone;}set{this.cellphone = value;}}

    // Seteamos setters y getters, para name, surname e identidad solo pusimos getters dado que no es necesario cambiarlos
    // Para la ubicacion, el email y el celular que son datos cambiables, decidimos poner setters también

    public User Reputation()
    {
        
    }

    }         
}
