using System;
using Microsoft.Extensions.Configuration;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;
namespace University_Management
{
    internal class Programe
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        }
    }
}


