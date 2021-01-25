using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri) {
            Console.WriteLine(musteri.firstName + " : " + musteri.lastName + " : " +  " sisteme eklendi!");   
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri + " sistemden silindi!");
        }
        public void List() { 
        
            
        }
    }
}
