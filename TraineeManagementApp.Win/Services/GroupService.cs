using AppGestionStagiaires.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGestionStagiaires.Services
{
    public class GroupsService
    {
        private static List<Group> Data_Groups = new List<Group>();

        static GroupsService() {
            Data_Groups.Add(new Group(1, "Madani"));
            Data_Groups.Add(new Group(2,"Chami"));
        }

        /// <summary>
        /// Add new Group
        /// </summary>
        /// <param name="g"> le Groupe à ajouter</param>
        public void Add(Group g) {
            Data_Groups.Add(g);
        }

        /// <summary>
        /// Supprimer un groupe par Id
        /// </summary>
        /// <param name="id"> Id de groupe à supprimer</param>
        public void Delete(int id) {

            Group g = null;
            foreach (var item in Data_Groups)
            {
                if (item.Id == id) {
                    // Exception : on ne peut pas supprimer un objet de la List en utilisant la boucle foreach
                    g = item;
                }
            }
            Data_Groups.Remove(g);
        }

        /// <summary>
        /// Mise à jour un objet Groupe
        /// </summary>
        /// <param name="g">un objet de type groupe contenant les information à mettre à jour</param>
        public void Update(Group g) {
            foreach (var item in Data_Groups)
            {
                if (item.Id == g.Id)
                {
                    item.Nom = g.Nom;
                }
            }
        }
        /// <summary>
        /// Retourne la liste des groupes à afficher
        /// </summary>
        /// <returns></returns>
        public List<Group> FindAll() {
            return Data_Groups;
        }
    }
}
