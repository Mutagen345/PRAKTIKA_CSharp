namespace Organization
{
    class Organization
    {
        string name;
        int index;
        string countryName;
        string cityName;
        string streetName;
        int houseNumber;
        int telephone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Name incorrect!");
                else
                    name = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Index incorrect!");
                else
                    index = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Country name incorrect!");
                else
                    countryName = value;
            }
        }

        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("City name incorrect!");
                else
                    cityName = value;
            }
        }

        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Street name incorrect!");
                else
                    streetName = value;
            }
        }

        public int HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                if (value == 0)
                    throw new Exception("House Number incorrect!");
                else
                    houseNumber = value;
            }
        }

        public int Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Telephone incorrect!");
                else
                    telephone = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Organization organization = new Organization();
                    Console.WriteLine("Название вашей организации:");
                    organization.Name = Console.ReadLine();
                    Console.WriteLine("Почтовый индекс вашей организации: ");
                    organization.Index = int.Parse(Console.ReadLine());
                    Console.WriteLine("В каком стране находитсяваша организация:");
                    organization.CountryName = Console.ReadLine();
                    Console.WriteLine("В каком городе она находится?");
                    organization.CityName = Console.ReadLine();
                    Console.WriteLine("Укажите на какой улице находится ваша организация:");
                    organization.StreetName = Console.ReadLine();
                    Console.WriteLine("Укажите номер дома:");
                    organization.HouseNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите номер телефона (без '375-29'):");
                    organization.Telephone = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ваша организация: \n");
                    Console.WriteLine("Название: " + organization.Name);
                    Console.WriteLine("Почтовый индекс: " + organization.Index);
                    Console.WriteLine("Страна: " + organization.CountryName);
                    Console.WriteLine("Город: " + organization.CityName);
                    Console.WriteLine("Улица, дом: " + organization.StreetName + ", " + organization.HouseNumber);
                    Console.WriteLine("Номер телефона (без '375-29'): " + organization.Telephone);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка в входных данных. Нажмите enter для повторного ввода");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                break;
            }
        }
    }
}