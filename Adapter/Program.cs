using Adapter.Adapter.Adapters;
using Adapter.Adapter.Interfaces;
using Adapter.Adapter.Models;
using Adapter.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
       
        ComputerGame game = new ComputerGame(
            "Cyber Adventure",        
            PegiAgeRating.P16,         
            60.5,                     
            8192,                      
            50,                         
            16,                        
            8,                          
            3.5                         
        );

        
        PCGame adaptedGame = new ComputerGameAdapter(game);

        Console.WriteLine("Название игры: " + adaptedGame.getTitle());
        Console.WriteLine("Минимальный возраст: " + adaptedGame.getPegiAllowedAge() + "+");
        Console.WriteLine("TripleA игра: " + (adaptedGame.isTripleAGame() ? "Да" : "Нет"));

        Requirements requirements = adaptedGame.getRequirements();
        Console.WriteLine("Системные требования:");
        Console.WriteLine("  Видеопамять (GB): " + requirements.getGpuGb());
        Console.WriteLine("  Дисковое пространство (GB): " + requirements.getHDDGb());
        Console.WriteLine("  Оперативная память (GB): " + requirements.getRAMGb());
        Console.WriteLine("  Частота процессора (GHz): " + requirements.getCpuGhz());
        Console.WriteLine("  Количество ядер: " + requirements.getCoresNum());
    }
}
