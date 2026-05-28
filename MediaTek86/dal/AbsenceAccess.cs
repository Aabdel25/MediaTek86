using MediaTek86.bddManager;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour la table absence
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Objet d'accès à BddManager
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur : récupère l'instance unique d'Access
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// CU5 - Retourne toutes les absences d'un personnel.
        /// Effectue une jointure avec la table motif.
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel</param>
        /// <returns>liste des absences du personnel</returns>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select a.idpersonnel, a.datedebut, a.datefin, ";
                req += "m.idmotif, m.libelle ";
                req += "from absence a join motif m on a.idmotif = m.idmotif ";
                req += "where a.idpersonnel = @idpersonnel ";
                req += "order by a.datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", idpersonnel }
                };
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req, parameters);
                    foreach (object[] record in records)
                    {
                        Motif motif = new Motif((int)record[3], (string)record[4]);
                        lesAbsences.Add(new Absence(
                            (int)record[0],
                            Convert.ToDateTime(record[1]),
                            Convert.ToDateTime(record[2]),
                            motif
                        ));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// CU6 - Ajoute une nouvelle absence en base de données.
        /// Insère idpersonnel, datedebut, datefin et idmotif.
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Idpersonnel   },
                    { "@datedebut",   absence.Datedebut     },
                    { "@datefin",     absence.Datefin       },
                    { "@idmotif",     absence.Motif.Idmotif }
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
        /// CU7 - Modifie une absence existante en base de données.
        /// Met à jour la date de fin et le motif de l'absence.
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@datefin",     absence.Datefin       },
                    { "@idmotif",     absence.Motif.Idmotif },
                    { "@idpersonnel", absence.Idpersonnel   },
                    { "@datedebut",   absence.Datedebut     }
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
        /// CU8 - Supprime une absence en base de données.
        /// Identifie l'absence par sa clé primaire composite (idpersonnel, datedebut).
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Idpersonnel },
                    { "@datedebut",   absence.Datedebut   }
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