using System;
using System.Threading;

namespace Praktik_threadskull2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jasa Expedisi Paket");
            //Thread agung = new Thread(karyawan1);
            //Thread bayu = new Thread(karyawan2);
            //Thread candra = new Thread(karyawan3);
            //Thread dani = new Thread(karyawan4);
            //Thread eliza = new Thread(karyawan5);
            Thread agung = new Thread(new ThreadStart(Thread_perawat.karyawan1));
            Thread bayu = new Thread(new ThreadStart(Thread_perawat.karyawan2));
            Thread candra = new Thread(new ThreadStart(Thread_perawat.karyawan3));
            Thread dani = new Thread(new ThreadStart(Thread_perawat.karyawan4));
            Thread eliza = new Thread(new ThreadStart(Thread_perawat.karyawan5));


            agung.Start();
            bayu.Start();
            candra.Start();
            dani.Start();
            eliza.Start();
        }
    }
    public class Thread_perawat
    {
        public static void karyawan1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Agung mengantarkan paket ke -> {0}", i);
                Thread.Sleep(180000);
            }
            Console.WriteLine("Agung selesai melakukan tugasnya");

        }
        public static void karyawan2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Bayu mengantarkan paket ke -> {0}", i);
                Thread.Sleep(180000);
            }
            Console.WriteLine("Bayu selesai melakukan tugasnya");

        }
        public static void karyawan3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Candra mengantarkan paket ke -> {0}", i);
                Thread.Sleep(180000);
            }
            Console.WriteLine("Candra selesai melakukan tugasnya");

        }
        public static void karyawan4()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Dani mengantarkan paket ke -> {0}", i);
                Thread.Sleep(300000);
            }
            Console.WriteLine("Dani selesai melakukan tugasnya");

        }
        public static void karyawan5()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Eliza mengantarkan paket ke -> {0}", i);
                Thread.Sleep(300000);
            }
            Console.WriteLine("Eliza selesai melakukan tugasnya");

        }
    }
}
