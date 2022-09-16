class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Budi");
        //Console.WriteLine(employee1.nama);
        //employee1.Absen();
        //employee1.Ngoding(); ERROR

        FrontEndDev developer = new FrontEndDev("Andi", "Junior");
        developer.Ngoding();
        FrontEndDev developer2 = new FrontEndDev("Dany", "Junior");
        //Console.WriteLine(developer.level);
        //Console.WriteLine(developer.nama);
        //Console.WriteLine(developer2.nama);

        //developer.Absen();
        //developer.Ngoding();
    }
}

class Employee
{
    public string nama;

    public Employee(string nama)
    {
        this.nama = nama;
    }
    public void Absen()
    {
        Console.WriteLine($"{this.nama} telah absen");
    }
}

class FrontEndDev : Employee
{
    public string level;
    public string nama = "Zaky";
    public FrontEndDev(string nama, string level) : base(nama)
    {
        this.level = level;
    }
    public void Ngoding()
    {
        string nama = "Mela";
        // base -> this tapi menunjuk ke parent
        base.Absen();
        Console.WriteLine($"{this.level} {base.nama} Mulai ngoding");
    }
}