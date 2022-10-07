# Koneksi ke PostgreSQL

#### Daftar Isi

1. [Menginstall package Npgsql](#meningstall-package-npgsql)
1. [Membuat koneksi ke PostgreSQL](#membuat-koneksi-ke-postgresql)
1. [Membuat tabel](#membuat-tabel)
1. [Insert data](#insert-data)
1. [Select data](#select-data)

#### Meningstall package Npgsql

Langkah pertama sebelum dapat menghubungkan aplikasi C# dengan db PostgreSQL yaitu menginstall package **Npgsql**. Package tersebut digunakan sebagai penghubung koneksi ke PostgreSQL. Pastikan terhubung ke internet apabila hendak menginstall package.

![](./assets/Screenshot%202022-10-07%20060544.jpg)
Step 1: klik Project > Manage Nuget Packages

![](./assets/Screenshot%202022-10-07%20060814.jpg)
Step 2: Akan terbuka tab baru yaitu **NuGet: NamaProject**. Klik Browse, lalu cari Npgsql. Klik package Npgsql yang tampil.

![](./assets/Screenshot%202022-10-07%20061038.jpg)
Step 3: Klik Install, apabila muncul pemberitahuan cukup klik OK

Step 4: Setelah proses Install sudah selesai, tab NuGet dapat ditutup.

#### Membuat koneksi ke PostgreSQL

```cs
using Npgsql;

class Program
{
  static void Main(string[] args)
  {
    string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=fasilkom";
    NpgsqlConnection connection = new NpgsqlConnection(conenctionString);
    connection.Open();
    // sekumpulan perintah SQL
    connection.Close();
  }
}
```

- Langkah pertama mengimport package Npgsql yang sebelumnya sudah diinstall menggunakan `using Npgsql`.
- Selanjutnya membuat sebuah string yang menjadi konfigurasi untuk koneksi ke database. Konfigurasi berisi data **key=value** yang dipisahkan dengan titik koma **;**.
  - `Host`, Hostname/letak PostgreSQL berjalan
  - `Port`, Port PostgreSQL berjalan [default: 5432]
  - `Username`, username user PostgreSQL
  - `Password`, password user PostgreSQL
  - `Database`, database PostgreSQL
    > Pastikan database sudah ada sebelum melakukan koneksi
- Membuat koneksi ke PostgreSQL dengan cara membuat objek dari class `NpgsqlConnection` yang menerima satu parameter yaitu string konfigurasi.
- Memanggil method `.Open()` untuk membuka koneksi
- Pastikan memanggil method `.Close()` apabila koneksi sudah tidak digunakan lagi.

Kode diatas telah membuat koneksi ke PostgreSQL, namun belum ada perintah SQL yang dijalankan. Untuk membuat perintah perlu membuat objek dari class `NpgsqlCommand`

#### Membuat tabel

Sebelum membuat tabel, pastikan tidak ada tabel yang duplikat nantinya. yaitu dengan menghapus tabel apabila tabel sudah ada di databse dengan cara:

```cs
// cara 1
string cmdText = "DROP TABLE IF EXISTS mahasiswa";
NpgsqlCommand command = new NpgsqlCommand(cmdText, connection);
command.ExecuteNonQuery();
```

```cs
// cara 2
NpgsqlCommand command = new NpgsqlCommand();
command.Connection = connection;
command.CommandText = "DROP TABLE IF EXISTS mahasiswa";
command.ExecuteNonQuery();
```

- `NpgsqlCommand` memerlukan 2 properti sebelum dijalankan. yaitu perintahnya, kita sebut dengan `CommandText`. dan koneksi ke PostgreSQL nya, kita sebut dengan `Connection`
- Memanggil method `.ExecuteNonQuery()` karena perintah tersebut tidak mereturn data apapun.

Setelah menghindari adanya duplikat tabel, langka selanjutnya membuat tabel.

```cs
command.CommandText = "CREATE TABLE mahasiswa (id SERIAL PRIMARY KEY, nama VARCHAR)";
command.ExecuteNonQuery();
```

#### Insert data

Untuk menginsert data disarankan value data tidak dituliskan secara langsung seperti berikut.

`INSERT INTO mahasiswa(nim, nama) VALUES(202410101000, 'Budi');`

Melainkan dengan menggunakan Prepared Statement, agar insert data lebih **aman**. yaitu dengan cara berikut.

```cs
command.CommandText = "INSERT INTO mahasiswa(nama) VALUES(@nama)";

command.Parameters.AddWithValue("nama", "Budi");
command.Prepare();
command.ExecuteNonQuery();
command.Parameters.Clear();

command.Parameters.AddWithValue("nama", "Andi");
command.Prepare();
command.ExecuteNonQuery();
command.Parameters.Clear();
```

- values ditandai dengan awalan `@` diikuti dengan nama value (bebas).
- Selanjutnya parameter diisi dengan memanggil method pada NpgsqlCommand, yaitu pada `.Parameters.AddWithValue()`.
- Parameter pertama merupakan nama yang sudah kita tuliskan sebelumnya pada perintah SQL, `@nama -> nama`. Sedangkan parameter kedua berisi nilai yang hendak dimasukkan.
- Selanjutnya memanggil method `.Prepare()` dan method `.ExecuteNonQuery()`.
- Setelah perintah dijalankan, disarankan memanggil method `.Parameters.Clear()` agar insert data selanjutnya dapat memiliki value yang berbeda.

#### Select data
