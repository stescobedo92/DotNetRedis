using Xunit;
using StackExchange.Redis;

public class DotNetRedisInteractionUnitTest
{
    private readonly IDatabase _redisDb;

    public DotNetRedisInteractionUnitTest()
    {
        var connection = ConnectionMultiplexer.Connect("localhost"); // Replace with your Redis connection string
        _redisDb = connection.GetDatabase();
    }

    [Fact]
    public void StringSet_ShouldStoreValue()
    {
        // Arrange
        var key = "test_key_1";
        var value = "test_value";

        // Act
        var result = _redisDb.StringSet(key, value);

        // Assert
        Assert.True(result);
        Assert.Equal(value, _redisDb.StringGet(key));
    }

    [Fact]
    public void StringSet_ShouldOverwriteExistingValue()
    {
        // Arrange
        var key = "test_key_2";
        var initialValue = "initial_value";
        var newValue = "new_value";
        _redisDb.StringSet(key, initialValue);

        // Act
        var result = _redisDb.StringSet(key, newValue);

        // Assert
        Assert.True(result);
        Assert.Equal(newValue, _redisDb.StringGet(key));
    }
}