using System;

namespace Temperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitPraCelsius(double tempratura) {
            //return (tempratura-32.0)/18.8;//Simulacao de falha
            return Math.Round((tempratura-32.0)/1.8,2);
        }
        public static double FahrenheitPraKelvin(double tempratura) {
            //return FahrenheitPraCelsius(tempratura) + 273.15;//Simulacao de falha
            return Math.Round(FahrenheitPraCelsius(tempratura)+ 273.15,2);
        }
    }
}
