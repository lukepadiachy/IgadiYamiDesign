using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Models.Carrot
{
    public class Carrot
    {
        [PrimaryKey, AutoIncrement]
        public int CarrotID { get; set; }
        public string SoilType { get; set; }
        public string WaterIntake { get; set; }
        public string TimeToPlant { get; set;}

        [ForeignKey(typeof(CarrotDiseases))]
        public List<CarrotDiseases> CarrotDisease { get; set; }
    }
}
