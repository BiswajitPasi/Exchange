using Exchange;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


// <summary>
// Represents an application for retrieving and rendering exchange rates.
// </summary>
    // <summary>
    // Represents the entry point of the program.
    // </summary>
    public class Program
    {
    private static readonly ILogger _logger = new Logger();
    // <summary>
    // The main method that is called when the program starts.
    // </summary>
    public static async Task Main()
        {
            try
            {
                // Create a new instance of the ExchangeApp class.
                var app = new ExchangeCurrency();

                // Get the exchange rates asynchronously.
                var currencies = await app.GetExchangeRates().ConfigureAwait(false);

                // Render the currencies.
                app.RenderCurrencies(currencies);
            }
            catch (HttpRequestException e)
            {
            // Print the error message if an HttpRequestException occurs.
            _logger.LogError($"Error: {e.Message}");
            }
        }
    }
