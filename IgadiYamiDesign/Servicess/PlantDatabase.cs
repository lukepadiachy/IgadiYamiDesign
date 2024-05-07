using IgadiYamiDesign.Modelss.Carrot;
using IgadiYamiDesign.Modelss.Onion;
using IgadiYamiDesign.Modelss.Potato;
using IgadiYamiDesign.Modelss.Spinach;
using IgadiYamiDesign.Modelss.Tomato;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Servicess
{
    internal class PlantDatabase
    {
        private SQLiteConnection _dbConnection;
        public PlantDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Carrot>();
            _dbConnection.CreateTable<CarrotDisease>();
            _dbConnection.CreateTable<Onion>();
            _dbConnection.CreateTable<OnionDisease>();
            _dbConnection.CreateTable<Potato>();
            _dbConnection.CreateTable<PotatoDisease>();
            _dbConnection.CreateTable<Spinach>();
            _dbConnection.CreateTable<SpinachDisease>();
            _dbConnection.CreateTable<Tomato>();
            _dbConnection.CreateTable<TomatoDisease>();
            SeedDatabase();
        }
        public string GetDatabasePath()
        {
            string fileName = "profiledatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + fileName;
        }
        public void SeedDatabase()
        {
            // Carrot & Carrot Disease
            if (_dbConnection.Table<Carrot>().Count() == 0)
            {
                Carrot carrot = new Carrot()
                {
                    Name = "Carrot",
                    SoilType = "Test 1",
                    WaterIntake = "Test 2L",
                    SoilPrep = "Test 3 Prep",
                    TimeToPlant = "Test 4pm"
                };
                _dbConnection.Insert(carrot);
            }
            if (_dbConnection.Table<CarrotDisease>().Count() == 0)
            {
                List<CarrotDisease> carrotDiseases = new List<CarrotDisease>()
                {
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly",
                        DiseaseDescription = "Testing Disease",
                        DiseaseCauses = "Testing Causes",
                        DiseaseControlMessures = "Testing Control Measures"
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly 2",
                        DiseaseDescription = "Testing Disease 2",
                        DiseaseCauses = "Testing Causes 2",
                        DiseaseControlMessures = "Testing Control Measures 2"
                    },
                    new CarrotDisease()
                    {
                        DiseaseName = "Carrot Rust Fly 3",
                        DiseaseDescription = "Testing Disease 3",
                        DiseaseCauses = "Testing Causes 3",
                        DiseaseControlMessures = "Testing Control Measures 3"
                    }
                };
                _dbConnection.InsertAll(carrotDiseases);
            }
        }

        // Methods
        public Carrot GetCarrotInformation()
        {
            Carrot carrot = _dbConnection.Table<Carrot>().FirstOrDefault();
            return carrot;
        }
        public List<CarrotDisease> GetAllCarrotDiseases()
        {
            return _dbConnection.Table<CarrotDisease>().ToList();
        }
        public CarrotDisease GetCarrotDiseaseByName(string diseaseName)
        {
            CarrotDisease carrotDisease = _dbConnection.Table<CarrotDisease>().FirstOrDefault(d => d.DiseaseName == diseaseName);
            return carrotDisease;
        }
    }
}
