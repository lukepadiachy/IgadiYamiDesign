using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Models.Carrot
{
    public class CarrotDiseases
    {
        [PrimaryKey, AutoIncrement]
        public string CarrotRustFly { get; set; }
        public string AlternariaLateBlight { get; set; }
        public string SclerotinaRot { get; set; }
        public string RootKnotNemotodes { get; set; }
        public string BacterialSoftRot { get; set; }

        [ForeignKey(typeof(DiseaseDescription))]
        public string Causes { get; set; }
        public string ControlMeasures { get; set; }
    }
}
