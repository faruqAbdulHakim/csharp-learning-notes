class Mobil
{
    // atribut
    public string warna;

    // constructor
    public Mobil(string warna)
    {
        //warna = warnaMobil;

        // keyword this
        // digunakan untuk mengakses atribut/method pada objek
        this.warna = warna;
        this.TancapGas();
    }

    // method
    public void TancapGas()
    {
        string warna = "Kuning";
        // apabila tidak memakai this, warna akan bernilai Kuning
        //Console.WriteLine($"Mobil {warna} melaju dengan cepat");
        Console.WriteLine($"Mobil {this.warna} melaju dengan cepat");
    }
}

namespace Ns1
{
    class Matematika
    { 
        public static int Pengurangan(int angka1, int angka2)
        {
            return angka1 - angka2;
        }
    }

}
namespace Ns2
{
    class Matematika
{
    // untuk mengakses Matematika.PI
    public static double PI = 3.14;

    // untuk mengakses Matematika.Penambahan(5, 8);
    public static int Penambahan(int angka1, int angka2)
    {
        return angka1 + angka2;
    }
}
}
class Program
{
    static void Main(string[] args)
    {
        // membuat objek
        //Mobil mobilA = new Mobil();
        //Mobil mobilB = new Mobil();

        // akses dan mengganti nilai atribut
        //mobilA.warna = "Biru";
        //Console.WriteLine(mobilA.warna);
        //Console.WriteLine(mobilB.warna);

        // memanggil method
        //mobilA.TancapGas();

        //Mobil mobilA = new Mobil("Merah");
        //Mobil mobilB = new Mobil("Putih");
        //Console.WriteLine(mobilA.warna);
        //Console.WriteLine(mobilB.warna);

        // STRING
        //string namaDepan = "Zaidan";
        //string sapa = $"Halo {namaDepan}";
        //string sapa = "Halo " + namaDepan;
        //Console.WriteLine(sapa);

        // Static
        //Console.WriteLine(Matematika.PI);
        //Console.WriteLine(Matematika.Penambahan(5, 8));

        // melekat pada class, pada objek = error
        //Matematika mtk = new Matematika();
        //Console.WriteLine(mtk.PI);

        // Penggunaan namespace
        Console.WriteLine(Ns2.Matematika.Penambahan(8, 5));
        Ns1.Matematika mtk = new Ns1.Matematika();
    }
}