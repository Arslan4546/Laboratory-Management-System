using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class laboratoryBussiness
    {

        public static void AddLaboratoryBussiness(laboratoryClass lb) { 
            laboratoryDB.AddLaboratoryDB(lb);
        }

        public static void DeleteLaboratoryBussiness(string equipmentId)
        {
            laboratoryDB.DeleteLaboratoryDB(equipmentId);
        }

        public static laboratoryClass GetLaboratoryDetails(string equipmentId)
        {
            return laboratoryDB.GetLaboratoryDetailsDB(equipmentId);
        }

        public static void UpdateLaboratoryBussiness(laboratoryClass lb)
        {
            laboratoryDB.UpdateLaboratoryDB(lb);
        }


    }
}
