using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace salarie
{
    public class Departement
    {
        public Int32 DepartementId { get; set; }
        public String Description { get; set; }
        // Add Ville
        public String Ville { get; set; }
        public IList<Salarie> ListeSalarie { get; set; }
    }
}