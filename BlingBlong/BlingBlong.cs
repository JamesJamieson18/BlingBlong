using System;

namespace GameSpace
{
    class BlingBlong
    {
        public static void Game(){
            for(int i = 0; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("BlingBlong");
                } else if(i % 3 == 0) {
                    Console.WriteLine("Bling");
                } else if(i % 5 == 0){
                    Console.WriteLine("Blong");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}