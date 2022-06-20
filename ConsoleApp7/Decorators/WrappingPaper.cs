using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp7.Bouguet;

namespace ConsoleApp7.Decorators;
//обгортаючий папір
class WrappingPaper : DecoratorBase
{
    private BouquetBase _bouquet;
    public WrappingPaper(BouquetBase bouquet)
    {
        _bouquet = bouquet;
        Description = _bouquet.GetDescription() + "\n  +Wrapping Paper";
    }
    public override double GetCost()
    {
        return _bouquet.GetCost() + 15;
    }
}
