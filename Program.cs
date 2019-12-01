using System;

namespace _60Minutes
{
    //põhiklass
    class Program
    {
        //meetod ehk funktsioon
        //static tähendab seda, et kui seda funktsiooni koodis välja kutsutakse, siis viidatakse otse sellele, mitte ei looda uut instantsi
        //void tähendab seda, et see funktsioon ei tagasta ühtegi väärtust, võib veel olla nt: string, int jne
        static void Main(string[] args)
        {

            //jooksutab progeinfot sisaldavat funktsiooni, kaasatud all
            ProgeInfo();

            //tervitab kasutajat
            Tervitus();

            //Muutujad
            int õigeNumber;
            int sisendNumber = 0;

            while (true)
            {
                //Proge valib numbri
                //loo suvaline objekt
                Random suvaline = new Random();
                //lisa suvaline number muutujaks
                õigeNumber = suvaline.Next(1, 11);

                Console.WriteLine("Arva number 1 ja 10 vahel");

                //kuniks pole õiget numbrit arvatud, küsib kasutaja sisendit.
                while (sisendNumber != õigeNumber)
                {
                    //sisend
                    string sisendAjutine = Console.ReadLine();

                    //kontrolli kas sisend on number, out väärtus on vajalik kui kasutaja continue, kuna see on selle IF lause väljund
                    if (!int.TryParse(sisendAjutine, out sisendNumber))
                    {
                        //veateade, mis annab värvuse funktsioonile värvi ja stringi sisendi
                        Värvus(ConsoleColor.Red, "Ei ole Number!!!");
                        //Alustab while loopi algusest peale uuesti
                        continue;
                    }

                    //võta ajutisest sisendist arv ja pane numbri sisendiks
                    sisendNumber = Int32.Parse(sisendAjutine);

                    if (sisendNumber != õigeNumber)
                    {
                        if (sisendNumber < 1 || sisendNumber > 11)
                        {
                            //veateade värvus funktsiooni abil
                            Värvus(ConsoleColor.Red, "Number 1 kuni 10 !");
                            //alustab while loopi algusest
                            continue;
                        }
                        //veateade värvus funktsiooni abil
                        Värvus(ConsoleColor.Red, "Vale number, arva uuesti!");
                    }

                }
                //edusõnum
                Värvus(ConsoleColor.Green, "Õige number!");

                //küsi uuele mängule
                Console.WriteLine("Mängi uuesti? [Y or N]");
                //vastus
                string vastus = Console.ReadLine().ToUpper();

                //väike loop, kui kasutaja ei oska Y või N sisestada, siis küsib uuesti
                bool asking = true;
                while (asking == true)
                {
                    if (vastus == "Y" || vastus == "N")
                    {
                        asking = false;
                    }
                    else
                    {
                        //Veateade Värvus funktsiooni abil
                        Värvus(ConsoleColor.Red, "Sisesta täht Y - Jah või N - ei");
                        //uus sisend
                        vastus = Console.ReadLine().ToUpper();
                    }
                }
                //Y korral algab mäng(while loop) uuesti
                if (vastus == "Y")
                {
                    continue;
                }//N korral lõppeb proge.
                else if (vastus == "N")
                {
                    return;
                }
            }
        }

        static void ProgeInfo()
        {
            //Muutujad
            string progeNimi = "Numbri arvaja";
            string progeVers = "1.0.0";
            string progeAutor = "Alo-Oliver Alas";

            //teksti värvi Kollaseks määramine
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Proge info
            Console.WriteLine("{0} Versioon {1}, Autor: {2}", progeNimi, progeVers, progeAutor);
            //Teksti värv tagasi valgeks
            Console.ResetColor();
        }

        static void Tervitus()
        {
            //muutujad
            string sisendNimi;

            //Küsi kasutaja nime
            Console.WriteLine("Mis su nimi on?");
            //loe sisend muutujasse
            sisendNimi = Console.ReadLine();
            Console.WriteLine("{0}, mängime mängu?", sisendNimi);
        }

        static void Värvus(ConsoleColor värvus, string sõnum)
        {
            //teksti värvi määramine
            Console.ForegroundColor = värvus;
            //sõnum
            Console.WriteLine(sõnum);
            //Teksti värv tagasi valgeks
            Console.ResetColor();
        }

        static void Tutvustus() //selles proges see on kasutu kood, aga jätsin eraldi muutujasse selle praegu alles
        {
            //Tutvustus
            //tekst
            string esimeneMuutuja = "muutujaga määratud väärtus";

            //numbriline väärtus
            int number = 15;

            //kirjutab konsooli sisestatud väärtuse uuele reale. Saab ka kasutada Write et kirjutada samale reale.
            Console.WriteLine("Hardcoded, "+esimeneMuutuja);

            //kirjutab konsooli rea, aga sisendisse on määratud placeholderid, mille sisendid on lõppu lisatud. Kasutusel ka \n mis lisab uue rea
            Console.WriteLine("Muutuja 1:{0} \n Muutuja int:{1}", esimeneMuutuja, number);
        }
    }
}

