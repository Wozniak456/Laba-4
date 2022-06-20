using ConsoleApp7.Bouguet;
using ConsoleApp7.Decorators;

BouquetBase pinkBouquet = new PinkBouquet();
BouquetBase whiteBouquet = new WhiteBouquet();

PrintBouquet(whiteBouquet);
Console.WriteLine();

PrintBouquet(pinkBouquet);
Console.WriteLine();

BouquetBase PinkBouquetWithWrappingPaper = new WrappingPaper(new PinkBouquet());
BouquetBase WhiteBouquetWithFloralMeshAndRibbon = new RibbonComponent(new FloralMesh(new WhiteBouquet()));

PrintBouquet(PinkBouquetWithWrappingPaper);
Console.WriteLine();
PrintBouquet(WhiteBouquetWithFloralMeshAndRibbon);

static void PrintBouquet(BouquetBase bouquet)
{
    Console.WriteLine($"{bouquet.GetDescription()} \n~for {bouquet.GetCost()} grn");
}