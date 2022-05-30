using System;

namespace Homework30_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook()
            {
                Name = "Zenbook",
                BrandName = "Asus",
                Price = 4000

            };
            Notebook notebook2 = new Notebook()
            {
                Name = "Macbook",
                BrandName = "Apple",
                Price = 4400
            };
            Notebook notebook3 = new Notebook()
            {
                Name = "Ideapad",
                BrandName = "Lenovo",
                Price = 2200
            };
            Notebook notebook4 = new Notebook()
            {
                Name = "Yoga",
                BrandName = "Lenovo",
                Price = 1900
            };
            Notebook notebook5 = new Notebook()
            {
                Name = "Vivobook",
                BrandName = "Asus",
                Price = 1500
            };
            Notebook[] notebooks = new Notebook[5];
            notebooks[0] = notebook1;
            notebooks[1] = notebook2;
            notebooks[2] = notebook3;
            notebooks[3] = notebook4;
            notebooks[4] = notebook5;



            Console.WriteLine("Minimum qiymeti daxil edin:");
            
            int MinPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maksimum qiymeti daxil edin:");
            
            int MaxPrice = Convert.ToInt32(Console.ReadLine());
            
            
                
            
            
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price >= MinPrice)  
                {
                    if (notebooks[i].Price <= MaxPrice)
                    {
                        Console.WriteLine(notebooks[i].Name);
                        
                    }
                    
                    
                    
                    
                      
                    
                }


            }
            
            
                

                
            

                
                
                
            

            
                
        }
        






    }
}
