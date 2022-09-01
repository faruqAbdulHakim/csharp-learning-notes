# Pengenalan C#

#### Daftar isi

1. [Pengenalan awal](#pengenalan-awal)
1. [Input dan Output berbasis Konsol](#input-dan-output-berbasis-konsol)
1. [Variabel](#variabel)
1. [Tipe Data](#tipe-data)
1. [Operators](#operators)
1. [Percabangan](#percabangan)
1. [Perulangan](#perulangan)
1. [Break/Continue](#breakcontinue)

#### Pengenalan awal

Template awal untuk menuliskan kode program C#

```cs
namespace MyNamespace
{
  class Program
  {
    static void Main(string[] args)
    {
      // Write your code here;
    }
  }
}
```

- `namespace` adalah cara mengorganisir kode. Anggap saja sebagai kontainer.
- `class` adalah kontainer dari properties dan methods.
- method `Main()` adalah method yang pertama kali dijalankan pada kode C#
- C# tidak menggunakan indentasi seperti python, melainkan dibungkus dalam kurung kurawal `{}`
- Setiap akhir perintah dalam C# diakhiri titik koma `;`

#### Input dan Output berbasis Konsol

Untuk print suatu data ke konsol:

```cs
Console.Write("Hello World!");
Console.WriteLine("Hello World!");
```

Untuk menerima input user dari konsol:

```cs
Console.ReadLine();
```

Keduanya dapat digabungkan menjadi:

```cs
Console.Write("Masukkan namamu: ");
Console.ReadLine();
```

#### Variabel

Variabel adalah tempat menampung data. Dalam C#, satu variabel hanya dapat digunakan untuk satu tipe data yang sama.
Format penulisan variabel dalam C#:

```
tipeData namaVariabel = isidata;
```

Sebuah variabel juga bisa dideklarasikan terlebih dahulu tanpa mengisi datanya.

```
tipeData namaVariabel;
namaVariabel = isiData;
```

Contoh:

```cs
int tinggiBadan = 170;

int beratBadan;
beratBadan = 72;
```

#### Tipe Data

<details>
<summary>Tipe Data Angka Bulat</summary>

| Tipe data | Memori | Range                                                  |
| --------- | :----: | :----------------------------------------------------- |
| `sbyte`   | 1 byte | -128 ~ 127                                             |
| `byte`    | 1 byte | 0 ~ 255                                                |
| `short`   | 2 byte | -32,768 ~ 32,767                                       |
| `ushort`  | 2 byte | 0 ~ 65,535                                             |
| `int`     | 4 byte | -2,147,483,648 ~ 2,147,483,647                         |
| `uint`    | 4 byte | 0 ~ 4,294,967,295                                      |
| `long`    | 8 byte | -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 |
| `ulong`   | 8 byte | 0 ~ 18,446,744,073,709,551,615                         |

Gunakan sesuai kebutuhan. Yang paling sering digunakan yaitu int dan long.

</details>

<details>
<summary>Tipe Data Angka Desimal</summary>

| Tipe data | Memori  | Suffix                         |
| --------- | :-----: | ------------------------------ |
| `float`   | 4 byte  | `f` atau `F`                   |
| `double`  | 8 byte  | `d` atau `D` atau tanpa suffix |
| `decimal` | 16 byte | `m` atau `M`                   |

Semakin tinggi memori yang digunakan, semakin tinggi presisi angka tersebut.

</details>

<details>
<summary>Tipe Data Teks</summary>

| Tipe data | Penjelasan                                                                                  |
| --------- | ------------------------------------------------------------------------------------------- |
| `char`    | Untuk menyimpan 1 karakter. Data ditulis di dalam tanda petik satu. (contoh: `'b'`)         |
| `string`  | Untuk menyimpan data teks. Data ditulis di dalam tanda petik dua. (contoh: `"Hello World"`) |

</details>

<details>
<summary>Tipe Data Boolean</summary>

C# juga menyediakan tipe data untuk kondisi `true` atau `false` yaitu dengan `bool`.

</details>

#### Operators

<details>
<summary>Operator Aritmatika</summary>

| Operator | Contoh   |
| -------- | -------- |
| `+`      | `x + y;` |
| `-`      | `x - y;` |
| `*`      | `x * y;` |
| `/`      | `x / y;` |
| `%`      | `x % y;` |
| `++`     | `x++;`   |
| `--`     | `x--;`   |

</details>

<details>
<summary>Operator Assignment</summary>

Adalah shorthand operator. Misal terdapat kode `x = x + 5`, dapat dipersingkate dengan `x += 5`

</details>

<details>
<summary>Operator Komparasi</summary>

| Operator | Deskripsi                    | Contoh   |
| -------- | ---------------------------- | -------- |
| `==`     | sama dengan                  | `x == y` |
| `!=`     | tidak sama dengan            | `x != y` |
| `>`      | lebih dari                   | `x > y`  |
| `<`      | kurang dari                  | `x < y`  |
| `>=`     | lebih dari atau sama dengan  | `x >= y` |
| `<=`     | kurang dari atau sama dengan | `x <= y` |

</details>

<details>
<summary>Operator Logika</summary>

| Operator | Nama | Contoh         |
| -------- | ---- | -------------- | --- | ----- | --- | ----- |
| `&&`     | AND  | `true && true` |
| `        |      | `              | OR  | `true |     | true` |
| `!`      | NOT  | `!true`        |

</details>

#### Percabangan

<details>
<summary>If Else</summary>

Syntax:

```cs
if (condition)
{
  // Jika condition bernilai true jalankan kode di dalam sini
}
else if (anotherCondition)
{
  // Jika condition bernilai false
  // Lakukan pengecekan di else if
  // jika anotherCondition bernilai true jalankan kode di dalam sini
}
else
{
  // jika pengecekan if dan else if tidak ada yang benar maka jalankan kode didalam sini
}
```

</details>

<details>
<summary>Switch</summary>

Syntax:

```cs
switch (expression)
{
  case value1:
    // jika data pada expression == value1, jalankan kode dibawa ini
    break; // supaya tidak lanjut ke case selanjutnya
  case value2:
    // kode
    break;
  default:
    // jika tidak ada case yang cocok
    break;
}
```

</details>

#### Perulangan

<details>
<summary>For Loop</summary>

Syntax:

```cs
for (statement_1; statement_2; statement_3)
{
  // kode
}
```

- `statement_1` dijalankan **hanya sekali** sebelum perulangan dimulai
- `statement_2` kondisi apakah kode dalam looping akan dijalankan
- `statement_3` dijalankan **setiap** satu iterasi sudah selesai

Contoh:

```cs
for {int i = 0; i < 10; i++}
{
  Console.WriteLine(i);
}
```

</details>

<details>
<summary>While Loop</summary>

Syntax:

```cs
while (kondisi)
{
  // kode
}
```

kode dalam while akan selalu dijalankan apabila kondisi bernilai `true`

</details>

<details>
<summary>Do While Loop</summary>

Serupa dengan while loop. Bedanya **setidaknya** kode dijalankan satu kali. Barulah iterasi ke-2 dilakukan pengecekan kondisi

Syntax:

```cs
do
{
  // kode
}
while (kondisi)
```

</details>

#### Break/Continue

- `break` digunakan untuk keluar dari perulangan atau menghentikan pengecekan case pada `switch`
- `continue` digunakan untuk melompati iterasi yang sedang berlangsung dan lanjut ke iterasi selanjutnya
