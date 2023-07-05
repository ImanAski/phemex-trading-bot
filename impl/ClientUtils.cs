

using System.Security.Cryptography;
using System.Text;

namespace phmx.impl;

public class ClientUtils
{


    public static string sign(string path, string queryString, long expiry, string body, byte[] secretKey)
    {
        StringBuilder sb = new StringBuilder(1024);
        sb.Append(path)
            .Append(String.IsNullOrEmpty(queryString) ? "" : queryString)
            .Append(expiry)
            .Append((String.IsNullOrEmpty(body) ? "" : body));
        
        string signedString = sb.ToString();
        Console.WriteLine("path {}, query str {}, expiry {}, body {}, signed str {}", path, queryString, expiry, body, signedString);
        string signature = sign(signedString, secretKey);
        return signature;
    }

    public static string sign(string message, byte[] secretKey)
    {
        try
        {
            using (var hMACSHA256 = new HMACSHA256(secretKey))
            {
                var hash = hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(message));
                System.Console.WriteLine("Signature Generated with no fatal errors.");
                return new String(hash.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("There was Something wrong -> Error is {}", e.Message);
            throw new SystemException($"Unable to sign message -> Error is {e.Message}");
        }
    }
}