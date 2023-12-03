namespace ClassLibrary
{
    public class Building
    {
        public string Address { get; set; }
        public string WallMaterial { get; set; }
        public int NumberOfFloors { get; set; }

        // Конструктор за замовчуванням
        public Building()
        {
            Address = "Невідома адреса";
            WallMaterial = "Невідомий матеріал стін";
            NumberOfFloors = 0;
        }

        // Конструктор з параметрами
        public Building(string address, string wallMaterial, int numberOfFloors)
        {
            Address = address;
            WallMaterial = wallMaterial;
            NumberOfFloors = numberOfFloors;
        }

        // Метод для зміни типу матеріалу стін
        public void ChangeWallMaterial(string newMaterial)
        {
            WallMaterial = newMaterial;
        }

        // Метод для зміни кількості поверхів
        public void ChangeNumberOfFloors(int newNumberOfFloors)
        {
            NumberOfFloors = newNumberOfFloors;
        }

        // Метод для виведення інформації про будинок
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Адреса: {Address}, Матеріал стін: {WallMaterial}, Кількість поверхів: {NumberOfFloors}");
        }
    }
}