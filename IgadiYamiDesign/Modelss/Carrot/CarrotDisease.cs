﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Modelss.Carrot
{
    public class CarrotDisease
    {
        [PrimaryKey, AutoIncrement]
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public string DiseaseCauses { get; set; }
        public string DiseaseControlMessures { get; set; }
    }
}
