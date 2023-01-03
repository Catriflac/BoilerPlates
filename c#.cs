using Internal;
using System; 

namespace FFXP8S
{
    class Program
    {     
        public static void Main()
        {

            int myInteger = 0;
            string myString = "";

            // BEOLVASÁSOK --------------------------------------------------------------------------------

            // Egysoros
            string inputstring = Console.ReadLine()+"a";

            // 1 Dimenziós
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<N; i++)
            {
            meresek[i] = Convert.ToInt32(Console.ReadLine());
            }

            // 2 Dimenziós
            int[] nOfItems;
            nOfItems = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32); // beolvasás tömbbe

            int szamlalo;
            int holtverseny;

            int[] scores = new int[nOfItems[0]];
            scores = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);

                // Mintakeresés
                for(int i=0; i<nOfItems[0]; i++)  //minden versenyző pontszámára
                {
                    szamlalo = 1;
                    holtverseny = 1;
                        
                    for(int j= 0; j<i; j++) //minden eddig rögzített értékre és magára
                    {
                        if(scores[j]>scores[i]) //helyezés
                        {
                            szamlalo++;
                        }
                        else if(scores[j]==scores[i])   //holtverseny
                        {
                            holtverseny++;
                        }
                    }
                    Console.WriteLine(szamlalo+" "+holtverseny);
                }




            // CIKLUSOK --------------------------------------------------------------------------------

            // Balról jobbra iterálás
            for(int i = 0; i < inputstring.Length; i++)
            {
                if (inputstring[i] != 'a' && inputstring[i] != 'e')
                {   
                    massalh++;
                }

                else if (massalh>0){
                    Console.Write(massalh+" ");
                    massalh = 0;
                }
            }     
            
            // Beágyazott While ciklus
            for (int i=0; i<N-1; i++)
            {
                if (meresek[i+1] > meresek[i])
                {
                    emelkedoStart = i;
                    emelkedo = 0;
                    while ( i < N-1 && meresek[i+1] > meresek[i])
                    {
                        emelkedo++;
                        i++;
                    }
                    emelkedoStop = i;
                }
                if (emelkedo > emelkedo_Temp)
                {
                    emelkedo_Temp = emelkedo;
                    emelkedoStart_Temp = emelkedoStart;
                    emelkedoStop_Temp = emelkedoStop;
                }

            }



        } // Main vége
    }
}
