using StackExchange.Redis;

namespace DotNetRedis;

public class RedisConnection
{
    private static readonly Lazy<ConnectionMultiplexer> _lazyConnection;
    public static ConnectionMultiplexer Connection => _lazyConnection.Value;
    
    static RedisConnection()
    {
        _lazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect("localhost"));
    }
}