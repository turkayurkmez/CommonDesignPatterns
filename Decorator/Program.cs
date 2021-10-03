using System;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NetworkStream networkStream = null;
            FileStream fileStream = null;
            MemoryStream memoryStream = null;

           // GZipStream gZipStream = new GZipStream(fileStream, CompressionLevel.Optimal);

            DefaultMap map = new DefaultMap();

            BusStopOnMap busStopOnMap = new BusStopOnMap(map);
            GeographicDetailsMap geographicDetailsMap = new GeographicDetailsMap(busStopOnMap);

            geographicDetailsMap.ShowDetailsOnMap();
            Console.ReadLine();
        }
    }

    public interface IMap
    {
        void Show();
    }

    public class DefaultMap : IMap
    {
        public void Show()
        {
            Console.WriteLine("varsayılan harita....");
        }
    }

    public abstract class MapDecorator : IMap
    {
        protected IMap map;

        public MapDecorator(IMap map)
        {
            this.map = map;
        }
        public void Show()
        {
            this.map.Show();
        }
    }

    public class BusStopOnMap : MapDecorator
    {


        public BusStopOnMap(IMap map) : base(map)
        {
        }

        public void ShowBusStops()
        {
            Console.WriteLine("Otobüs durakları gösteriliyor....");
            map.Show();
        }
    }

    public class GeographicDetailsMap : MapDecorator
    {
        public GeographicDetailsMap(IMap map) : base(map)
        {
        }
        public void ShowDetailsOnMap()
        {

            Console.WriteLine("haritaya yükseklik ve derinlik katmanı eklendi");
            map.Show();
        }

    }

}
