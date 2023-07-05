namespace phmx.Models;

public record ServerTime(int code, string msg, ServerTimeData data);
public abstract record ServerTimeData(ulong serverTime);