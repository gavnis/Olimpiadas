using System;
namespace PracticaApi
{


    public class Temperatura
    {
        public int ID { get; set; }
        public double ValorTemperatura { get; set; }
        public string EscalaTermometrica { get; set; }
        public Lugar lugar { get; set; }
        public DateTime Hora { get; set; }
    }
}