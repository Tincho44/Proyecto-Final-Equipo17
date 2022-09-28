using System;
using System.Collections.Generic;

namespace Project
{
    class UserManager//Clase administradora de usuario
    {
        private List<User> UserList;
        private string name;
        private string surName;
        private int id;
        private Object User;
        private Object password;
        public string location;
        private string email;
        private int celular;
        public string TypeOfUser;
        
        //coloco los atributos privados que creia necesario para que no se modifiquen y le construyo los gets y sets para que se pueda acceder 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get 
            {
                return surname;
            }
            set 
            {
                surname = value;
            }
        }
        public int Id
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        public string Email
        {
            get 
            {
                return email;
            }
            set 
            {
                email = value;
            }
        }
        public int Celular
        {
            get 
            {
                return celular;
            }
            set 
            {
                celular = value;
            }
        }

        public void UserRegister ()
        {
            //metodo para registrar usuario 
        }
        public void UserDelete ()
        {
            //metodo para borrar usuario 
        }
        public void LoginUser ()
        {
            //metodo para loguear usuario 
        }
    }

}
