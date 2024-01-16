using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertidordivisas.Clases
{
    internal class Conversor
    {        

        static double ConvertirDivisas(string actual, string convertida, double cantidad) 
        { 
            switch (convertida)
            {
                case "CLP":
                    switch (actual)
                    {
                        case "ARS":
                            return cantidad * 0.9;
                        case "USD":
                            return cantidad * 0.0011;
                        case "EUR":
                            return cantidad * 0.0010;
                        case "TRY":
                            return cantidad * 0.033;
                        case "GBP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");
                            
                    }
                case "ARS":
                    switch (actual)
                    {
                        case "CLP":
                            return cantidad * 0.9;
                        case "USD":
                            return cantidad * 0.0011;
                        case "EUR":
                            return cantidad * 0.0010;
                        case "TRY":
                            return cantidad * 0.033;
                        case "GBP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");

                    }
                case "USD":
                    switch (actual)
                    {
                        case "ARS":
                            return cantidad * 0.9;
                        case "CLP":
                            return cantidad * 0.0011;
                        case "EUR":
                            return cantidad * 0.0010;
                        case "TRY":
                            return cantidad * 0.033;
                        case "GBP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");

                    }
                case "EUR":
                    switch (actual)
                    {
                        case "ARS":
                            return cantidad * 0.9;
                        case "USD":
                            return cantidad * 0.0011;
                        case "CLP":
                            return cantidad * 0.0010;
                        case "TRY":
                            return cantidad * 0.033;
                        case "GBP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");

                    }
                case "TRY":
                    switch (actual)
                    {
                        case "ARS":
                            return cantidad * 0.9;
                        case "USD":
                            return cantidad * 0.0011;
                        case "EUR":
                            return cantidad * 0.0010;
                        case "CLP":
                            return cantidad * 0.033;
                        case "GBP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");

                    }
                case "GBP":
                    switch (actual)
                    {
                        case "ARS":
                            return cantidad * 0.9;
                        case "USD":
                            return cantidad * 0.0011;
                        case "EUR":
                            return cantidad * 0.0010;
                        case "TRY":
                            return cantidad * 0.033;
                        case "CLP":
                            return cantidad * 0.00087;
                        default:
                            // Manejar otros casos o lanzar una excepción
                            throw new ArgumentException("Conversión no soportada para la moneda de origen proporcionada.");

                    }
                default:
                    // Manejar otros casos o lanzar una excepción
                    throw new ArgumentException("Conversión no soportada para la moneda de destino proporcionada.");


            }
        }

    }
}
