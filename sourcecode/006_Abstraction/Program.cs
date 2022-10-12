abstract class Karyawan
{
    public string nama;
    public void Absen()
    {
        Console.WriteLine($"{this.nama} telah Absen");
    }

    public abstract void Bekerja();
}
// Developer extends Karyawan
class Developer : Karyawan
{
    public override void Bekerja()
    {
        Console.WriteLine($"{base.nama} mendevelop aplikasi");
    }
}
class Desainer : Karyawan
{
    public override void Bekerja()
    {
        Console.WriteLine($"{base.nama} Mendasain UI/UX");
    }
}


interface IHewan
{
    void Bersuara();
}

interface IBurung
{
    void Terbang();
}

interface IPeliharaan
{
    void Panggil();
}

// Kucing implements IHewan
class Kucing : IHewan
{
    public void Bersuara()
    {
        Console.WriteLine("Meow");
    }
}

// Elang implements IHewan, IBurung
class Elang : IHewan, IBurung
{
    public void Bersuara()
    { }
    public void Terbang()
    {
        Console.WriteLine("Elang terbang tinggi");
    }
}

abstract class AKucing
{
    public abstract void Meow();
}

// Anggora extends AKucing implements IPeliharaan
class Anggora : AKucing, IPeliharaan
{
    public override void Meow() { }
    public void Panggil() { }
}
class Program
{
    static void Main(string[] args)
    {
        //Developer developer = new Developer();
        //developer.Absen();
        //developer.Bekerja();

        //Desainer desainer = new Desainer();
        //desainer.Bekerja();

        Kucing kucing = new Kucing();
        kucing.Bersuara();

        Elang elang = new Elang();
        elang.Terbang();
    }
}