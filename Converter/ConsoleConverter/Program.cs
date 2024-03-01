// See https://aka.ms/new-console-template for more information

using ConverterLib;

Manager cm = new Manager();
while (true)
{
    try
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Выберите физ.величину:");
        for (int i = 0; i < cm.GetPhysicValuesList().Count; i++)
        {
            Console.WriteLine($"{i + 1}) {cm.GetPhysicValuesList()[i]}");
        }
        int choice_physic_value = Convert.ToInt32(Console.ReadLine());
        string valueName = cm.GetPhysicValuesList()[choice_physic_value - 1];

        Console.WriteLine("----------------------");
        for (int i = 0; i < cm.GetPhysicValuesList().Count; i++)
        {
            if (i + 1 == choice_physic_value)
            {
                Console.WriteLine("Выберите исходную величину:");
                for (int j = 0; j < cm.GetMeasureList(cm.GetPhysicValuesList()[i]).Count; j++)
                {
                    Console.WriteLine($"{j + 1}) {cm.GetMeasureList(cm.GetPhysicValuesList()[i])[j]}");

                }
            }
        }
        int choice_measure_value1 = Convert.ToInt32(Console.ReadLine());
        string from = cm.GetMeasureList(cm.GetPhysicValuesList()[choice_physic_value - 1])[choice_measure_value1 - 1];

        Console.WriteLine("----------------------");
        for (int i = 0; i < cm.GetPhysicValuesList().Count; i++)
        {
            if (i + 1 == choice_physic_value)
            {
                Console.WriteLine("Выберите преобразованную величину:");
                for (int j = 0; j < cm.GetMeasureList(cm.GetPhysicValuesList()[i]).Count; j++)
                {
                    Console.WriteLine($"{j + 1}) {cm.GetMeasureList(cm.GetPhysicValuesList()[i])[j]}");

                }
            }
        }
        int choice_measure_value2 = Convert.ToInt32(Console.ReadLine());
        string to = cm.GetMeasureList(cm.GetPhysicValuesList()[choice_physic_value - 1])[choice_measure_value2 - 1];
        while (true)
        {
            try
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Введите число, которое нужно преобразовать: ");
                double num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Результат: {cm.GetConvertedValue(num, valueName, from, to)} {to}");
                break;
            }
            catch{
                Console.WriteLine("Введите число правильно!");
            }
        }
    }
    catch{
        Console.WriteLine();
        Console.WriteLine("Введите соответствующую цифру!");        

    }


}
