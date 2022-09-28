using System;
using System.Collections.Generic;

namespace Project {


/// <summary>
/// 
/// </summary>
    public class Categories {

        private List<Categories> categoriesList;

        public Categories() {

            this.categoriesList = new List<Categories>();
        }

        public void AddCategories(Categories cat){

            this.categoriesList.Add(cat);                       
        }

        public void ModifyCategorie(Categories catMod, ){

            for (int i = 0 ; i < this.categoriesList.GetRange() ; i ++){

                if ( this.categoriesList[i] == catMod){
                }
            }
        }

        public void DeleteCategorie(Categories catDel){

            for (int i = 0 ; i < (this.categoriesList<Categories>.Count()) ; i++){

                if ( this.categoriesList[i] == catDel){

                    this.categoriesList.RemoveAt(i);
                }
            }
        } 
    }
}