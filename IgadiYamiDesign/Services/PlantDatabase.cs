using IgadiYamiDesign.Models.Carrot;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgadiYamiDesign.Services
{
    internal class PlantDatabase
    {
        private SQLiteConnection _dbConnection;

        public void ProfileDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());
            _dbConnection.CreateTable<Carrot>();
            _dbConnection.CreateTable<CarrotDiseases>();
            _dbConnection.CreateTable<DiseaseDescription>();
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
            // Carrot Information
            if (_dbConnection.Table<Carrot>().Count() == 0)
            {
                Carrot carrot = new Carrot()
                {
                    SoilType = "Test 1",
                    WaterIntake = "Test 2L",
                    TimeToPlant = "Test 3pm",
                };
                _dbConnection.Insert(carrot);
            }

            if (_dbConnection.Table<CarrotDiseases>().Count() == 0)
            {
                CarrotDiseases carrotDiseases = new CarrotDiseases()
                {
                    CarrotRustFly = 'Carrot Rust Fly';
                };
            }
        }
    }
}
