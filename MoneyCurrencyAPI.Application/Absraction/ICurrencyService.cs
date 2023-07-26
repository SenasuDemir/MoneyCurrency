using MoneyCurrencyAPI.Domain.Entities;

namespace MoneyCurrencyAPI.Application.Absraction
{
    public interface ICurrencyService
    {
        List<Currency> GetCurrencies();

    }
}
