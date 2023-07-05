
namespace phmx.Models;

public class Signature 
{
    public string? RequestPath { get; set; }
    public string? RequestQuery { get; set; }
    public string? RequestBody { get; set; }
    public string? RequestExpiry { get; set; }

    private string? signatureComputed;

    public string? GetSignatureComputed()
    {
        return signatureComputed;
    }

    public Signature(string? requestPath = null, string? requestQuery = null, string? requestBody = null, string? requestExpiry = null)
    {
        RequestPath = requestPath;
        RequestQuery = requestQuery;
        RequestBody = requestBody;
        RequestExpiry = requestExpiry;
    }


    public string ComputeSignuture()
    {
        
        return String.Empty;
    }
}