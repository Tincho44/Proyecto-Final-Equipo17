using System;
using System.Collections.Generic;

namespace Project {


/// <summary>
/// 
/// </summary>
    public class Categories {

        private List<Categories> categoriesList;
/// <summary>
/// Constructor
/// </summary>
        public Categories() {

            this.categoriesList = new List<Categories>();
        }

/// <summary>
/// Agrega una categoria dada a la lista de categorias
/// </summary>
/// <param name="cat"></param>
        public void AddCategories(Categories cat){

            this.categoriesList.Add(cat);                       
        }


/// <summary>
/// Modifica una categoria dada de la lista de categorias
/// </summary>
/// <param name="catMod"></param>
        public void ModifyCategorie(Categories catMod){

            for (int i = 0 ; i < this.categoriesList.Count ; i ++){

                if ( this.categoriesList[i] == catMod){
                }
            }
        }


/// <summary>
/// Elimina una categoria dada de la lista de categorias
/// </summary>
/// <param name="catDel"></param>
        public void DeleteCategorie(Categories catDel){

            for (int i = 0 ; i < this.categoriesList.Count ; i++){

                if ( this.categoriesList[i] == catDel){

                    this.categoriesList.RemoveAt(i);
                }
            }
        } 
    }
}