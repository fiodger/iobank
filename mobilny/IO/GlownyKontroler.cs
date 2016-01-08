using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{   
    public class GlownyKontroler
    {
        public PrzelewyKontroler przelewyKontroler;
        public PomocKontroler pomocKontroler;       
        public LoginKontroler loginKontroler;

        public GlownyKontroler()
        {
            przelewyKontroler = new PrzelewyKontroler();
            pomocKontroler = new PomocKontroler();           
            loginKontroler = new LoginKontroler();
        }

     public bool przekazDoLoginKontroler(String login,String password){

         return loginKontroler.zaloguj(login, password);
        

    }
   
    public void przekazDoPomocKontroler(String tresc){
         pomocKontroler.wyslij(tresc);
    }
    public bool przekazDoPrzelewyKontroler(String numer, String daneOdbiorcy, String tytul, String kwota)
    {

       return przelewyKontroler.wyslijPrzelew(numer, daneOdbiorcy, tytul, kwota);
    }

    }
}
