using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace salarie
{
    public class SalarieCRUD
    {
        SalarieContext cont = new SalarieContext();

        public void AddDepartement(Departement dep)
        {
            cont.Departements.Add(dep);
            cont.SaveChanges();
        }

        public Departement GetDepartement(String Description)
        {
            Departement dep = new Departement();
            dep = cont.Departements.Where(d => d.Description == Description).FirstOrDefault();
            return dep;
        }

        public void AddSalarie(Salarie Sal)
        {
            cont.Salaries.Add(Sal);
            cont.SaveChanges();
        }
        public void DelSalarie(Salarie Sal)
        {
            cont.Salaries.Remove(Sal);
            cont.SaveChanges();
        }
        public Salarie GetSalarie(String Prenom)
        {
            Salarie Sal = new Salarie();
            Sal = cont.Salaries.Where(s => s.Prenom == Prenom).FirstOrDefault();
            return Sal;
        }
    }
}