using System.Text;

namespace ConsoleApp7.Bouguet;

public abstract class BouquetBase
{
    protected string Description = "";
    public string GetDescription()
    {
        return Description;
    }
    public abstract double GetCost(); 
}

