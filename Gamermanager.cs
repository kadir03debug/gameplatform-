using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_demo
{
    class Gamermanager
    {
        public void ekle(Gamer g) { Console.WriteLine("eklendi"); }
        public void guncelle(Gamer g ) { Console.WriteLine("güncellendi"); }
        public void satınal(Gamer g , İkampanya_servis servisim ) { Gamer.satis_puanı++;servisim.hesapla(g ); Console.WriteLine("satışyapıldı"); }
              }
    }
