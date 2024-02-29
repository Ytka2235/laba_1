internal class Program
{
    private static void Main(string[] args)
    {
        // 1
        ProductionWorker worker = new ProductionWorker();
        Console.WriteLine("Введите имя");
        worker.setName(Console.ReadLine());
        Console.WriteLine("Введите номер");
        worker.setNember(Console.ReadLine());
        Console.WriteLine("Введите смену");
        worker.setShiftNumber(int.Parse(Console.ReadLine()));
        Console.WriteLine("Введите ставку");
        worker.setStake(Console.ReadLine());
        Console.WriteLine("Имя: " + worker.getName() + "\nНомер: " + worker.getNember() + "\nСмена: " + worker.getShiftNumber() + "\nСтавка: " + worker.getStake());
        // 2
        ShiftSupervisor chief = new ShiftSupervisor();
        Console.WriteLine("Введите имя");
        chief.setName(Console.ReadLine());
        Console.WriteLine("Введите номер");
        chief.setNember(Console.ReadLine());
        Console.WriteLine("Введите годовой оклад");
        chief.setSalary(int.Parse(Console.ReadLine()));
        Console.WriteLine("Введите премию");
        chief.setPrize(int.Parse(Console.ReadLine()));
        Console.WriteLine("Имя: " + chief.getName() + "\nНомер: " + chief.getNember() + "\nГодовой оклад: " + chief.getSalary() + "\nПремия: " + chief.getPrize());
        // 3
        Client client = new Client();
        Console.WriteLine("Введите имя");
        client.Name = Console.ReadLine();
        Console.WriteLine("Введите id");
        client.Id = Console.ReadLine();
        Console.WriteLine("Введите адресс");
        client.Address = Console.ReadLine();
        Console.WriteLine("Введите номер телефона");
        client.Nember = Console.ReadLine();
        Console.WriteLine("Введите согласие на рассылку");
        client.Mailing = bool.Parse(Console.ReadLine());
        Console.WriteLine("Имя: " + client.Nember + "\nId: " + client.Id +
            "\nАдресс: " + client.Address + "\nНомер телефона: " + client.Nember + "\nСогласие на рассылку: " + client.Mailing);


    }
}

class Employee
{
    public string Name { get; set; }
    public string Nember { get; set; }
    public Employee() { }
    public Employee(string name, string nember)
    {
        Name = name;
        Nember = nember;
    }

    public string getName() { return Name; }
    public string getNember() { return Nember; }

    public void setName(string name) { Name = name; }
    public void setNember(string nember) { Nember = nember; }
}

class ProductionWorker : Employee
{
    public int ShiftNumber;
    public string Stake;

    public ProductionWorker() { }
    public ProductionWorker(string name, string nember,int shiftNumber, string stake) : base(name, nember)
    {
        ShiftNumber = shiftNumber;
        Stake = stake;
    }

    public int getShiftNumber() { return ShiftNumber; }
    public string getStake() { return Stake; }
    public void setShiftNumber(int shift_number) { ShiftNumber = shift_number; }
    public void setStake(string stake) { Stake = stake; }
}

class ShiftSupervisor : Employee
{
    public int Salary;
    public int Prize;

    public ShiftSupervisor() { }
    public ShiftSupervisor(string name, string nember, int salary, int prize) : base(name, nember)
    {
        Salary = salary;
        Prize = prize;
    }

    public int getSalary() { return Salary; }
    public int getPrize() { return Prize; }
    public void setSalary(int salary) { Salary = salary; }
    public void setPrize(int prize) { Prize = prize; }
}

class Person
{
    public string Name;
    public string Address;
    public string Id;
    public Person() { }
    public Person(string name, string address, string id)
    {
        Name = name;
        Address = address;
        Id = id;
    }
}

class Client : Person
{
    public string Nember;
    public bool Mailing;
    public Client() { }
    public Client(string nember, bool maling, string name, string address, string id) : base(name, address, id)
    {
        Nember = nember;
        Mailing = maling;
    }
}


