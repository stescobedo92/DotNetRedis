using DotNetRedis;
using StackExchange.Redis;

namespace DotNetRedisTest;

public class DotnetRedisUnitTest
{
    [Fact]
    public void Connection_ShouldNotBeNull()
    {
        // Act
        var connection = RedisConnection.Connection;

        // Assert
        Assert.NotNull(connection);
    }

    [Fact]
    public void Connection_ShouldBeInstanceOfConnectionMultiplexer()
    {
        // Act
        var connection = RedisConnection.Connection;

        // Assert
        Assert.IsType<ConnectionMultiplexer>(connection);
    }

    [Fact]
    public void Connection_ShouldConnectSuccessfully()
    {
        // Act
        var connection = RedisConnection.Connection;

        // Assert
        Assert.True(connection.IsConnected);
    }

    [Fact]
    public void Connection_ShouldBeSingleton()
    {
        // Act
        var connection1 = RedisConnection.Connection;
        var connection2 = RedisConnection.Connection;

        // Assert
        Assert.Same(connection1, connection2);
    }
}