using System;
using System.Threading;

namespace intro_to_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            do
            {
                Console.WriteLine("What would you like to do? (type the number in the square brackets)");
                Console.WriteLine("[1] Sing a song");
                Console.WriteLine("[2] Draw a picture");
                Console.WriteLine("[3] Hear a joke");
                Console.WriteLine("[4] Quit");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    default:
                        Console.WriteLine("That wasn't an option...");
                        break;
                    case 1:
                        Console.WriteLine("Alright, but first, can you give me a number?");
                        int.TryParse(Console.ReadLine(), out int count);
                        while (count < 1) {
                            Console.WriteLine("I need it to be a positive whole number.");
                            int.TryParse(Console.ReadLine(), out count);
                        }
                        while (count > 0)
                        {
                            Joke(count);
                            count -= 1;
                            Thread.Sleep(800);
                        }
                        Console.WriteLine("Okay... we're done now");
                        break;
                    case 2:
                        int pic = 0;
                        while ((pic < 1) || (pic > 3))
                        {
                            Console.WriteLine("Which picture would you like?");
                            Console.WriteLine("[1] Birds");
                            Console.WriteLine("[2] Saturn");
                            Console.WriteLine("[3] Chess");
                            int.TryParse(Console.ReadLine(), out pic);
                        }
                        Console.WriteLine("Where should it go?");
                        Console.Write("x position: ");
                        int.TryParse(Console.ReadLine(), out int x);
                        Console.Write("y position: ");
                        int.TryParse(Console.ReadLine(), out int y);
                        switch (pic)
                        {
                            case 1:
                                DrawBirds(x, y);
                                break;
                            case 2:
                                DrawSaturn(x, y);
                                break;
                            case 3:
                                DrawChess(x, y);
                                break;

                        }
                        break;
                    case 3:
                        Knock();
                        break;
                    case 4:
                        Console.WriteLine("goodbye");
                        done = true;
                        break;
                }
            } while (!done);
        }
        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }
        public static void Joke(int numBugs)
        {
            Console.WriteLine("");
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(800);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(800);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(800);
            Console.WriteLine((numBugs - 1) + " little bugs in the code.");
        }
        public static void DrawBirds(int xpos, int ypos)
        {
            int starty = Console.CursorTop;
            Console.SetCursorPosition(xpos, ypos);
            Console.Write("   ___     ___      ");
            Console.Write("  _    ");
            Console.SetCursorPosition(xpos, ypos + 1);
            Console.Write("  (o o)   (o o)     ");
            Console.Write(">(.)__ ");
            Console.SetCursorPosition(xpos, ypos + 2);
            Console.Write(" (  V  ) (  V  )    ");
            Console.Write(" (___/ ");
            Console.SetCursorPosition(xpos, ypos + 3);
            Console.Write("/--m-m- /--m-m-     ");
            Thread.Sleep(500);
            Console.SetCursorPosition(0, starty + 1);
        }
        public static void DrawSaturn(int xpos, int ypos)
        {
            int starty = Console.CursorTop;
            Console.SetCursorPosition(xpos, ypos);
            Console.WriteLine("                                                                    ..;===+.");
            Console.SetCursorPosition(xpos, ypos+1);
            Console.WriteLine("                                                                .:=iiiiii=+=");
            Console.SetCursorPosition(xpos, ypos+2);
            Console.WriteLine("                                                             .=i))=;::+)i=+,");
            Console.SetCursorPosition(xpos, ypos+3);
            Console.WriteLine("                                                          ,=i);)I)))I):=i=;");
            Console.SetCursorPosition(xpos, ypos+4);
            Console.WriteLine("                                                       .=i==))))ii)))I:i++");
            Console.SetCursorPosition(xpos, ypos+5);
            Console.WriteLine("                                                     +)+))iiiiiiii))I=i+:'");
            Console.SetCursorPosition(xpos, ypos+6);
            Console.WriteLine("                                .,:;;++++++;:,.       )iii+:::;iii))+i='");
            Console.SetCursorPosition(xpos, ypos+7);
            Console.WriteLine("                             .:;++=iiiiiiiiii=++;.    =::,,,:::=i));=+'");
            Console.SetCursorPosition(xpos, ypos+8);
            Console.WriteLine("                           ,;+==ii)))))))))))ii==+;,      ,,,:=i))+=");
            Console.SetCursorPosition(xpos, ypos+9);
            Console.WriteLine("                         ,;+=ii))))))IIIIII))))ii===;.    ,,:=i)=i+");
            Console.SetCursorPosition(xpos, ypos+10);
            Console.WriteLine("                        ;+=ii)))IIIIITIIIIII))))iiii=+,   ,:=));=,");
            Console.SetCursorPosition(xpos, ypos+11);
            Console.WriteLine("                      ,+=i))IIIIIITTTTTITIIIIII)))I)i=+,,:+i)=i+");
            Console.SetCursorPosition(xpos, ypos+12);
            Console.WriteLine("                     ,+i))IIIIIITTTTTTTTTTTTI))IIII))i=::i))i='");
            Console.SetCursorPosition(xpos, ypos+13);
            Console.WriteLine("                    ,=i))IIIIITLLTTTTTTTTTTIITTTTIII)+;+i)+i`");
            Console.SetCursorPosition(xpos, ypos+14);
            Console.WriteLine("                    =i))IIITTLTLTTTTTTTTTIITTLLTTTII+:i)ii:'");
            Console.SetCursorPosition(xpos, ypos+15);
            Console.WriteLine("                   +i))IITTTLLLTTTTTTTTTTTTLLLTTTT+:i)))=,");
            Console.SetCursorPosition(xpos, ypos+16);
            Console.WriteLine("                   =))ITTTTTTTTTTTLTTTTTTLLLLLLTi:=)IIiii;");
            Console.SetCursorPosition(xpos, ypos+17);
            Console.WriteLine("                  .i)IIITTTTTTTTLTTTITLLLLLLLT);=)I)))))i;");
            Console.SetCursorPosition(xpos, ypos+18);
            Console.WriteLine("                  :))IIITTTTTLTTTTTTLLHLLLLL);=)II)IIIIi=:");
            Console.SetCursorPosition(xpos, ypos+19);
            Console.WriteLine("                  :i)IIITTTTTTTTTLLLHLLHLL)+=)II)ITTTI)i=");
            Console.SetCursorPosition(xpos, ypos+20);
            Console.WriteLine("                  .i)IIITTTTITTLLLHHLLLL);=)II)ITTTTII)i+");
            Console.SetCursorPosition(xpos, ypos+21);
            Console.WriteLine("                  =i)IIIIIITTLLLLLLHLL=:i)II)TTTTTTIII)i'");
            Console.SetCursorPosition(xpos, ypos+22);
            Console.WriteLine("                +i)i)))IITTLLLLLLLLT=:i)II)TTTTLTTIII)i;");
            Console.SetCursorPosition(xpos, ypos+23);
            Console.WriteLine("              +ii)i:)IITTLLTLLLLT=;+i)I)ITTTTLTTTII))i;");
            Console.SetCursorPosition(xpos, ypos+24);
            Console.WriteLine("             =;)i=:,=)ITTTTLTTI=:i))I)TTTLLLTTTTTII)i;");
            Console.SetCursorPosition(xpos, ypos+25);
            Console.WriteLine("           +i)ii::,  +)IIITI+:+i)I))TTTTLLTTTTTII))=,");
            Console.SetCursorPosition(xpos, ypos+26);
            Console.WriteLine("        :=;)i=:,,    ,i++::i))I)ITTTTTTTTTTIIII)=+'");
            Console.SetCursorPosition(xpos, ypos+27);
            Console.WriteLine("       .+ii)i=::,,   ,,::=i)))iIITTTTTTTTIIIII)=+");
            Console.SetCursorPosition(xpos, ypos+28);
            Console.WriteLine("      ,==)ii=;:,,,,:::=ii)i)iIIIITIIITIIII))i+:'");
            Console.SetCursorPosition(xpos, ypos+29);
            Console.WriteLine("     +=:))i==;:::;=iii)+)=  `:i)))IIIII)ii+'");
            Console.SetCursorPosition(xpos, ypos+30);
            Console.WriteLine("   .+=:))iiiiiiii)))+ii;");
            Console.SetCursorPosition(xpos, ypos+31);
            Console.WriteLine("  .+=;))iiiiii)));ii+");
            Console.SetCursorPosition(xpos, ypos+32);
            Console.WriteLine(" .+=i:)))))))=+ii+");
            Console.SetCursorPosition(xpos, ypos+33);
            Console.WriteLine(".;==i+::::=)i=;");
            Console.SetCursorPosition(xpos, ypos+34);
            Console.WriteLine(",+==iiiiii+,");
            Console.SetCursorPosition(xpos, ypos+35);
            Console.WriteLine("`+=+++;`");
            Thread.Sleep(500);
            Console.SetCursorPosition(0, starty + 1);
        }
        public static void DrawChess(int xpos, int ypos)
        {
            int starty = Console.CursorTop;
            Console.SetCursorPosition(xpos, ypos);
            Console.WriteLine("      o        +");
            Console.SetCursorPosition(xpos, ypos + 1);
            Console.WriteLine("     ^^^      ^^^");
            Console.SetCursorPosition(xpos, ypos + 2);
            Console.WriteLine("     ( )      ( )");
            Console.SetCursorPosition(xpos, ypos + 3);
            Console.WriteLine("     ) (      ) (      |||       ^       _/)");
            Console.SetCursorPosition(xpos, ypos + 4);
            Console.WriteLine("    (   )    (   )     | |      / \\     /. |=");
            Console.SetCursorPosition(xpos, ypos + 5);
            Console.WriteLine("     ) (      ) (      ) (      ) (    /_) |=     ( )");
            Console.SetCursorPosition(xpos, ypos + 6);
            Console.WriteLine("     ) (      ) (      ) (      ) (   (/ ) (=     ) (");
            Console.SetCursorPosition(xpos, ypos + 7);
            Console.WriteLine("    (   )    (   )    (   )    (   )    (   )    (   )");
            Console.SetCursorPosition(xpos, ypos + 8);
            Console.WriteLine("   [_____]  [_____]  [_____]  [_____]  [_____]  [_____]");
            Thread.Sleep(500);
            Console.SetCursorPosition(0, starty + 1);
        }
        public static void Knock()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Knock Knock!");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Who's there?");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Spell");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Spell who?");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("W  H  O... it's not that hard...");
        }
    }
}
