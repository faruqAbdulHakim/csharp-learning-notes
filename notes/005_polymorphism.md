# Polymorphism

#### Daftar Isi

1. [Polymorphism]()
1. [Methods overloading]()
1. [Methods overriding]()

#### Polymorphism

Poly = Banyak, Morph = Bentuk
Pada OOP penggunaan polymorphism dapat dilihat ketika menerapkan methods overloading dan methods overriding

#### Methods Overloading

Adalah pembuatan method dengan **nama method yang sama**.
Syarat penerapan methods overloading:

- 2 method dengan nama method yang sama namun jumlah parameter berbeda
- 2 method dengan nama method yang sama, jumlah parameter sama, namun tipe data pada paremeter berbeda

Sebagai contoh:

<details>
<summary>Lihat kode</summary>

```cs
class Matematika
{
  public static int Penjumlahan(int angka1, int angka2)
  {
    return angka1 + angka2;
  }

  public static double Penjumlahan(double angka1, double angka2)
  {
    return angka1 + angka2;
  }
}
```

</details>

#### Methods Overriding

Adalah menimpa sebuah method dengan method baru. Umumnya digunakan bersamaan dengan _Inheritance_. Hal-hal yang perlu diperhatikan:

- Tidak dapat menerapkan overriding pada static method.
- Method harus merupakan method `virtual` atau `abstract` atau method yang merupakan hasil dari override.
- Pada method yang meng-override tambahkan keyword `override`

Contoh:

<details>
<summary>Lihat kode</summary>

```cs
class Hewan
{
  public virtual void Bersuara()
  {
    Console.WriteLine("Hewan bersuara");
  }
}

class Kucing : Hewan
{
  public override void Bersuara()
  {
    Console.WriteLine("Kucing Bersuara");
  }
}

class Sapi : Hewan
{
  public override void Bersuara()
  {
    Console.WriteLine("Sapi Bersuara");
  }
}

class Anggora : Kucing
{
  public override void Bersuara()
  {
    Console.WriteLine("Kucing Anggora Bersuara");
  }
}
```

</details>
