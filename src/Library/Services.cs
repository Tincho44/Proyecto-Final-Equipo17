using System;
using System.Collections.Generic;

namespace Project{

    public class Service{

        public List<Service> services;
        private string name;
        public int cost;
        private Administrator admin;


        public void AddService(Service service){

            this.services.Add(service);
        }

        public void ModifyService(Service service,int newCost, string newName){

            for (int i = 0 ; i < this.services.Count() ; i++){

                if ( this.services[i] == services){

                }
            }
        }

        public void DeleteService(Service service){

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