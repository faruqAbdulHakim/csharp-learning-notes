# Ref dan Out

#### Daftar Isi

1. [Keyword `ref` dan `out`](#keyword-ref-dan-out)
1. [_Pass by value_](#pass-by-value)
1. [_Pass by reference_ dengan `ref`](#pass-by-reference-dengan-ref)
1. [_Pass by reference_ dengan `out`](#pass-by-reference-dengan-out)

#### Keyword `ref` dan `out`

Keyword `ref` dan `out` digunakan untuk mengubah perilaku parameter yang secara default _pass by value \_menajadi \_pass by reference_. Ilustrasi perbedaan:
![](https://miro.medium.com/max/1000/1*GXoMWqljArmbjB0ReNioag.gif)
Dapat dilihat, method dengan parameter _pass by value_ tidak akan mengubah nilai argument yang dikirimkan melalui variabel. Sedangkan apabila dengan parameter _pass by reference_, perubahan yang terjadi di dalam method juga akan berpengaruh pada argument tersebut berasal (variabel).

#### _Pass by value_

Secara default method yang dibuat memiliki parameter _pass by value_

```cs
class Program
{
  static void Main(string[] args)
  {
    int umur = 20;
    UlangTahun(umur);
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur tetap 20
    // meskipun didalam method umur ditambah 1
  }

  static void UlangTahun(int umur) {
    umur++;
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur bertambah 1 menjadi 21
  }
}
```

#### _Pass by reference_ dengan `ref`

`ref` dapat mengubah perilaku parameter menjadi pass by reference. Keyword `ref` dituliskan didalam parameter seperti contoh berikut:

```cs
void NamaMethod(ref int parameter1){}
// contoh pemanggilan: NamaMethod(ref 20)
```

Contoh:

```cs
class Program
{
  static void Main(string[] args)
  {
    int umur = 20;
    UlangTahun(ref umur);
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur menjadi 21
    // karena didalam method umur ditambah 1
  }

  static void UlangTahun(ref int umur) {
    umur++;
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur bertambah 1 menjadi 21
  }
}
```

Perlu diperhatikan, nilai reference akan ikut berubah hanya apabila perubahan dilakukan pada parameter yang sama. Apabila nilai parameter disimpan terlebih dahulu ke sebuah varibel terpisah, maka nilai asal reference tidak akan ikut berubah.

```cs
class Program
{
  static void Main(string[] args)
  {
    int umur = 20;
    UlangTahun(ref umur);
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur tetap 20 karena didalam method UlangTahun
    // penambahan umur dilakukan melalui variabel umurSekarang
    // bukan melalui parameter umur secara langsung
  }

  static void UlangTahun(ref int umur)
  {
    int umurSekarang = umur + 1;
    Console.WriteLine($"Umur sekarang: {umurSekarang}");
    // umur bertambah 1 menjadi 21
  }
}
```

#### _Pass by reference_ dengan `out`

Cara kedua untuk mengubah parameter menjadi pass by reference yaitu dengan method `out`. Cara pembuatannya hampir serupa dengan ref, misal:

```cs
void NamaMethod(out int parameter) {}
// dipanggil dengan: NamaMethod(out 20)
```

Perbedaan yang paling utama yaitu **parameter out tidak memiliki nilai**. Sarameter out hanya menandai nilai reference yang akan diubah nilainya. Sehingga, nilai parameter harus diisi terlebih dahulu didalam method.

```cs
void NamaMethod(out int parameter) {
  // Console.WriteLine(parameter); // Error karena tidak memiliki nilai
  parameter = 40;
}
```

Pada kode diatas ketika memanggil `NamaMethod(out argument)`. Nilai asal reference argument akan berubah menjadi 40.

Contoh:

```cs
class Program
{
  static void Main(string[] args)
  {
    int umur = 20;
    UlangTahun(out umur);
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur juga menjadi 40
  }

  static void UlangTahun(out int umur)
  {
    // umur++; //ERROR
    umur = 40;
    Console.WriteLine($"Umur sekarang: {umur}");
    // umur menjadi 40
  }
}
```
