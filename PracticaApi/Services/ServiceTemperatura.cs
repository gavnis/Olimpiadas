using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaApi
{
    public class ServiceTemperatura : IServiceTemperatura
    {

        private List<Temperatura> list;
        public ServiceTemperatura()
        {
            list = new List<Temperatura>();
            var Bariloche = new Lugar() {ID = 1, Nombre = "Bariloche"};
            list.Add(new Temperatura()
            {
                ID = 1,
                ValorTemperatura = 23.0,
                EscalaTermometrica = "C",
                lugar = Bariloche,
                Hora = this.CurrentlyHour()
            }
            );
            list.Add(new Temperatura()
            {
                ID = 2,
                ValorTemperatura = 15.5,
                EscalaTermometrica = "C",
                lugar = Bariloche,
                Hora = this.CurrentlyHour()
            }
            );
        
        }
        public List<Temperatura> GetAll()
        {
            return list;
        }    
        public Temperatura Get(int id)
        {
            return list.FirstOrDefault(b => b.ID == id);
        }
        public void Save(Temperatura temperatura)
        {
            this.Delete(temperatura.ID);
            list.Add(temperatura);
        }
        public void Delete(int id)
        {
            var temperatura = this.Get(id);
            if (temperatura != null)
            {
                list.Remove(temperatura);
            }
        }

        private DateTime CurrentlyHour() 
        {
            return DateTime.Now;
        }

    }
}