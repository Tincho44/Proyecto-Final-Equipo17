using System;
using System.Collections.Generic;

namespace Project{


/// <summary>
/// Clase encargada de gestionar los servicios
/// </summary>
    public class Services{

        /// <summary>
        /// Lista de todos los servicios
        /// </summary>
        public List<Services> services;
        private string name;
        /// <summary>
        /// Costo del servicio
        /// </summary>
        public int cost;
        private Administrator admin;

/// <summary>
/// Agrega un servicio a la lista Servicios
/// </summary>
/// <param name="service"></param>
        public void AddService(Services service){

            this.services.Add(service);
        }

/// <summary>
/// Modifica un servicio de la lista Servicios
/// </summary>
/// <param name="service"></param>
/// <param name="newCost"></param>
/// <param name="newName"></param>
        public void ModifyService(Services service,int newCost, string newName){

            for (int i = 0 ; i < this.services.Count  ; i++){

                if ( this.services[i] == service){

                }
            }
        }

/// <summary>
/// Borra un servicio de la lista de servicios
/// </summary>
/// <param name="service"></param>
        public void DeleteService(Services service){

            for (int i = 0 ; i < this.services.Count ; i++){

                if ( this.services[i] == service){

                    this.services.RemoveAt(i);

                }
            }
        }

/// <summary>
/// Cambia el costo del costo de este objeto
/// </summary>
/// <param name="price"></param>
        public void PriceService(int price){

            this.cost = price;
        }
    }
}