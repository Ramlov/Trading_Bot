using System;
using System.Net;
using CoinbasePro.Network.Authentication;
using CoinbasePro.Network.HttpClient;
using CoinbasePro.Services.Orders;
using CoinbasePro.Services.Orders.Models.Responses;

namespace CryptoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with your API key and secret
            var apiKey = "";
            var apiSecret = "";

            // Authenticate with Coinbase Pro
            var credentials = new ApiCredentials(apiKey, apiSecret);
            var client = new CoinbaseProHttpClient(credentials);
            var ordersService = new OrdersService(client);

            // Set up the parameters for the trade
            var productId = "BTC-USD";
            var side = "buy";
            var orderType = "market";
            var funds = 0.1m;

            // Execute the trade
            var response = ordersService.PlaceOrder(productId, side, orderType, funds);

            // Print the response
            Console.WriteLine("Trade complete: " + response.Id);
        }
    }
}