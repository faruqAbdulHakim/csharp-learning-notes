# Inheritance

#### Daftar Isi

1. [Inheritance sebagai salah satu 4 pilar OOP](#inheritance-sebagai-salah-satu-4-pilar-oop)
1. [Apa itu Inheritance](#apa-itu-inheritance)
1. [Yang tidak diwariskan](#yang-tidak-diwariskan)
1. [Keyword `base`](#keyword-base)

#### Inheritance sebagai salah satu 4 pilar OOP

Terdapat 4 pilar OOP yaitu **Inheritance, Encapsulation, Abstraction, dan Polymorphism**. Keempat pilar tersebut akan sering sekali saling berkaitan ketika menyusun kode yang berorientasi objek.

#### Apa itu Inheritance

Inheritance merupakan metode dalam mewariskan sebuah class. Kata **pewarisan** sama seperti di dunia nyata, ada yang memberi warisan ada yang menerima warisan. Dalam OOP C#, pemberi warisan (orang tua) disebut dengan **parent class / base class** sedangkan penerima warisan (anak) disebut dengan **child class / derived class**. Adapun yang diwariskan yaitu class members dari parent class.

Inheritance bisa digunakan untuk meng-extend atau lebih menspesifikan sebuah class. sebagai contoh:

<details>
<summary>Lihat kode</summary>

```cs
class Employee
{
  public bool aktif = true;

  public void Absen()
  {
    Console.WriteLine("Berhasil absen");
  }
}

class FrontEndDev : Employee
{
  public void Ngoding()
  {
    Console.WriteLine("Mulai menuliskan kode");
  }
}
```

</details>

Atribut dan methods dari class `Employee` juga akan dimiliki class `FrontEndDev`.

<details>
<summary>Lihat kode</summary>

```cs
FrontEndDev developer = new FrontEndDev();
Console.WriteLine(developer.aktif); // output: True
developer.Absen(); // output: "Berhasil absen"
developer.Ngoding(); // output: "Mulai menuliskan kode"

Employee employee = new Employee();
Console.WriteLine(employee.aktif); // output: True
employee.Absen(); // output: "Berhasil absen"
employee.Ngoding(); // ERROR
```

</details>

#### Yang tidak diwariskan

Yang tidak diwariskan yaitu constructor (baik static maupun non-static) dan finalizers. Pada catatan ini hanya membahas tentang constructor in inheritance.

Apabila parent class tidak memiliki constructor, maka child class **tidak harus** memiliki constructor. Tidak harus memiliki artinya bisa menambahkan/tidak constructor pada child class.

<details>
<summary>Lihat kode</summary>

```cs
class Employee
{

}

class FrontEndDev : Employee
{
  public string level;

  public FrontEndDev(string level)
  {
    this.level = level;
  }
}
```

Pada inisialisasi objek `FrontEndDev` perlu dimasukkan argumen level, sedangkan pada `Employee` tidak perlu.

```cs
FrontEndDev developer = new FrontEndDev("Junior");
Console.WriteLine(developer.level); // output: Junior

Employee employee = new Employee(); // tidak perlu argumen
Employee employee = new Employee("Junior"); // ERROR
```

</details>

<br/>
<br/>

Apabila parent class memiliki constructor, maka child class:

- **tidak harus** memiliki constructor apabila constructor parent class tidak menerima parameter

<details>
<summary>Lihat kode</summary>

```cs
class Employee
{
  public Employee()
  {
    Console.WriteLine("Berhasil membuat objek employee")
  }
}

class FrontEndDev : Employee
{

}
```

```cs
FrontEndDev developer = new FrontEndDev(); // output: Berhasil membuat objek employee
Employee employee = new Employee(); // output: Berhasil membuat objek employee
```

</details>

<br/>

- **harus** memiliki constructor juga apabila constructor parent class menerima parameter. Child class memerlukan constructor untuk mengisi argumen untuk parameter constructor parent class nya. untuk mengisi parameter parent class, menggunakan keyword `base`

<details>
<summary>Lihat kode</summary>

```cs
class Employee
{
  public string nama;

  public Employee(string nama)
  {
    this.nama = nama;
  }
}

class FrontEndDev : Employee
{
  public string level;

  // membuat constructor untuk FrontEndDev
  // sekaligus mengisi parameter constructor parent classnya
  public FrontEndDev(string nama, string level) : base(nama)
  {
    this.level = level;
  }
}
```

```cs
FrontEndDev developer = new FrontEndDev("Andi", "Junior");
Console.WriteLine(developer.nama); // output: Andi
Console.WriteLine(developer.level); // output: Junior

Employee employee = new Employee("Budi");
Console.WriteLine(employee.nama); // output: Budi
```

</details>

#### Keyword `base`

Selain digunakan untuk mengisi parameter, keyword `base` dapat dituliskan pada child class yang digunakan untuk memanggil atribut atau method dari parent classnya.

<details>
<summary>Lihat kode</summary>

```cs
class Employee
{
  public string nama;

  public Employee(string nama)
  {
    this.nama = nama;
  }

  public void Absen()
  {
    Console.WriteLine($"Karyawan dengan nama {nama} berhasil absen");
  }
}

class FrontEndDev : Employee
{
  public string level;

  public FrontEndDev(string nama, string level) : base(nama)
  {
    this.level = level;
  }

  public void Bekerja()
  {
    // memanggil method Absen dari parent classnya
    base.Absen();
    // memanggil atribut nama dari parent classnya
    Console.WriteLine($"{level} developer dengan nama {base.nama} mulai bekerja");
  }
}
```

```cs
  FrontEndDev developer = new FrontEndDev("Andi", "Junior");
  developer.Bekerja();
```

</details>
