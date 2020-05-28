using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _cityName;
        private string _mayor;
        private int _est;

        public List<Building> Buildings { get; set; }
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public City(string name, string mayor, int year)
        {
            _cityName = name;
            _mayor = mayor;
            _est = year;
            Buildings = new List<Building>();
        }

        public string GetCityName() => _cityName;
    }
}