using MediaTek86.bddManager;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour la table service
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Objet d'accès à BddManager
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'Access
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Retourne la liste de tous les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select idservice, nom from service order by nom;";
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);
                    foreach (object[] record in records)
                    {
                        lesServices.Add(new Service((int)record[0], (string)record[1]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}