using DotNetStripe.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace DotNetStripe.Client.Pages;

public partial class Home
{
    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    [Inject]
    public IJSRuntime JsRuntime { get; set; } = default!;

    private List<Product>? _products;
    private IEnumerable<Product[]>? _productChunksOf4;

    private const string DevApiBaseAddress = "https://localhost:7046/api";


    protected override async Task OnInitializedAsync()
    {
        _products = await HttpClient.GetFromJsonAsync<List<Product>>($"{DevApiBaseAddress}/Product");

        if (_products is not null)
        {
            _productChunksOf4 = _products.Chunk(4);
        }
    }

    private async Task OnClickBtnBuyNowAsync(Product product)
    {
        var response = await HttpClient.PostAsJsonAsync($"{DevApiBaseAddress}/checkout", product);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var checkoutOrderResponse = JsonConvert.DeserializeObject<CheckOutOrderResponse>(responseBody);

        // Opens up Stripe.
        await JsRuntime.InvokeVoidAsync("checkout", checkoutOrderResponse?.PubKey, checkoutOrderResponse?.SessionId);
    }
}
