# OOP Dasar

#### Daftar Isi

1. [Main Method](#main-method)
1. [Class dan Objek](#class-dan-objek)
1. [Class Members](#class-members)
   - [Atribut](#atribut)
   - [Method](#method)
   - [Constructor](#constructor)
1. [Keyword `this`](#keyword-this)
1. [Keyword `static`](#keyword-static)
1. [Namespace](#namespace)

#### Main Method

Main method merupakan method yang pertama kali dijalankan dalam program. Main method bersifat static dan tidak mereturn apapun.

```cs
class Program
{
  static void Main(string[] args)
  {
    // Kode...
  }
}
```

#### Class dan Objek

- Class merupakan sebuah _blueprint_ atau rancangan
- Objek bentuk nyata dari class

Contoh membuat class:

```cs
class Mobil
{

}
```

Sedangkan untuk membuat sebuah objek hampir serupa dengan membuat variabel yaitu dengan syntax `NamaClass namaObjek = new NamaClass(args?)`.

```cs
Mobil mobilA = new Mobil();
Mobil mobilB = new Mobil();
```

#### Class Members

Isi dari sebuah class (disebut juga Class Members) terdiri atas atribut dan method

- **atribut** kadang juga disebut property, field, atau state. Merupakan sebuah nilai yang melekat pada objek.
- **method** merupakan sekumpulan perintah yang melekat pada objek. Dapat diartikan juga function yang melekat pada objek.

<details id="atribut">
<summary>Atribut</summary>

##### Atribut

Membuat atribut serupa dengan membuat variabel.

Contoh attribut pada `class Mobil` sebelumnya seperti warna dan keadaan mesin menyala/tidak, dapat dituliskan dengan:

```cs
class Mobil
{
  public string warna = "Abu-abu";
  public bool menyala = true;
}
```

> Tambahkan keyword `public` pada awalan agar dapat diakses nantinya. Materi access modifier akan dibahas lain waktu.

> Perhatikan bahwa atribut dan variabel dibuat dengan cara yang sama. Namun atribut dituliskan di dalam class sedangkan variabel dituliskan di dalam method.

Attribut tersebut dapat diakses pada objek yang akan dibuat, seperti:

```cs
Mobil mobil = new Mobil();

Console.WriteLine(mobil.warna);
// output: Abu-abu
Console.WriteLine(mobil.menyala);
// output: True
```

Atribut juga dapat diganti nilainya (atau diisi apabila sebelumnya merupakan atribut kosong) dengan cara:

```cs
Mobil mobil = new Mobil();
mobil.warna = "Merah"; // "Abu-abu" diubah menjadi "Merah"
mobil.menyala = false; // true diubah menjadi false
```

</details>

<details id="method">
<summary>Method</summary>

##### Method

Syntax:

```cs
tipeDataReturn NamaMethod(tipeDataParameter namaParameter, ...)
{

}
```

Sebuah method perlu didefinisikan tipe data apa yang akan dikembalikan / di `return` nantinya. Apabila tidak ada yang dikembalikan dapat menggunakan keyword `void`.
Contoh pada class Mobil:

```cs
class Mobil
{
  public void TancapGas() {
    Console.WriteLine("Mobil melaju dengan cepat");
  }
}
```

method tersebut dapat diakses dengan

```cs
Mobil mobil = new Mobil();
mobil.TancapGas();
```

</details>

<details id="constructor">
<summary>Constructor</summary>

##### constructor

Constructor adalah method spesial yang akan dijalankan pertama kali **ketika objek dibuat**.

- Sebuah constructor tidak akan mereturn apapun sehingga dalam membuatnya tidak perlu mendefiniskan tipe data return.
- nama method constructor sama dengan nama class nya

syntax:

```cs
class Example
{
  public Example()
  {
    Console.WriteLine("Berhasil membuat objek Example");
  }
}
```

Umumnya constructor digunakan untuk mengisi atribut yang kosong, agar objek akan berbada satu dengan yang lainnya ketika dibuat.

```cs
class Mobil
{
  public string warna;
  public bool menyala;

  public Mobil(string warnaMobil, bool statusMesin)
  {
    warna = warnaMobil;
    menyala = statusMesin;
  }
}
```

```cs
Mobil mobilA = new Mobil("Abu-abu", false);
Mobil mobilB = new Mobil("Merah", false);
```

</details>

#### Keyword `this`

- keyword `this` merujuk pada objek.
- `this.warna` akan merujuk attribut warna pada objek. Berhubung parameter method memiliki nama yang sama dengan attribut, maka keyword `this` diperlukan.
- juga dapat untuk mengakses method pada objek dengan `this.NamaMethod()`

```cs
class Mobil
{
  string warna;
  bool menyala;

  public Mobil(string warna, bool menyala)
  {
    this.warna = warna;
    this.menyala = menyala;
    // this.Describe();
  }

  public void Describe() {
    Console.WriteLine($"Mobil memiliki warna : {warna}");
    Console.WriteLine($"Mesin mobil menyala  : {menyala}");
  }
}
```

#### Keyword `static`

Atribut dan method dapat bersifat static, artinya atribut dan method melekat pada class bukan pada objek. Sehingga apabila hendak mengakses tidak perlu membuat objek terlebih dahulu. Caranya cukup menambahkan keyword `static` sebelum tipe data atribut / method.

```cs
class Kalkulator
{
  public static double pi = 3.141592;

  public static int Penambahan(int a, int b)
  {
    return a + b;
  }
}
```

mengaksesnya cukup dengan:

```cs
// tanpa membuat objek
Console.WriteLine(Kalkulator.pi);
Console.WriteLine(Kalkulator.Penambahan(7,3));
```

#### Namespace

Namespace adalah cara kita untuk mengelompokkan class, agar kode lebih mudah di-_organize_. Kasus yang mungkin terjadi yaitu adanya 2 class dengan nama yang sama namun isinya berbeda. Hal tersebut dapat diatasi dengan menggunakan namespace.

<details>
<summary>Contoh Kasus</summary>

```cs
namespace MainNamespace
{
  class Program
  {
    static void Main(string[] args)
    {
      int output;

      output = Namespace1.Kalkulator.Operasi(5,3);
      Console.WriteLine(output);

      output = Namespace2.Kalkulator.Operasi(5,3);
      Console.WriteLine(output);
    }
  }
}

namespace Namespace1
{
  class Kalkulator
  {
    public static int Operasi(int a, int b)
    {
      return a + b;
    }
  }
}

namespace Namespace2
{
  class Kalkulator
  {
    public static int Operasi(int a, int b)
    {
      return a - b;
    }
  }
}
```

</details>
