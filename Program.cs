int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("nama siswa: ");
nama = Console.ReadLine();

Console.Write("nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("selamat, lulus");
}
else
{
    Console.WriteLine("maaf, belum lulus");
}