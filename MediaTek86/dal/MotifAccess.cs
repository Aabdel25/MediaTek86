using MediaTek86.bddManager;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour la table motif
    /// </summary>
    public class MotifAccess
    {
        /// <summary>
        /// Objet d'accès à BddManager
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'Access
        /// </summary>
        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Retourne la liste de tous les motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "select idmotif, libelle from motif order by libelle;";
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);
                    foreach (object[] record in records)
                    {
                        lesMotifs.Add(new Motif((int)record[0], (string)record[1]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }
    }
}