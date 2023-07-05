
namespace phmx.rest;

public interface Order
{
    Task<PhemexResponse<PagedResult<TradeModelVo>>> listTrades(String symbol, long start, long end, long offset, int limit, List<String> tradeType);
}