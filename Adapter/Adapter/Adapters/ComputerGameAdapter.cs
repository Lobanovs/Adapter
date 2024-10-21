using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapter.Models;
using Adapter.Adapter.Interfaces;
using Adapter.Models;



namespace Adapter.Adapter.Adapters
{
    public class ComputerGameAdapter : PCGame
    {
        private ComputerGame computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        public string getTitle()
        {
            return computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            return int.Parse(computerGame.getPegiAgeRating().ToString().Substring(1));
        }

        public bool isTripleAGame()
        {
            return computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            return new Requirements(
                computerGame.getMinimumGpuMemoryInMegabytes() / 1024, 
                computerGame.getDiskSpaceNeededInGB(),
                computerGame.getRamNeededInGb(),
                computerGame.getCoreSpeedInGhz(),
                computerGame.getCoresNeeded()
            );
        }
    }

}
