using Microsoft.VisualStudio.TestTools.UnitTesting;
using salarie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace salarie.Tests
{
    [TestClass()]
    public class SalarieCRUDTests
    {
        [TestMethod()]
        public void AddSalarieTest()
        {
            SalarieCRUD SalCrud = new SalarieCRUD();
            // Ajout Departement
            Departement NewDep = new Departement();
            NewDep.Description = "RH";
            NewDep.Ville = "Casablanca";
            SalCrud.AddDepartement(NewDep);
            // Ajout Salarie
            Salarie NewSalarie = new Salarie();
            NewSalarie.Nom = "Nom";
            NewSalarie.Prenom = "Prenom";
            NewSalarie.Fonctione = "Fonction";
            NewSalarie.DepartementId = SalCrud.GetDepartement("RH").DepartementId;
            SalCrud.AddSalarie(NewSalarie);

            //Verification Salarie
            Salarie SalFind = SalCrud.GetSalarie("Prenom");
            Assert.AreEqual(SalFind.Nom.ToString(), "Nom");

            //Suppression Salarie et Departement
            SalCrud.DelSalarie(NewSalarie);
        }
    }
}