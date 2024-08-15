using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractExample
{
    public abstract class CompanyInfo
    {

        public string Name { get; set; }

        public string Surname { get; set; }


        public string Position { get; set; }

        public CompanyInfo()
        {
            Console.WriteLine("Adınız:");
            Name = Console.ReadLine();
             
            Console.WriteLine("Soyadınız:");
            Surname = Console.ReadLine();
 
            Console.WriteLine("Çalıştığınız pozisyon:");
            Position = Console.ReadLine();

        }
        public abstract void Job();
    }

    public class JobInfo : CompanyInfo
    {

        public override void Job()
        {
            Console.WriteLine($"{Name} {Surname} {Position} olarak çalışıyorum");
        }
    }



}
