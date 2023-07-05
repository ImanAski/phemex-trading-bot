namespace phmx.Models;


public class Products
{
    public int code { get; set; }
    public string msf { get; set; }
    public ProductsData data { get; set; }
}

public class ProductsData
{
    public List<Currency> currencies { get; set; }
}

public class Currency
{
    public string currency{ get; set; }
    public string name{ get; set; }
    public ulong code{ get; set; }
    public int valueScale{ get; set; }
    public ulong maxValueEv{ get; set; }
    public int needAddrtag{ get; set; }
    public string status{ get; set; }
    public string displayCurrency{ get; set; }
    public int inAssetDisplay{ get; set; }
    public int prepetual{ get; set; }
    public int stableCoin{ get; set; }
    public int assetPrecision{ get; set; }
};