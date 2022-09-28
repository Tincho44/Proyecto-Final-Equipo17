using System;
using System.Collections.Generic;

namespace Project{


/// <summary>
/// 
/// </summary>
    public class Services{

        public List<Services> services;
        private string name;
        public int cost;
        private Administrator admin;


        public void AddService(Services service){

            this.services.Add(service);
        }

        public void ModifyService(Services service,int newCost, string newName){

            for (int i = 0 ; i < this.services.Count() ; i++){

                if ( this.services[i] == services){

                }
            }
        }

        public void DeleteService(Services service){

            for (int i = 0 ; i < this.services.Count() ; i++){

                if ( this.services[i] == services){

                    this.services.RemoveAt(i);

                }
            }
        }

        public void PriceService(int price){

            this.cost = price;
        }



    }
}