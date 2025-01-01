
using DotNetRedis;

var redisDb = RedisConnection.Connection.GetDatabase();
redisDb.StringSet("names", "Alice, Bob, Charlie");

var namesFromRedis = redisDb.StringGet("names");
Console.WriteLine(namesFromRedis);
