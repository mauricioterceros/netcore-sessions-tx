namespace CoreLogic;

public class GuitarManager
{
    private List<Guitar> guitars;

    public GuitarManager()
    {
        guitars = new List<Guitar>();
    }
    public List<Guitar> GetAllGuitars()
    {
        return guitars;
    }

    public Guitar AddNewGuitar(string guitarName)
    {
        Guitar createdGuitar = new Guitar() { Name = guitarName, Id = "0"};
        guitars.Add(createdGuitar);

        return createdGuitar;
    }

    public List<string> GetAllBrands()
    {
        List<string> brands = new List<string>();
        brands.Add("Fender");
        brands.Add("Ibanez");
        brands.Add("Gibson");

        return brands;
    }
}
