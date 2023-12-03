using ClassLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Building> buildings = new List<Building>(); // Список будівель
        List<Fraction> allFractions = new List<Fraction>(); // Список об'єктів типу Fraction

        int choice;
        do
        {
            Console.WriteLine("Виберіть варіант:");
            Console.WriteLine("1. Створити будинок");
            Console.WriteLine("2. Створити житловий будинок");
            Console.WriteLine("3. Створити склад");
            Console.WriteLine("4. Створіть дріб");
            Console.WriteLine("4. Показати інформацію про всі будинки");
            Console.WriteLine("6. Працюємо з дробами");
            Console.WriteLine("7. Вихід");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введіть адресу будинку:");
                    string address = Console.ReadLine();
                    Console.WriteLine("Введіть матеріал стін:");
                    string wallMaterial = Console.ReadLine();
                    Console.WriteLine("Введіть кількість поверхів:");
                    int numberOfFloors = int.Parse(Console.ReadLine());

                    Building newBuilding = new Building(address, wallMaterial, numberOfFloors);
                    buildings.Add(newBuilding);
                    Console.WriteLine("Будинок створено.");
                    break;
                case 2:
                    Console.WriteLine("Введіть адресу житлового будинку:");
                    string apartmentAddress = Console.ReadLine();
                    Console.WriteLine("Введіть матеріал стін:");
                    string apartmentWallMaterial = Console.ReadLine();
                    Console.WriteLine("Введіть кількість поверхів:");
                    int apartmentNumberOfFloors = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть кількість квартир:");
                    int numberOfApartments = int.Parse(Console.ReadLine());

                    ApartmentBuilding newApartmentBuilding = new ApartmentBuilding(apartmentAddress, apartmentWallMaterial, apartmentNumberOfFloors, numberOfApartments);
                    buildings.Add(newApartmentBuilding);
                    Console.WriteLine("Житловий будинок створено.");
                    break;
                case 3:
                    Console.WriteLine("Введіть адресу складу:");
                    string warehouseAddress = Console.ReadLine();
                    Console.WriteLine("Введіть матеріал стін:");
                    string warehouseWallMaterial = Console.ReadLine();
                    Console.WriteLine("Введіть кількість поверхів:");
                    int warehouseNumberOfFloors = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть тип планування (відкритий/закритий/напівзакритий):");
                    string layoutType = Console.ReadLine();

                    Warehouse newWarehouse = new Warehouse(warehouseAddress, warehouseWallMaterial, warehouseNumberOfFloors, layoutType);
                    buildings.Add(newWarehouse);
                    Console.WriteLine("Склад створено.");
                    break;

                case 4:
                    Console.WriteLine("Введіть чисельник:");
                    int numerator = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть знаменник:");
                    int denominator = int.Parse(Console.ReadLine());

                    Fraction newFraction = new Fraction(numerator, denominator);
                    allFractions.Add(newFraction);
                    Console.WriteLine("Об'єкт «Дріб» створено.");
                    break;
                case 5:
                    // Логіка для виведення інформації про всі будинки
                    foreach (Building building in buildings)
                    {
                        building.ShowInfo();
                        Console.WriteLine();
                    }
                    break;


                case 6:
                    Console.WriteLine("Працюємо з дробами:");
                    Console.WriteLine("1. Додати дроби");
                    Console.WriteLine("2. Відняти дроби");
                    Console.WriteLine("3. Помножити дроби");
                    Console.WriteLine("4. Поділити дроби");
                    Console.WriteLine("5. Порівняти дроби");
                    Console.WriteLine("6. Показати всі дроби");
                    int fractionChoice = int.Parse(Console.ReadLine());

                    switch (fractionChoice)
                    {
                        case 1:
                            Console.WriteLine("Введіть чисельник першого дробу:");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник першого дробу:");
                            int denom1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть чисельник другого дробу:");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник другого дробу:");
                            int denom2 = int.Parse(Console.ReadLine());
                            Fraction fraction1 = new Fraction(num1, denom1);
                            Fraction fraction2 = new Fraction(num2, denom2);

                            Fraction sum = fraction1 + fraction2;
                            Console.WriteLine($"Сума дробів: {sum}");
                            break;

                        case 2:
                            Console.WriteLine("Введіть чисельник першого дробу:");
                            int subNum1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник першого дробу:");
                            int subDenom1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть чисельник другого дробу:");
                            int subNum2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник другого дробу:");
                            int subDenom2 = int.Parse(Console.ReadLine());
                            Fraction subtraction1 = new Fraction(subNum1, subDenom1);
                            Fraction subtraction2 = new Fraction(subNum2, subDenom2);

                            Fraction subtractedResult = subtraction1 - subtraction2;
                            Console.WriteLine($"Різниця дробів: {subtractedResult}");
                            break;

                        case 3:
                            // Код для множення дробів
                            Console.WriteLine("Введіть чисельник першого дробу:");
                            int multNum1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник першого дробу:");
                            int multDenom1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть чисельник другого дробу:");
                            int multNum2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник другого дробу:");
                            int multDenom2 = int.Parse(Console.ReadLine());

                            Fraction multiplication1 = new Fraction(multNum1, multDenom1);
                            Fraction multiplication2 = new Fraction(multNum2, multDenom2);

                            Fraction multipliedResult = multiplication1 * multiplication2;
                            Console.WriteLine($"Результат множення дробів: {multipliedResult}");
                            break;

                        case 4:
                            // Код для ділення дробів
                            Console.WriteLine("Введіть чисельник першого дробу:");
                            int divNum1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник першого дробу:");
                            int divDenom1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть чисельник другого дробу:");
                            int divNum2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник другого дробу:");
                            int divDenom2 = int.Parse(Console.ReadLine());
                            Fraction division1 = new Fraction(divNum1, divDenom1);
                            Fraction division2 = new Fraction(divNum2, divDenom2);

                            Fraction dividedResult = division1 / division2;
                            Console.WriteLine($"Результат ділення дробів: {dividedResult}");
                            break;

                        case 5:
                            // Код для порівняння дробів
                            Console.WriteLine("Введіть чисельник першого дробу:");
                            int compNum1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник першого дробу:");
                            int compDenom1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введіть чисельник другого дробу:");
                            int compNum2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введіть знаменник другого дробу:");
                            int compDenom2 = int.Parse(Console.ReadLine());
                            Fraction comparison1 = new Fraction(compNum1, compDenom1);
                            Fraction comparison2 = new Fraction(compNum2, compDenom2);

                            if (comparison1 == comparison2)
                                Console.WriteLine("Дроби рівні.");
                            else if (comparison1 > comparison2)
                                Console.WriteLine("Перший дріб більший за другий.");
                            else if (comparison1 < comparison2)
                                Console.WriteLine("Перший дріб менший за другий.");
                            break;

                        case 6:
                            Console.WriteLine("Всі дроби:");
                            foreach (var fraction in allFractions)
                            {
                                Console.WriteLine(fraction);
                            }
                            break;

                        default:
                            Console.WriteLine("Невірний вибір. Введіть правильний варіант.");
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("Вихід з програми...");
                    break;

                default:
                    Console.WriteLine("Неправильний вибір");
                    break;
            }
        } while (choice != 7);

    }

}