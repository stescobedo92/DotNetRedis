# DotNetRedis

This project demonstrates a simple connection between a .NET application and a Redis server.

## Project Structure

* **Program.cs:** Contains the main application logic, where data is stored and retrieved from Redis.
* **RedisConnection.cs:** Provides a class for establishing and managing the connection to the Redis server.

## Prerequisites

* **.NET SDK:** Ensure you have the .NET SDK installed on your machine.
* **StackExchange.Redis:** Install the NuGet package `StackExchange.Redis` in your project.

## Running the Example

1. **pull and run docker image for redis server:**
   ```bash
   docker run -p 6379:6379 -d --name <your_name_for_container> redis:latest
   ```

2. **Clone the repository:**
   ```bash
   git clone [<repository_url>](https://github.com/stescobedo92/DotNetRedis) && cd <DotNetRedis>
   ```

3. **Restore, build and run:**
   ```bash
   dotnet restore && dotnet build && dotnet run
   ```
