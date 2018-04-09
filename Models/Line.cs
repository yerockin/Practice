using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Line
    {
        public class Station
        {
            public Station(int id,string name, DateTime time)
            {
                Id = id;
                Name = name;
                Time = time;
            }
            public int Id;
            public string Name;
            public DateTime Time;

        }
        public List<Station> Stations;
        public Line()
        {
            Stations = new List<Station>();
            Station temp = new Station(0, "Фабрика-кухня", DateTime.Today.AddMinutes(360));
            Stations.Add(temp);
            Stations.Add(new Station(1, "Металлургов", DateTime.Today.AddMinutes(480)));
            Stations.Add(new Station(2, "Трампарк", DateTime.Today.AddMinutes(600)));
            Stations.Add(new Station(3, "Молодежная", DateTime.Today.AddMinutes(720)));
            Stations.Add(new Station(4, "Ленкомсомола", DateTime.Today.AddMinutes(840)));
            Stations.Add(new Station(5, "Россия", DateTime.Today.AddMinutes(960)));
            Stations.Add(new Station(0, "Рынок", DateTime.Today.AddMinutes(1080)));
            Stations.Add(new Station(7, "ул. Гоголя", DateTime.Today.AddMinutes(1200)));
        }
    }
}