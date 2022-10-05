# Encapsulation

#### Daftar Isi

1. [Encapsulation](#encapsulation)
1. [Access Modifier](#access-modifier)
1. [Contoh Encapsulation](#encapsulation)

#### Encapsulation

Encapsulation merupakan salah satu pilar dalam OOP. Encapsulation memiliki arti enkapsulasi (garis bawahi pada **kapsul**), yang secara sederhana kita mengkapsul / membungkus suatu class agar class members (property dan method) tidak diakses secara langsung.

#### Access Modifier

Berbicara mengenai encapsulation, _Access Modifier_ menjadi salah satu topik yang perlu dipelajari. Access modifier mengatur bagaimana suatu class member dapat diakses. Access modifier terdiri dari:

- `public`, class member dapat diakses dari **manapun**
- `private`, class member hanya dapat diakses dari **class yang sama**
- `protected`, class member dapat diakses dari **class yang sama** dan **child class nya**
- `internal`, class member dapat diakses dari **manapun** selama berasal dari 1 assembly yg sama.
- `protected internal`, class member dapat diakses dari **manapun** selama masih 1 assembly atau dapat diakses dari assembly yg berbeda dengan syarat merupakan **child class** dari class yang bersangkutan
- `private protected`, class member dapat diakses dari **child class nya**

#### Contoh Encapsulation

Penerapan encapsulation pada property yaitu dengan cara membatasi hak read-write secara langsung, melainkan melalui method setter dan getter.

Contoh:

```cs
class Mahasiswa
{
  private string nama;

  public void SetNama(string nama)
  {
    this.nama = nama;
  }

  public string GetNama()
  {
    return this.nama;
  }
}
```

```cs
Mahasiswa mahasiswa = new Mahasiswa();
// mahasiswa.nama = "Budi"; // Error
// Console.WriteLine(mahasiswa.nama); // Error
mahasiswa.SetNama("Budi");
Console.WriteLine(mahasiswa.GetNama());
```

Pada bahasa pemrograman JAVA, setter dan getter dituliskan sama seperti kode diatas, yaitu dengan menambahkan method setter dan getter untuk mengakses private property. Sedangkan pada C# dapat menggunakan cara diatas, atau cara _best practices_ C# yang hanya mengubah perilaku ketika data diubah/dipanggil.

```cs
class Mahasiswa
{
  private string nama;
  public string Nama
  {
    get { return this.nama; }
    set { this.nama = value; }
  }
}
```

```cs
Mahasiswa mahasiswa = new Mahasiswa();
// mahasiswa.nama = "Budi"; // Error
// Console.WriteLine(mahasiswa.nama); // Error
mahasiswa.Nama = "Budi";
Console.WriteLine(mahasiswa.Nama);
```

<details>
<summary>Contoh penggunaan</summary>

```cs
class Persegi
{
  private int panjang;
  private int lebar;
  private int luas;

  public int Panjang
  {
    get { return this.panjang; }
    set
    {
      this.panjang = value;
      this.UpdateLuas();
    }
  }

  public int Lebar
  {
    get { return this.lebar; }
    set
    {
      this.lebar = value;
      this.UpdateLuas();
    }
  }

  public int Luas
  {
    get { return this.luas; }
  }

  private void UpdateLuas()
  {
    this.luas = this.panjang * this.lebar;
  }
}
```

```cs
Persegi persegi = new Persegi();
persegi.Lebar = 12;
persegi.Panjang = 20;
Console.WriteLine(persegi.Luas); // Output: 240
// persegi.Luas = 120; // Error, karena tidak memiliki fungsi setter
```

</details>
