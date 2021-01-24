    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            Gamermanager manager = new Gamermanager();
            İkampanya_servis kampanyam = new Kampanya();
            gamer1.Adi = "kadir";
            gamer1.Soy_adi = "öz";
            gamer1.tc_no = "11111111111";
            gamer1.eposta = "coderkadir_01@gmail.com";
            manager.ekle(gamer1);
            manager.guncelle(gamer1);
            manager.satınal(gamer1, kampanyam);
        }
    }
}
