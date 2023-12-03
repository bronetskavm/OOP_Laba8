using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // Похідний клас Warehouse (склад)
    public class Warehouse : Building
    {
        public string LayoutType { get; set; }

        // Конструктор за замовчуванням
        public Warehouse() : base()
        {
            LayoutType = "Невідомий тип планування";
        }

        // Конструктор з параметрами
        public Warehouse(string address, string wallMaterial, int numberOfFloors, string layoutType) : base(address, wallMaterial, numberOfFloors)
        {
            LayoutType = layoutType;
        }

        // Метод для зміни типу планування
        public void ChangeLayoutType(string newLayoutType)
        {
            LayoutType = newLayoutType;
        }

        // Перевизначений метод для виведення інформації про склад
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Тип планування: {LayoutType}");
        }
    }
}
