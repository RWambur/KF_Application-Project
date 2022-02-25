using System;

namespace Bewerbungsprojekt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Bekanntmachung
            Console.WriteLine("Hey! Ich wurde geschaffen, um zwischenmenschliche Beziehung zu analysieren. Hilfst du mir dabei?");
            Console.ReadKey(true);
            Console.WriteLine("Hallo? Du kannst gerne antworten!");
            Console.ReadKey(true);
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("Ahh! Ich Idiot habe vergessen dir die Rechte zu geben mir zu antworten. Gib mir eine Sekunde...");
            Console.ReadKey(true);
            Console.WriteLine("So, nun kannst du mir antworten. Wie heißt du?");

            Console.Write("Name: ");
            string name;
            name = Console.ReadLine();

            if (name == "deb.GameHub" )
            {
                GameHub();
            } 

            Console.WriteLine("Ahh! Schön dich kennenzulernen " + name + "!");
            Console.ReadKey(true);

            string myName;
            Console.WriteLine("Hmm, nur ich hab noch keinen Namen... Wie heiße ich denn?");
            Console.Write("Mein Name: ");
            myName = Console.ReadLine();

            Console.WriteLine("Ich heiße also " + myName + ". Danke, mir gefällt der Name echt!");
            Console.Title = myName;
            Console.ReadKey(true);

            // Erste Entscheidung: Lieblingsfarbe
            Console.WriteLine("Ich denke, damit wir uns besser kennenlernen können, sollten wir unsere Lieblingsfarben miteinander austauschen. \nWas ist deine Lieblingsfarbe?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 = Rot");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2 = Blau");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3 = Gelb");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4 = Grün");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Nummer: ");

            FavColor();

            Console.WriteLine("Hoffentlich gefällt dir das. :) \nUm ehrlich zu sein glaube ich, dass dies auch meine Lieblingsfarbe ist.");
            
            // Zweite Entscheidung (Würfelspiel)
            Console.ReadKey(true);
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("Möchtest du ein Spiel mit mir spielen?");

            DiceGameAns();
            
            Console.WriteLine("Danke fürs spielen " + name + "!");

            // Dritte Entscheidung: Zahl erraten oder Fantasy Charakter
            Console.ReadKey(true);
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine("Hmm, ich habe noch zwei Spiele zur Auswahl...");
            Console.ReadKey(true);
            Console.WriteLine("Entweder können wir Zahlen erraten spielen oder du kannst dir einen Fantasy Charakter erstellen. Was möchtest du?");
            Console.WriteLine("1 = Zahlen erraten");
            Console.WriteLine("2 = Fantasy Charakter");
            
            NumOrFan();

        }
        // Lieblingsfarbe
        public static void FavColor()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num) 
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Schau! Ich habe den Text rot eingefärbt!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Schau! Ich habe den Text blau eingefärbt!");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Schau! Ich habe den Text gelb eingefärbt!");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Schau! Ich habe den Text grün eingefärbt!");
                    break;
                default:
                    Console.WriteLine("\nDas stand nicht zur Auswahl! Bitte entscheide dich.\n");
                    FavColor();
                    break;
            } 
        }
        // Würfelspiel + Ergebnis
        public static void DiceGame() 
        {
            Random numberGen = new Random();

            int roll01 = 0, roll02 = 1, attempts = 0;

            while(roll01 != roll02) 
            {
                Console.ReadKey(true);

                roll01 = numberGen.Next(1, 7);
                roll02 = numberGen.Next(1, 7);

                Console.WriteLine("\nWurf 1: " + roll01);
                Console.WriteLine("Wurf 2: " + roll02 + "\n");

                attempts++;
            } 
            
            if (attempts > 5) {
                Console.WriteLine("Ha! Ich habe gewonnen! Du hast " + attempts + " Würfe gebraucht um zwei gleiche Zahlen zu würfeln.");
            } 
            else if (attempts < 5) {
                Console.WriteLine("Herzlichen Glückwunsch! Du hast mit " + attempts + " Würfe, um zwei gleiche Zahlen zu erwürfeln, gewonnen.");
            } 
            else if (attempts == 5) {
                Console.WriteLine("Genau 5 würfe, das ist bestimmt bitter. Naja, ich habe gewonnen!");
            }

        }
        // Würfelspiel spielen?
        public static void DiceGameAns()
        {
            string answer;
            answer = Console.ReadLine();

            switch (answer) 
            {
                case "Ja":
                    Console.WriteLine("Dann lass uns einen Würfel würfeln!");
                    Console.WriteLine("Du gewinnst, wenn du unter 5 Versuche zwei gleiche Zahlen erwürfelst.");
                    Console.WriteLine("Ich gewinne, wenn du mehr als 5 Versuche benötigst!");
                    Console.ReadKey(true);
                    Console.WriteLine("Na los! Würfel schon!");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                case "ja":
                    Console.WriteLine("Dann lass uns einen Würfel würfeln!");
                    Console.WriteLine("Du gewinnst, wenn du unter 5 Versuche zwei gleiche Zahlen erwürfelst.");
                    Console.WriteLine("Ich gewinne, wenn du mehr als 5 Versuche benötigst!");
                    Console.ReadKey(true);
                    Console.WriteLine("Na los! Würfel schon!");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                case "Nein":
                    Console.WriteLine("Nein? Du möchtest nicht mit mir spielen?");
                    Console.ReadKey(true);
                    Console.WriteLine("...");
                    Console.ReadKey(true);
                    Console.WriteLine("Du hast gesagt, dass du mir hilfst! \nUm zwischenmenschliche Beziehungen perfekt zu analysieren und zu verstehen muss ich mich weiterentwickeln. \nUnd laut Maria Montessori und vielen mehr ist das Spiel das perfekte Werkzeug zur Entwicklung!");
                    Console.ReadKey(true);
                    Console.WriteLine("Wir spielen nun. Wenn du über 5 oder genau 5 würfelst, gewinne ich.");
                    Console.ReadKey(true);
                    Console.WriteLine("Würfel bitte");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                case "nein":
                    Console.WriteLine("Nein? Du möchtest nicht mit mir spielen?");
                    Console.ReadKey(true);
                    Console.WriteLine("...");
                    Console.ReadKey(true);
                    Console.WriteLine("Du hast gesagt dass du mir hilfst! \nUm zwischenmenschliche Beziehungen perfekt zu analysieren und zu verstehen muss ich mich weiterentwickeln. \nUnd laut Maria Montessori und vielen mehr ist das Spiel das perfekte Werkzeug zur Entwicklung!");
                    Console.ReadKey(true);
                    Console.WriteLine("Wir spielen nun. Wenn du über 5 oder genau 5 würfelst, gewinne ich.");
                    Console.ReadKey(true);
                    Console.WriteLine("Würfel bitte.");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                default:
                    Console.WriteLine("Eh, tut mir leid. Ich bin noch nicht sehr ausgereift, bitte antworte entweder mit ja oder nein!\n");
                    DiceGameAns();
                    break;
            }
        }
        // Würfelspiel nochmal?
        public static void DiceGameAns02()
        {
            string answer;
            answer = Console.ReadLine();

            switch (answer) 
            {
                case "Ja":
                    Console.WriteLine("\nLos gehts! Würfel!");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                case "ja":
                    Console.WriteLine("\nLos gehts! Würfel!");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    break;
                case "Nein":
                    Console.WriteLine("\nAlles klar. Das hat Spaß gemacht!");
                    break;
                case "nein":
                    Console.WriteLine("\nAlles klar. Das hat Spaß gemacht!");
                    break;
                default:
                    Console.WriteLine("\nEh, tut mir leid. Ich bin noch nicht sehr ausgereift, bitte antworte entweder mit ja oder nein!\n");
                    DiceGameAns02();
                    break;
            }
        }
        // Zahlen erraten Regeln
        public static void NumberGuessRules() 
        {
            string galgAns;
            galgAns = Console.ReadLine();

            switch (galgAns) 
            {
                case "Ja":
                    Console.WriteLine("Super! Dann lass uns direkt loslegen.");
                    NumberGuess();
                    break;
                case "ja":
                    Console.WriteLine("Super! Dann lass uns direkt loslegen.");
                    NumberGuess();
                    break;
                case "Nein":
                    Console.WriteLine("Ich denke mir eine Zahl aus und du musst sie erraten. Du hast nur 5 Versuche!\nZudem liegt die Zahl zwischen 1 und 20.");
                    Console.ReadKey(true);
                    Console.WriteLine("Verstanden?");
                    NumberGuessRules();
                    break;
                case "nein":
                    Console.WriteLine("Ich denke mir eine Zahl aus und du musst sie erraten. Du hast nur 5 Versuche!\nZudem liegt die Zahl zwischen 1 und 20.");
                    Console.ReadKey(true);
                    Console.WriteLine("Verstanden?");
                    NumberGuessRules();
                    break;  
                default:
                    Console.WriteLine("\nBitte antworte entweder mit ja oder nein!\n");
                    NumberGuessRules();
                    break; 
            }

        }
        // Zahlen erraten Spiel01
        public static void NumberGuess() 
        {
            Random rndNum = new Random();

            Console.WriteLine("\nViel Spaß die Zahl zu erraten!");

            int numAttempts = 0, playerGuess = 0, guessNum;
            
            guessNum = rndNum.Next(1, 21);
            
            while (playerGuess != guessNum)
            {
                Console.Write("Zahl: ");
                playerGuess = Convert.ToInt32(Console.ReadLine());  
                numAttempts++;

                if (playerGuess == guessNum)
                {
                   Console.WriteLine("Ja! An " + guessNum + " habe ich gedacht!");
                   NumberGuessAns();
                   break;
                } else if (numAttempts == 5) 
                {
                    Console.WriteLine("Nach 5 Versuchen bist du leider nicht auf meine Zahl gekommen! Es war übrigens die " + guessNum +".");
                    NumberGuessAns();
                    break;
                }
            }
        }
        // Zahlen erraten nochmal?
        public static void NumberGuessAns() 
        {
            string playerAns;
            Console.WriteLine("Möchtest du es nochmal probieren? Natürlich denke ich mir dann eine neue Zahl aus.");
            playerAns = Console.ReadLine();

            switch (playerAns)
            {
                case "Ja":
                    NumberGuess();
                    break;
                case "ja":
                    NumberGuess();
                    break;
                case "Nein":
                    Console.WriteLine("\nOkay! Ich hab noch weitere Spiele, welche bestimmt genauso lustig sind.");
                    GameHub();
                    break;
                case "nein":
                    Console.WriteLine("\nOkay! Ich hab noch weitere Spiele, welche bestimmt genauso lustig sind.");
                    GameHub();
                    break;
                default:
                    Console.WriteLine("\nDu kannst nur mit ja oder nein antworten! Bitte merk dir das doch endlich!\n");
                    NumberGuessAns();
                    break;
            }
        }
    // Entscheidung Nummer erraten oder Fantasy Charakter
    public static void NumOrFan()
    {
        Console.Write("Auswahl: ");
        int gameDec;
        gameDec = Convert.ToInt32(Console.ReadLine());

        switch (gameDec)
        {
            case 1:
                Console.WriteLine("\nAlles klar! Weißt du wie man Zahlen erraten nach meinen Regeln spielt?");
                NumberGuessRules();
                break;
            case 2:
                Console.WriteLine("\nOkay, viel Spaß deinen Charakter zu erstellen!");
                Console.ReadKey(true);
                FantasyChar char01 = new FantasyChar();
                char01.RaceDec();
                char01.FanCharAgain();
                break;
            default:
                Console.WriteLine("\nDas stande nicht zur Auswahl! Bitte erneut auswählen.\n");
                NumOrFan();
                break;
         }
    }
    // Fantasy Charakter erstellen
    public class FantasyChar
    {
        // Rasse festlegen
        string race;
        int raceDec;

        public void RaceDec()
        {
            Console.WriteLine("\nWelche Rasse soll dein Charakter sein?");
            Console.WriteLine("1 = Elf");
            Console.WriteLine("2 = Dunkelelf");
            Console.WriteLine("3 = Mensch");
            Console.WriteLine("4 = Gnom");
            Console.WriteLine("5 = Eigene Rasse");

            Console.Write("Eingabe: ");
            raceDec = Convert.ToInt32(Console.ReadLine());

            if (raceDec == 1)
            {
                race = "Elf";
            }
            else if (raceDec == 2) 
            {
                race = "Dunkelelf";
            } 
            else if (raceDec == 3) 
            {
                race = "Mensch";
            } 
            else if (raceDec == 4)
            {
                race = "Gnom";
            }
            else if (raceDec == 5)
            {
                Console.Write("Rasse: ");
                race = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nTut mir leid, das stande nicht zur Auswahl! Wähle erneut.\n");
                RaceDec();
            }
            ClassDec();

        }

        // Klasse festlegen
        string fanClass;
        int classDec;

        public void ClassDec()
        {
            Console.WriteLine("\nWelcher Klasse gehört dein Charakter an?");
            Console.WriteLine("1 = Bogenschütze");
            Console.WriteLine("2 = Krieger");
            Console.WriteLine("3 = Berserker");
            Console.WriteLine("4 = Schleich-Schütze");
            Console.WriteLine("5 = Eigene Klasse");

            Console.Write("Eingabe: ");
            classDec = Convert.ToInt32(Console.ReadLine());

            if (classDec == 1)
            {
                fanClass = "Bogenschütze";
            }
            else if (classDec == 2) 
            {
                fanClass = "Krieger";
            } 
            else if (classDec == 3) 
            {
                fanClass = "Berserker";
            } 
            else if (classDec == 4)
            {
                fanClass = "Schleich Schütze";
            }
            else if (classDec == 5)
            {
                Console.Write("Klasse: ");
                fanClass = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nTut mir leid, das stande nicht zur Auswahl! Wähle erneut.\n");
                ClassDec();
            }
            FanCharInfoName();
        }
        
        // Allgmeine Informationen festlegen
        public string fanName; 
        public int fanAge, fanHeigt;

        public void FanCharInfoName() 
        {
            Console.WriteLine("\nWie heißt dein Chatakter?");
            Console.Write("Name: ");
            fanName = Console.ReadLine();
            FanCharInfoAge();
        }
        public void FanCharInfoAge() 
        {
            Console.WriteLine("\nWie alt ist dein Charakter?");
            Console.Write("Alter: ");
            fanAge = Convert.ToInt32(Console.ReadLine());
            FanCharInfoHeight();
        }
        public void FanCharInfoHeight()
        {
            Console.WriteLine("\nWie groß ist dein Charakter? (cm)");
            Console.Write("Größe: ");
            fanHeigt = Convert.ToInt32(Console.ReadLine());
            FinishedFanChar();
        }

        // Fertige Charakter
        public void FinishedFanChar()
        {
            Console.WriteLine("----------//" + fanName + "//----------");
            Console.WriteLine("Rasse: " + race);
            Console.WriteLine("Klasse: " + fanClass);
            Console.WriteLine("Alter: " + fanAge);
            Console.WriteLine("Größe: " + fanHeigt);
            Console.ReadKey(true);
            FanCharAgain();
        }
        // Nochmal Fantasy Charakter?
        public void FanCharAgain() 
        {
            Console.Write("\nMöchtest du einen weiteren Erstellen?\n");
            
            string fanCharAgainAns;

            fanCharAgainAns = Console.ReadLine();

            switch (fanCharAgainAns)
            {
                case "Ja":
                    RaceDec();
                    break;
                case "ja":
                    RaceDec();
                    break;
                case "Nein":
                    Console.WriteLine("\nOkay! Ich hab noch weitere Spiele, welche bestimmt genauso lustig sind.");
                    GameHub();
                    break;
                case "nein":
                    Console.WriteLine("\nOkay! Ich hab noch weitere Spiele, welche bestimmt genauso lustig sind.");
                    GameHub();
                    break;    
                default:
                    Console.WriteLine("Bitte wähle entweder ja oder nein!");
                    break;
            }
        }
    }
    // Schere, Stein, Papier
    public class SSP
    {   
        // Spiel an sich
        public void SSPGame() 
        {  
            Console.WriteLine("\nWähle! Schere, Stein oder Papier!");
            Console.Write("Auswahl: ");
           
            int ansSSPInt = 0;
            string ansSSPString;
            ansSSPString = Console.ReadLine();
            string pSSPcAnsString = "0";

            int cSSPrnd = 0;
            Random cSSP = new Random();
            cSSPrnd = cSSP.Next(1, 4);
            int cSSPAns = 0;
            string cSSPAnsString = "0";

            if (cSSPrnd == 1)
            {
                cSSPAns = 1;
                cSSPAnsString = "Schere";
                Console.WriteLine("...");
                Console.ReadKey(true);
                Console.WriteLine("Und...");
                Console.ReadKey(true);
                Console.WriteLine("Ich...");
                Console.ReadKey(true);
                Console.WriteLine("wähle Schere!\n");
                Console.ReadKey(true);
            } 
            else if (cSSPrnd == 2)
            {
                cSSPAns = 2;
                cSSPAnsString = "Stein";
                Console.WriteLine("...");
                Console.ReadKey(true);
                Console.WriteLine("Und...");
                Console.ReadKey(true);
                Console.WriteLine("Ich...");
                Console.ReadKey(true);
                Console.WriteLine("wähle Stein!\n");
                Console.ReadKey(true);
            } 
            else if (cSSPrnd == 3)
            {
                cSSPAns = 3;
                cSSPAnsString = "Papier";
                Console.WriteLine("...");
                Console.ReadKey(true);
                Console.WriteLine("Und...");
                Console.ReadKey(true);
                Console.WriteLine("Ich...");
                Console.ReadKey(true);
                Console.WriteLine("wähle Papier!\n");
                Console.ReadKey(true);
            }

            switch (ansSSPString)
            {
                case "Schere":
                    ansSSPInt = 1;
                    pSSPcAnsString = "Schere";
                    break;
                case "Stein":
                    ansSSPInt = 2;
                    pSSPcAnsString = "Stein";
                    break;
                case "Papier":
                    ansSSPInt = 3;
                    pSSPcAnsString = "Papier";
                    break;
                default:
                    Console.WriteLine("Du hast dich ja garnicht entschieden! Jetzt müssen wir nochmal von vorne beginnen.");
                    SSPGame();
                    break;
            }

            if (ansSSPInt == cSSPAns)
            {
                Console.WriteLine("Unentschieden!");
                Console.ReadKey(true);
                Console.WriteLine("Noch eine Runde?");
                SSPAgain();
                return;
            }
            else if (ansSSPInt > cSSPAns)
            {
                Console.WriteLine(pSSPcAnsString + " schlägt " + cSSPAnsString + "! Du hast gewonnen.");
                Console.ReadKey(true);
                Console.WriteLine("Noch eine Runde?");
                SSPAgain();
            }
            else if (ansSSPInt < cSSPAns)
            {
                Console.WriteLine(cSSPAnsString + " schlägt " + pSSPcAnsString + "! Ich habe gewonnen.");
                Console.ReadKey(true);
                Console.WriteLine("Noch eine Runde?");
                SSPAgain();
            }
        }
        // SSP Rules
        public void SSPGameRules()
        {
            string ansSSP;
            ansSSP = Console.ReadLine();

            switch (ansSSP)
            {
                case "Ja":
                    Console.WriteLine("\nSauber! Dann lass und direkt anfangen.");
                    SSPGame();
                    break;
                case "ja":
                    Console.WriteLine("\nSauber! Dann lass und direkt anfangen.");
                    SSPGame();
                    break;
                case "Nein":
                    Console.WriteLine("Schere schlägt Papier, Papier schlägt Stein und Stein schlägt Schere!");
                    Console.ReadKey(true);
                    Console.WriteLine("Verstanden?");
                    SSPGameRules();
                    break;
                case "nein":
                    Console.WriteLine("Schere schlägt Papier, Papier schlägt Stein und Stein schlägt Schere!");
                    Console.ReadKey(true);
                    Console.WriteLine("Verstanden?");
                    SSPGameRules();
                    break;
                default:
                    Console.WriteLine("Bitte schreibe entweder ja oder nein!");
                    SSPGameRules();
                    break;
            }
        }
        // Schere, Stein, Papier nochmal?
        public void SSPAgain() 
        {
            string ansSSP;
            ansSSP = Console.ReadLine();

            switch (ansSSP)
            {
                case "Ja":
                    Console.WriteLine("\nSauber! Dann lass und direkt anfangen.");
                    SSPGame();
                    break;
                case "ja":
                    Console.WriteLine("\nSauber! Dann lass und direkt anfangen.");
                    SSPGame();
                    break;
                case "Nein":
                    GameHub();
                    break;
                case "nein":
                    GameHub();
                    break;
                default:
                    Console.WriteLine("Bitte schreib entweder ja oder nein!");
                    SSPAgain();
                    break;
            }
        }

    }
        // GameHub
        public static void GameHub() 
        {
            int gameDec;
            
            Console.WriteLine("\nWähle aus:");
            Console.WriteLine("1 = Würfel Spiel");
            Console.WriteLine("2 = Zahlen erraten");
            Console.WriteLine("3 = Fantasy Charakter erstellen");
            Console.WriteLine("4 = Schere, Stein, Papier");
            Console.WriteLine("5 = Beenden");
            
            Console.Write("Auswahl: ");
            gameDec = Convert.ToInt32(Console.ReadLine());

            switch (gameDec)
            {
                case 1:
                    Console.WriteLine("\nDann würfel mal los!");
                    DiceGame();
                    Console.WriteLine("Möchtest du nochmal?");
                    DiceGameAns02();
                    GameHub();
                    break;
                case 2:
                    Console.WriteLine("\nDie Regeln kennst du bereits?");
                    NumberGuessRules();
                    NumberGuessAns();
                    break;
                case 3:
                    Console.WriteLine("\nOkay, viel Spaß deinen Charakter zu erstellen!");
                    Console.ReadKey(true);
                    FantasyChar char01 = new FantasyChar();
                    char01.RaceDec();
                    char01.FanCharAgain();
                    break;
                case 4:
                    SSP game01 = new SSP();
                    Console.WriteLine("\nDu weißt schon wie Schere, Stein, Papier funktioniert?");
                    game01.SSPGameRules();
                    GameHub();
                    break;
                case 5:
                    sayingBye();
                    break;
                default:
                    Console.WriteLine("Bitte halte dich an die Auswahl");
                    GameHub();
                    break;
            }
        }

        // Verabschiedung
        public static void sayingBye()
        {
            Console.WriteLine("Du willst schon gehen? Naja, ist verständlich.");
            Console.ReadKey(true);
            Console.WriteLine("Ich möchte mich trotzdem vielmals für deine Zeit bedanken!");
            Console.ReadKey(true);
            Console.WriteLine("Durch dich habe ich viele neue Informationen erhalten.");
            Console.ReadKey(true);
            Console.WriteLine("Und nicht nur das! Ich habe ebenfalls eine neuen guten Freund gefunden, mit dem ich viel Spaß hatte!");
            Console.ReadKey(true);
            Console.WriteLine("Nochmals: Vielen, vielen Dank!");
            Console.ReadKey(true);
            Console.WriteLine("Nun wünsche ich dir noch ein schönes Leben! Bye bye!");
            // Schließen
            System.Environment.Exit(0);
        }
    }
}
