using TechTalk.SpecFlow;
using FluentAssertions;

namespace Temperatura.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;

        [Given("que o valor da temperatura e de (.*) graus Fahrenheit")]
        public void PreencherTemperaturaFahrenheit(double valorFahrenheit)
        {
            _temperaturaFahrenheit = valorFahrenheit;
        }

        [When("eu solicitar a conversao desta teperatura")]
        public void ProcessarConversao()
        {
            _temperaturaCelsius =
                ConversorTemperatura.FahrenheitPraCelsius(
                    _temperaturaFahrenheit);
            _temperaturaKelvin =
                ConversorTemperatura.FahrenheitPraKelvin(
                    _temperaturaFahrenheit);
        }

        [Then("o resultado da conversao para Celsius sera de (.*) graus")]
        public void ValidarResultadoCelsius(double valorCelsius)
        {
            _temperaturaCelsius.Should().Be(valorCelsius);
        }

        [Then("o resultado da conversao para Kelvin sera de (.*) graus")]
        public void ValidarResultadoKelvin(double valorKelvin)
        {
            _temperaturaKelvin.Should().Be(valorKelvin);
        }
    }
}
