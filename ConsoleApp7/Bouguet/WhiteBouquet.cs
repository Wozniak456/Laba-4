using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Bouguet;

class WhiteBouquet : BouquetBase
{
    public WhiteBouquet()
    {
        Description = $"\tWhite buequet: \nChrysantheme\nGladiole\nWhite Rose";
    }
    public override double GetCost()
    {
        return 330;
    }
}
