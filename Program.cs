using System;

namespace Methods_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usersInput = "";
            while (usersInput != "q") 
            {

          
            
                Console.Clear();
                Console.WriteLine("Press '1' to run ASCII");
                Thread.Sleep(500);
                Console.WriteLine("Or press '2' to run ASCII");
                usersInput = Console.ReadLine().ToLower().Trim(); 
                if (usersInput == "1")
                {
                    theThreeASCII();
                }
                else if (usersInput == "2")
                {
                    Console.WriteLine("You chose option 2");
                }
                else 
                {
                    Console.WriteLine("");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"{usersInput} IS NOT A VALID INPUT");
                    Console.WriteLine("Click enter to try again");
                    Console.ReadLine();
                }




                
            }      
        }


        public static void theThreeASCII()
        {
            Console.WriteLine("`/+o/.");
            Console.WriteLine(".+sso+/:oydyo/:-:+shdys/    `-:.     `-/+o+/`");
                 Console.WriteLine("`/ sdh+/::/::ss:`ymdhyso//hmMNyhNNms+osoys+/-:/shms");
                Console.WriteLine(".+hNNy++oo+/.`.--/osyhdmNNMMMMMMMMMNdsssssoso+hhhhsoo+ymdo");
              Console.WriteLine("- smNy/+ymmmmmNNNNMNMMMMMNNNmmNMMMMMMMMMho:///:--shydNMMNdo-sNs");
            Console.WriteLine("- hNd+-sNMNdmNMMMNNNMNNNMMMddNMMNNmNMMMMMMNmy+///::/:-:/++ymNNdmMN");
          Console.WriteLine("`sNMs`+NMNNNMMMMNNNMMMMMMNmhyso///+ohMmoNMmoo+/::/-:oymNNmsosshdhmMM");
         Console.WriteLine("+ NMMy`hMMMhyNMNMMNNNMds:-.`-:syddmNMMmyo`+yMMho:..-+//++");
       Console.WriteLine(":mMMMh`yMNdodNNNMNMMMs.+sdmmmmmdhNMMMNhy/..`-syhNmdyssso+/.`:");
      Console.WriteLine(":NMNh:-+MMh+mdNNNNNMd.+NNMMMMMMMMmho:-......:--::ohNMMMMMMNmNy/.");
     Console.WriteLine(":NMm +/dmmMNydyhNdhMMN.yMMNmhysso+:-``        ```.--:/+sdMMMMMNNNm:-");
    Console.WriteLine(":NMy /hNMMMMmNddsh/NmMy-Mms:..`.--.`                ``..-.:yNMMMMNMNs:");
   Console.WriteLine(":NNy /mMMMMMMmNMMshsNdMo/d-...``                       ```...-yMMMNNMd`NMMNMdmoNMM");
  Console.WriteLine("/ mMm+NMNNMMNMNNNNNNNNMMmom/                              ```..`+NMMMMh`");
 Console.WriteLine("+ NMMmmMNyNMNMMMMMNmmmNMdNNyh+.                             ``````/NMMM::");
Console.WriteLine("+ MNNMMMNymMNNMMMNNNNNMh+:+dNmddhyoo+`                        ````.`sMMN`");
Console.WriteLine("dNNNMNNddMNNNNNNmymMN +---::/shdhyyy:                         `````..hMo.");
Console.WriteLine("dNNNMMNmNNNmmNMNdNMM +.-..----.-:::.                          ````...:mh/");
Console.WriteLine("sMNNMMNMNNmyNMNdmNMo--.....                                  ``...---:dNMNMMNMMNNNMMN");
Console.WriteLine(":NNNMMMNNNsmMNmMNMy...`.-.`                                    `.-----:");
Console.WriteLine(".NMMMmMMMNmMNNNNMm:-.```..                                       ``-----:/o//");
Console.WriteLine(".NMMMNMMNMMNMNNNNs--.``...                                         `....---..dMNMMMMM");
Console.WriteLine("NNMMNNNNNMMMNNNN:-...`...                                          ```.....`+MMMMMMM");
Console.WriteLine("MNNNNNNNMMMMMNNy.......-.`                                         ``..---.`.NMMMMMM");
Console.WriteLine("NMNMMNNNMMNMMMm -...`.-----.`                                        ``.-----.`");
 Console.WriteLine("`-....----..`          ``                      `.`` ```.------`:MMMMM");
 Console.WriteLine(" MMNMNNNMMNMMN-`.`..-.--.` `--..-:-.-.``..``               ```.-......--.----..");
 Console.WriteLine("mMNMNNMMMNNMN.``...-.-../hddyysyhysyyso+--/::-..--...----:::+syyyyhhdddy+:-.-.hMMM");
Console.WriteLine(":NNNNNNMMMMMN.`....--.:dy/:-.-/+++ososss+/:+shyo/::/:+os+:+syosyoso+/://ss//.`+");
   Console.WriteLine(" MdmNNMNMMMN+.--....:+-.-:+ooymdddmdhyo++ss+/yMo.`..oNsyhdhmdmmmmNmdo:-.--:+-:MM");
  Console.WriteLine("y /..-+dNNMMMo-shhyo++--+sso-`dsymoso.smyso+//.od+/:/ho+yyhd/ymsNhyy./yy/``.-hhmm");
  Console.WriteLine("s+md+- oMMMm``.-/sy//-.+/s.  odys+s-  /shyso+.sm+:::yd/hh+:`.hyyhy- `/y/.` `hs/s");
  Console.WriteLine(" oyMNyhs:NMMo     `.-`         .---` ``.`/::+s/ms````-mo+:`````.--` ````     `sNm");
Console.WriteLine("`hsMh`.hymMM:       `-         `          .:+:hy`     od:-`                  .+sM");
   Console.WriteLine("o +o/``-/mMM-        .-                ``.```hy`       s.`.`                 -/+M");
   Console.WriteLine("s `./NMMMM-         --            ````  `:ho`        .s`  ```             ./.+My");
    Console.WriteLine(": `+MMdMM/          -.  `       `   ..+++-           :d/.             ``:o-`");
Console.WriteLine("o. .sdNMMm`            `--:://+//.`-///:.           `.ohooo:-.`` `.-:+//:..`");
     Console.WriteLine("s```.yMMMs                  ```     .y+  `::.:----.-``o:-::/:::--:::-----..");
Console.WriteLine(":s` `oMNMN-                         :N+  -NNhy/:/sds./:..----------------`");
Console.WriteLine("+ o``-NMNMd`                      `-syyoo++/.++:so/+yN+..--....-..-....--`dM");
        Console.WriteLine(":.`oMNNN`                     .:-` `.::.` `--..---/+/---.```........-.:d");
         Console.WriteLine("/++Ny::`                   `--`          .--..-----::-..```......---.s");
           Console.WriteLine(":os.--`                  .`            `.. ``.------.`.```..-----.:");
Console.WriteLine("`h -..`                 ``        .:syy/-/ydho-.--...`````.------.+.");
              Console.WriteLine(" o`.`                        ./ymNNNNNNNmmNNNh:....``.```.-----:");
              Console.WriteLine("h -`.                    -/+oyo/:----:---.--:+sso");
               Console.WriteLine(" d...                 `.++:  -:--/+:/oo+o++-.``--.....-----:-:");
               Console.WriteLine("`Md:.`                ``     `-:/+ooooo+/-........-----------");
Console.WriteLine("mNNs -`                     `..-/oo+://:/oo:......----------");
                Console.WriteLine(":+md:.                  ...``.`         ");
               Console.WriteLine("h..-+ddo.`                            ``.----------------s");
               Console.WriteLine("h` .--/ydy:`                   `...--------------------+y");
               Console.WriteLine("h`   ..--+yds+.`               `....----------------:+dN");
               Console.WriteLine("y      `.-.-:sdhs:.`    `...````..----------------:");
               Console.WriteLine("h         .--..-+ymdy+/:----:----------------.-/shs+.`");
               Console.WriteLine("h           `..--..:sdmmhyo/::----------::/+syhy");
               Console.WriteLine(" y              `..--..--/oosyyyhhhyyyssoooo/:.`...`.` ");
               Console.WriteLine(".                  `..--.......................````   ");
                                      Console.WriteLine("`...------..-.........``");
                                          Console.WriteLine("``..-.--........``");
                                              Console.WriteLine("```..```");


            Console.ReadLine();

        }
    }
}