using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day2.Lib
{
    // Huis, Ramen en deuren, 


    

    public class BankRekening
    {
        public BankRekeningNummer Nummer = new BankRekeningNummer();
    }

    public class Bank
    {
        public string Naam { get; private set; }

        private List<BankRekening> _rekeningen = new List<BankRekening>();

        public Bank()
        {
            //_rekeningen = new List<BankRekening>();
        }
        public Bank(string naam)
            : this()
        {
            Naam = naam;

        }   

        public void VoegRekeningToe(BankRekening rekening)
        {
            _rekeningen.Add(rekening);
        }


        public static void BankDemo()
        {
            var bank = new Bank("Conclusion Bank");
            ChangeBank(bank);

            var nummer = new BankRekeningNummer();
            ChangeNummer(ref nummer);

            int x = 0;
            ChangeInt(x);

            return;
        }

        static void ChangeBank(Bank bank)
        {

            bank.VoegRekeningToe(new BankRekening());

        }
        static void ChangeNummer(ref BankRekeningNummer nummer)
        {

            nummer.code = "123";

        }

        static void ChangeInt(int bla)
        {
            bla = 100;
        }
    }
}
