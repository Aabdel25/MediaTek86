using MediaTek86.bddManager;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour la table personnel
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Objet d'accès à BddManager
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'Access
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Retourne la liste de tous les personnels avec leur service
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, ";
                req += "s.idservice, s.nom as nomservice ";
                req += "from personnel p join service s on p.idservice = s.idservice ";
                req += "order by p.nom, p.prenom;";
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);
                    foreach (object[] record in records)
                    {
                        Service service = new Service((int)record[5], (string)record[6]);
                        Personnel personnel = new Personnel(
                            (int)record[0],
                            (string)record[1],
                            (string)record[2],
                            (string)record[3],
                            (string)record[4],
                            service
                        );
                        lesPersonnels.Add(personnel);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        /// <summary>
        /// CU2 - Ajoute un nouveau personnel en base de données.
        /// Insère nom, prénom, tel, mail et service du personnel.
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom",       personnel.Nom               },
                    { "@prenom",    personnel.Prenom            },
                    { "@tel",       personnel.Tel               },
                    { "@mail",      personnel.Mail              },
                    { "@idservice", personnel.Service.Idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Modifie un personnel en base
        /// </summary>
        /// <param name="personnel">personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, ";
                req += "tel = @tel, mail = @mail, idservice = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom",         personnel.Nom               },
                    { "@prenom",      personnel.Prenom            },
                    { "@tel",         personnel.Tel               },
                    { "@mail",        personnel.Mail              },
                    { "@idservice",   personnel.Service.Idservice },
                    { "@idpersonnel", personnel.Idpersonnel       }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Supprime un personnel en base
        /// </summary>
        /// <param name="personnel">personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}