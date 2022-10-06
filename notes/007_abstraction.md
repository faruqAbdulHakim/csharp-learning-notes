# Abstraction

#### Daftar Isi

1. [Abstraction](#abstraction)
1. [Interface](#interface)
1. [Inheritance dan Abstraction](#inheritance-dan-abstraction)

#### Abstraction

Abstraction merupakan salah satu pilar dalam OOP. Abstraction dilakukan ketika ingin membuat sebuah class yang bersifat abstrak (_abstract class_). Class yang bersifat abstrak tidak dapat diinisialisasi. _abstract class_ dibuat dengan menambahkan keyword `abstract` sebelum keyword `class`.

```cs
abstract class Karyawan
{
  // class members
}
```

class A diatas tidak dapat diinisialisasi (`new Karyawan()`). Ketika telah membuat _abstract class_, selanjutnya dapat membuat abstract method didalamnya. abstract method tidak boleh memiliki access modifier private.

```cs
abstract class Karyawan
{
  public string nama;

  public void Absen() {
    Console.WriteLine($"{this.nama} telah absen.");
  }

  // Abstract method Bekerja(), sebuah method tanpa body.
  public abstract void Bekerja();
}

class Developer : Karyawan
{
  public Developer(string nama)
  {
    base.nama = nama;
  }

  // PENTING: method Bekerja() wajib di override dan dibuatkan body nya.
  public override void Bekerja()
  {
    Console.WriteLine($"{base.nama} sedang mendevelop aplikasi.");
  }
}
```

#### Interface

Interface merupakan salah satu cara/bentuk pendekatan abstraction. Interface dibuat dengan mengganti keyword `class` menjadi keyword `interface`. Methods yang dituliskan di dalam interface secara default akan bersifat abstract, sehingga perlu dituliskan pada child classnya, namun tanpa keyword `override`.

```cs
interface IHewan
{
  void Bersuara();
}

class Kucing : IHewan
{
  public void Bersuara()
  {
    Console.WriteLine("Meow");
  }
}
```

> best practice penamaan interface diawali dengan I

#### Inheritance dan Abstraction

Sebuah child/derived class hanya dapat memiliki 1 parent abstract class.

```cs
abstract class A
{}
abstract class B
{}

class X : A // Valid
{}
class Y : A, B //Invalid
{}
```

Sebuah child/derived class dapat memiliki beberapa parent interface.

```cs
interface IA
{}
interface IB
{}

class X : IA // Valid
{}
class Y : IA, IB //Valid
{}
```

Sebuah child/derived class dapat memiliki parent 1 abstract dan sekumpulan interface.

```cs
abstract class A
{}
interface IB
{}
interface IC
{}

class X : A, IB, IC // Valid
{}
```

Ketika menginheritance dari abstract class, istilah yang lebih tepat yaitu **Extends**
Ketika menginhertance dari interface, istilah yang lebih tepat yaitu **Implements**

```cs
abstract class A
{}
class B : A
{}
// dibaca: class B extends A
```

```cs
interface IA
{}
interface IB
{}
class C : IA, IB
{}
// dibaca: class C implements IA, IB
```
