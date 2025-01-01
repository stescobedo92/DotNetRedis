
using DotNetRedis;

var redisDb = RedisConnection.Connection.GetDatabase();
redisDb.StringSet("names", "Alice, Bob, Charlie");
redisDb.StringSet("more_names", "Jhon, Doe, Lorem");

var namesFromRedis = redisDb.StringGet("names");
var moreNamesFromRedis = redisDb.StringGet("more_names");
Console.WriteLine(namesFromRedis);
Console.WriteLine(moreNamesFromRedis);
