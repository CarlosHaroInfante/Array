namespace Arrays
{

    class Program
    {

        public static void Main(string[] args)
        {

            /*CubiertoDto[] cubiertos = new CubiertoDto[5];
            //declara e inicializa

            cubiertos[0] = new CubiertoDto(1, "Hola");

            for (int i = 0; i <= cubiertos.Length; i++)
            {
                Console.WriteLine(cubiertos[i].ToString);
            }

            Console.WriteLine("Dame los datos para un cubierto");

        }

        
            public static void Main(CubiertoDto[] lista)
        {
            CubiertoDto cub = new CubiertoDto(1, "Hola");

        }



         Console.WriteLine("ID: ");
         long id = Convert.ToInt64(Console.ReadLine());
         Console.WriteLine("Nombre: ");
         string nom = Console.ReadLine();
         Console.WriteLine("Descripcion: ");
         string desc = Console.ReadLine();
         Console.WriteLine("Cantidad: ");
         int cant = Convert.ToInt32(Console.ReadLine());*/


            //Ejemplo de Inicialización

            //Implícita

            

            //Explicita

            /** char[] vles = new char[5];
             vles[0] = 'a';
             vles[1] = 'e';
             vles[2] = 'i';
             vles[3] = 'o';
             vles[4] = 'u';*/
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            char[] voc = { 'a', 'e', 'c', 'o', 'u' };

            for(int i = 0; i < vocales.Length; i++)
            { 

                for (int j = 0; j < voc.Length; j++)
                {

                   //Console.WriteLine(voc[j] == vocales[j]);


                    bool cosas = voc[j] == vocales[j];

                    if (cosas  == false)
                    {
                        // Console.WriteLine("c");
                        Console.WriteLine(voc[j]);
                        
                        //Console.WriteLine(voc.LongLength);
                    }
                    

                    
                    
                    
                }

               

            }






        }
        
            
            


            

            
            
        }

     


    }

    


