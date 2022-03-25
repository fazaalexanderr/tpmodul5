using System;

namespace tpmodul5_1302204062
{
   public class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Faza Alexander Riawan");
            video1.IncreasePlayCount(1);
            video1.PrintVideoDetails();
        }
    }

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = this.playCount + playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Title: " + this.title);
            Console.WriteLine("Video Id: " + this.id);
            Console.WriteLine("PlayCount: " +  this.playCount);
        }
    }
}
