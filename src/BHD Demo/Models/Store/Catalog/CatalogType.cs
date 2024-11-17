namespace BHD_Demo.Models.Store.Catalog;

public class CatalogType
{
    public int Id { get; set; }
    public string Type { get; set; }

    public override string ToString()
    {
        return Type;
    }
}