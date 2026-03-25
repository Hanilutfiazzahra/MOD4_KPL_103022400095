using System;

namespace Modul4_103022400095
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPLEMENTASI KODE PAKET");
            KodePaket kp = new KodePaket();

            Console.WriteLine("Kode Paket Basic = " + kp.GetKode("Basic"));
            Console.WriteLine("Kode Paket Standard = " + kp.GetKode("Standard"));
            Console.WriteLine("Kode Paket Premium = " + kp.GetKode("Premium"));
            Console.WriteLine("Kode Paket Unlimited = " + kp.GetKode("Unlimited"));
            Console.WriteLine("Kode Paket Gaming = " + kp.GetKode("Gaming"));
            Console.WriteLine("Kode Paket Streaming = " + kp.GetKode("Streaming"));
            Console.WriteLine("Kode Paket Family = " + kp.GetKode("Family"));
            Console.WriteLine("Kode Paket Business = " + kp.GetKode("Business"));
            Console.WriteLine("Kode Paket Student = " + kp.GetKode("Student"));
            Console.WriteLine("Kode Paket Traveler = " + kp.GetKode("Traveler"));

            Console.ReadLine();
            Console.WriteLine("IMPLEMENTASI MESIN KOPI");
            MesinKopi mk = new MesinKopi();
            mk.PowerOn();
            mk.StartBrew();
            mk.FinishBrew();
            mk.StartMaintenance();
            mk.FinishMaintenance();
            mk.PowerOff();
        }
    }
}
