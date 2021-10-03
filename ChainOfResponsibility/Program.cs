using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Senaryo:
             * 
             * Dünyanın bütün ülkelerinde faaliyet gösteren bir work station için toplantı odası kiralama sistemi yazıyoruz. Db, ülkelere organize edilmiş. Gelen rezervasyon request'ini doğru yönlendirmelisiniz.
             */
            TurkiyeMeetingRoomHandler turkiyeMeetingRoomHandler = new TurkiyeMeetingRoomHandler();
            ItalyMeetingRoomHandler italyMeetingRoomHandler = new ItalyMeetingRoomHandler();
            GermanyMeetingRoomHandler germanyMeetingRoomHandler = new GermanyMeetingRoomHandler();

            turkiyeMeetingRoomHandler.Next = italyMeetingRoomHandler;
            italyMeetingRoomHandler.Next = germanyMeetingRoomHandler;

            turkiyeMeetingRoomHandler.SearchAvailableLocations(new BookingEventArgs { Country = "Germany", ParticipiantsCount = 100 });

            Console.ReadLine();
        }
    }

    public class BookingEventArgs 
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int ParticipiantsCount { get; set; }
        public DateTime RequestedDate { get; set; }
    }
    public abstract class BookingHandler
    {
        //Zincirin halkaları....

        private EventHandler<BookingEventArgs> BookingEventHandler;
        public BookingHandler Next { get; set; }
        protected abstract void SearchMeetingRoom(object sender, BookingEventArgs e);

        public BookingHandler()
        {
            BookingEventHandler += SearchMeetingRoom;
        }

        public void SearchAvailableLocations(BookingEventArgs args)
        {
            BookingEventHandler(this, args);
        }
    }

    public class TurkiyeMeetingRoomHandler : BookingHandler
    {
        protected override void SearchMeetingRoom(object sender, BookingEventArgs e)
        {
            if (e.Country == "Türkiye")
            {
                Console.WriteLine("Uygun lokasyonlar aranıyor....");
            }
            else
            {
                //eğer uygun değilse, zincirin sonraki halkasına git:
                Next?.SearchAvailableLocations(e);
            }
        }



    }
    public class ItalyMeetingRoomHandler : BookingHandler
    {
        protected override void SearchMeetingRoom(object sender, BookingEventArgs e)
        {
            if (e.Country == "Italy")
            {
                Console.WriteLine("İtalya için arama....");
            }
            else
            {
                Next?.SearchAvailableLocations(e);
            }
        }
    }

    public class GermanyMeetingRoomHandler : BookingHandler
    {
        protected override void SearchMeetingRoom(object sender, BookingEventArgs e)
        {
            if (e.Country == "Germany")
            {
                Console.WriteLine("Almanya için arama....");
            }
            else
            {
                Console.WriteLine("Belirttiğiniz ülkede hizmet veremiyoruz.....");
            }
        }
    }
}
