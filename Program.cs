using System;

namespace sess5local
{
    class Program
    {
        //Space traveller age in seconds
           static int spacetravelorAGE = 631154000;
           static int earthseconds = 31557600;

           static float earthaage;
           static float Venusaage;
           static float marsaage;
           static float jupiteraage;
           static float neptuneaage;
        //    static float amount3;
          
            //Planet names and their orbital periods
           static string[] planetnames = new string[4];
           static float[] orbitalyears = new float[4];
           

        static void Main(string[] args)
        {
            planetnames[0] = "Venus age :";
            orbitalyears[0] = 0.61519726f;
           
            planetnames[1] = "Mars age :";
            orbitalyears[1] = 1.8808158f;

            planetnames[2] = "Jupiter age :";
            orbitalyears[2] = 11.862615f;
            
            planetnames[3] = "Neptune age :";
            orbitalyears[3] = 164.79132f;

            Console.WriteLine("Space traveller is " + Program.earthage(spacetravelorAGE, earthseconds) + " years old");

             Console.WriteLine(planetnames[0] + Program.venusage(earthaage) + " Earth-years old");
             Console.WriteLine(planetnames[1] + Program.marsage(earthaage) + " Earth-years old");
             Console.WriteLine(planetnames[2] + Program.jupiterage(earthaage) + " Earth-years old");
             Console.WriteLine(planetnames[3] + Program.neptuneage(earthaage) + " Earth-years old");
            // Console.WriteLine( Program.otherplanetsage(amount1));
        }

        public static float earthage (int spacetravelorAGE, int earthseconds){

            float ageinyears = spacetravelorAGE/earthseconds;

            // round to two decimal places.
            earthaage = (float)Math.Round(ageinyears, 2);
            //display the results.
            return earthaage;

        } 
        // public static  string otherplanetsage(float amount1){

        //      for(int i = 0;  i < planetnames.Length; i++ ){  
               
        //                 float Amount2 = ( Program.earthage(spacetravelorAGE, earthseconds) / orbitalyears[i]);
        //                 // round to two decimal places.
        //                 amount3 = MathF.Round(Amount2, 2);
        //                 // display the results.
        //                 Console.WriteLine(planetnames[i] + " " + amount3 + " Earth-years old");                        
                       
        //     } 

        //    return "";

        // }

        public static float venusage(float earthaage){
            float venusage = Program.earthage(spacetravelorAGE, earthseconds) /  orbitalyears[0];
            Venusaage = MathF.Round(venusage, 2);
            return Venusaage;
        }
        public static float marsage(float earthaage){
            float marsage = Program.earthage(spacetravelorAGE, earthseconds) /  orbitalyears[1];
            marsaage = MathF.Round(marsage, 2);
            return marsaage;
        }
        public static float jupiterage(float earthaage){
            float jupiterage = Program.earthage(spacetravelorAGE, earthseconds) /  orbitalyears[2];
            jupiteraage = MathF.Round(jupiterage, 2);
            return jupiteraage;
        }
        public static float neptuneage(float earthaage){
            float neptuneage = Program.earthage(spacetravelorAGE, earthseconds) /  orbitalyears[3];
            neptuneaage = MathF.Round(neptuneage, 2);
            return neptuneaage;
        }


        
    }
}
