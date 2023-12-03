using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // Похідний клас ApartmentBuilding (житловий будинок)
    public class ApartmentBuilding : Building
    {
        public int NumberOfApartments { get; set; }

        // Конструктор за замовчуванням
        public ApartmentBuilding() : base()
        {
            NumberOfApartments = 0;
        }

        // Конструктор з параметрами
        public ApartmentBuilding(string address, string wallMaterial, int numberOfFloors, int numberOfApartments) : base(address, wallMaterial, numberOfFloors)
        {
            NumberOfApartments = numberOfApartments;
        }

        // Метод для зміни кількості квартир
        public void ChangeNumberOfApartments(int newNumberOfApartments)
        {
            NumberOfApartments = newNumberOfApartments;
        }

        // Перевизначений метод для виведення інформації про житловий будинок
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість квартир: {NumberOfApartments}");
        }
    }

}
