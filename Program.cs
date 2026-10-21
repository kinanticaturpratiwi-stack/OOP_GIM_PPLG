// game
// Genre : Fighting
// karakter : nama,kesehatan

using System;
using System.Collections.Generic;
namespace KerangkaGame
{
    class Karakter
    {
        //public string  kesehatan, senjata;
        public int totalSenjata, power;
        public string nama {get; private set;} // enskapsulasi (pake parameter get set )bisa diakses di class tidak bisa diubah
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }
        

        // membuat constructor
        public Karakter( string nama, int  kesehatan, int senjata) 
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
          
        }

        public void Serang(Karakter target) // membuat method menyerang
        {
            Console.WriteLine("===> MULAI SERANGAN <===");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan 
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan : {jumlahSerangan} Serangan");
            Console.WriteLine($"Sisa kesehatan : { kesehatan}");
        }

        public void PilihanPenyembuhan()
        {
            Console.WriteLine("Ada Pilihan Penyembuhan ");
            Console.WriteLine($"Sembuhkan {nama} ?");

            //string pilihan = Console.ReadLine();

            //if (pilihan == "yes")
            //{
            //    Healing(20);
            //}
            //else belum selesai
        }
        //public int totalSenjata { get; private set; }
        //public int power { get; private set; }

        //public void setNama(string namaBaru, string kesehatanBaru, string senjataBaru, int jumlahSenjata, int kekuatan)
        //{
        //    this.nama = namaBaru; //this buat nunjuk variabel
        //    this.kesehatan = kesehatanBaru;
        //    this.senjata = senjataBaru;
        //    this.totalSenjata = jumlahSenjata;
        //    this.power = kekuatan;
        //}

        //public void getData()
        //{
        //    Console.WriteLine(nama);
        //    Console.WriteLine(kesehatan);
        //    Console.WriteLine(senjata);
        //    Console.WriteLine(totalSenjata);
        //    Console.WriteLine(power);
        //}

        public void getData()
        {
            Console.WriteLine($"Karakter : {nama}");
        }
       
        public void Healing(int tambahKesehatan)
        {
            kesehatan += tambahKesehatan ;
            Console.WriteLine($"Disembuhkan {kesehatan}");
        }

        public void Aksi(int posisiAwal)
        {
            Console.WriteLine("=== PILIH CARA BERMAIN ===");
            Console.WriteLine("1. Tombol Panah Keyboard");
            Console.WriteLine("2. Input Angka Posisi");
            Console.Write("Pilih mode (1/2): ");

            string pilihan = Console.ReadLine();

            int posisi = posisiAwal;

            if (pilihan == "1")
            {
                Console.WriteLine("== Mode Tombol Panah ==");
                Console.WriteLine("Panah Kanan = maju 2");
                Console.WriteLine("Panah Kiri = mundur 1");
                Console.WriteLine("ESC = keluar");
                Console.WriteLine($"Posisi Saat Ini : {posisi}");

                while (true)
                {
                    ConsoleKeyInfo tombol = Console.ReadKey(true);

                    if (tombol.Key == ConsoleKey.RightArrow)
                    {
                        posisi += 2;
                    }
                    else if (tombol.Key == ConsoleKey.LeftArrow)
                    {
                        if (posisi > 0)
                            posisi -= 1;
                        else
                            continue;
                    }
                    else if (tombol.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Permainan Berakhir");
                        break;
                    }
                    else
                    {
                        continue;
                    }

                    Console.WriteLine($"Posisi Saat Ini: {posisi}");
                }
            }

            else if (pilihan == "2")
            {
                Console.WriteLine("Mode Input Angka");
                Console.WriteLine($"Posisi Awal: {posisi}");

                while (true)
                {
                    Console.Write("Masukkan posisi barumu (ketik -1 untuk mengakhiri): ");

                    if (!int.TryParse(Console.ReadLine(), out int posisiBaru))
                    {
                        Console.WriteLine("Masukkan angka yang benar!");
                        continue;
                    }

                    if (posisiBaru == -1)
                    {
                        Console.WriteLine("Permainan Berakhir");
                        break;
                    }

                    if (posisiBaru < 0)
                    {
                        Console.WriteLine("Posisi tidak boleh kurang dari 0!");
                        continue;
                    }

                    posisi = posisiBaru;
                    Console.WriteLine($"Posisi Saat Ini : {posisi}");
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }
        }



    }


    class MainProgram
    {
        static void Main(string[] args)
        {
            //player Utama
            Karakter player1 = new Karakter("Kinan",100,10); //membuat objek (kalo udah ada constructor kita ga usah pake get data)
            //player1.nama = "Kinan";
            //player1.kesehatan = "Sehat";
            //player1.senjata = "Panah";
            //player1.totalSenjata = 3;
            //player1.power = 50;
            Karakter musuh = new Karakter("Nanana",100,100);
            player1.Serang(musuh); 
            musuh.Healing(20);
            player1.Aksi(0);
            //player1.getData();
            
          

            // kode sebelumnya 
            //Karakter karakter1 = new Karakter();
            //karakter1.nama = "Giant";
            //Console.WriteLine(karakter1.nama);

            //Karakter karakter2 = new Karakter();
            //karakter2.nama = "Goblin";
            //Console.WriteLine(karakter2.nama);

            //List<Karakter> daftaHero = new List<Karakter>(); // array menyimpan pahlawan
            //Karakter player1 = new Karakter();
            //player1.setNama("Archer","Sehat","Pedang", 3,99);
            ////player1.getData();

            //Karakter player2 = new Karakter();
            //player2.setNama("Artur","Kritis","Panah", 5,100);
            ////player2.getData();

            //// objek musuh
            //Karakter enemy = new Karakter();
            //enemy.setNama("Zombie", "Sedang", "Pisau", 2, 80);
            //enemy.getData();

            //Karakter enemy2 = new Karakter();
            //enemy.setNama("jikro", "Sedang", "Pistol", 3, 89);
            //enemy.getData();


            //daftaHero.Add(player1);
            //daftaHero.Add(player2);

            ////menampilkan data dari array, foreach
            //foreach(Karakter player in daftaHero)
            //{
            //    player.getData();l
            //}



        }

    }
}

