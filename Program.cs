namespace StrukturData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struktur Data");
            // Variabel
            string Nama = "Aziz Fatkhu Rohman"; //Tipe Data String
            string Prodi = "Sistem Informasi";
            Console.WriteLine(Nama +" "+ Prodi);

            //Input Variabel
            string NamaAnda;
            string ProdiAnda;
            Console.WriteLine("Input Nama: ");
            NamaAnda = Console.ReadLine();//Input Nama
            Console.WriteLine("Input Prodi: ");
            ProdiAnda = Console.ReadLine();//Input Prodi
            Console.WriteLine("Nama: " + NamaAnda);//Output Nama
            Console.WriteLine("Prodi: " + ProdiAnda);//Output Prodi

            //+ = Tambah, * = Kali, / = bagi, - = ambil;
            int A;
            int B;
            Console.WriteLine("Masukkan Nilai 1: ");
            A = Convert.ToInt16(Console.ReadLine());// Convert Int Input
            Console.WriteLine("Masukkan Nilai 2: ");
            B = Convert.ToInt16(Console.ReadLine());// Convert Int Input 2
            Console.WriteLine(A + B);// Tambah

            //Pengkondisian IF Else;
            Console.WriteLine("Kalkulator");
            int Val1;
            int Val2;
            string pilih;
            Console.WriteLine("Pilih Operator,ex:+,-,*,/");
            pilih = Console.ReadLine();
            Console.WriteLine("Nilai 1: ");
            Val1 = Convert.ToInt16(Console.ReadLine()); //Input Val1
            Console.WriteLine("Nilai 2: ");
            Val2 = Convert.ToInt16(Console.ReadLine());//Input Val2
            if (pilih == "+")
            {
                Console.WriteLine(Val1 + Val2);
            }
            else if(pilih == "-"){
                Console.WriteLine(Val1 - Val2);
            }else if(pilih == "*")
            {
                Console.WriteLine(Val1 * Val2);
            }else if(pilih == "/")
            {
                Console.WriteLine(Val1 / Val2);
            }
            else
            {
                Console.WriteLine("Operator tidak ada");
            }
            //Switch
            int BahasaProgram;
            Console.WriteLine("Pilih Bahasa Program Favorit.ex:1,2,or 3?");
            Console.WriteLine("1. JavaScript");
            Console.WriteLine("2. PHP");
            Console.WriteLine("3. C#");
            BahasaProgram = Convert.ToInt16(Console.ReadLine());
            switch (BahasaProgram)
            {
                case 1:
                    Console.WriteLine("JavaScript sangat asik");
                    break;
                case 2:
                    Console.WriteLine("PHP sangat mudah");
                    break;
                case 3:
                    Console.WriteLine("C# sangat seru");
                    break;

            }
            //Array
            Console.Write("Array");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Cetak Array ke 0: " + array[0]);
        }
    }
}