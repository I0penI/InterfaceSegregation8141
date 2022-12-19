namespace InterfaceSegregation8141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    interface ICalisan
    {
        void Calis();
        void MaasAl();
        void YemekYer();
    }

    interface ICalis
    {
        void Calis();
    }
    interface IInsanCalisan
    {
        void MaasAl();
        void YemekYer();
    }
    class Yonetici : ICalis, IInsanCalisan
    {
        public void Calis()
        {
            Console.WriteLine("Yönetici çalışır.");
        }

        public void MaasAl()
        {
            Console.WriteLine("Yönetici maaş alır.");
        }

        public void YemekYer()
        {
            Console.WriteLine("Yönetici yemek yer.");
        }
    }
    class BeyazYakaCalisan : ICalis, IInsanCalisan
    {
        public void Calis()
        {
            Console.WriteLine("Beyaz Yaka çalışır.");
        }

        public void MaasAl()
        {
            Console.WriteLine("Beyaz Yaka maaş alır.");
        }

        public void YemekYer()
        {
            Console.WriteLine("Beyaz Yaka yemek yer.");
        }
    }
    class Robot : ICalis
    {
        public void Calis()
        {
            Console.WriteLine("Robot çalışır.");
        }
                
    }
}