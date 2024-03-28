internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Shua");
        SayaTubeVideo vid1 = new SayaTubeVideo("review film Dilan 1999");
        SayaTubeVideo vid2 = new SayaTubeVideo("review film Jurassic Park");
        SayaTubeVideo vid3 = new SayaTubeVideo("review film Dilan 1999");
        SayaTubeVideo vid4 = new SayaTubeVideo("review film Habibie Ainun 3");
        SayaTubeVideo vid5 = new SayaTubeVideo("review film Soekarno");
        SayaTubeVideo vid6 = new SayaTubeVideo("review film 1917");
        SayaTubeVideo vid7 = new SayaTubeVideo("review film Dilan Alexander");
        SayaTubeVideo vid8 = new SayaTubeVideo("review film Cleopatra");
        SayaTubeVideo vid9 = new SayaTubeVideo("review film Sejarah");
        SayaTubeVideo vid10 = new SayaTubeVideo("review film Horror");
        user.AddVideo(vid1); user.AddVideo (vid2); user.AddVideo (vid3);
        user.AddVideo(vid4); user.AddVideo(vid5);user.AddVideo (vid6);
        user.AddVideo(vid7); user.AddVideo(vid8); user.AddVideo(vid9);
        user.AddVideo(vid10);

        user.PrintAllVideoPlaycount();
    }
}

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.username = username;

        Random userId = new Random();
        id = userId.Next(10000, 100000);

        uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;

        for(int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].getPlayCount();
        }

        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);

        for (int i = 0;i < uploadedVideos.Count;i++)
        {
            Console.WriteLine("Video " + (i+1) + ": " + uploadedVideos[i].getTitle());
        }
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        playCount = 0;
        Random id_rand = new Random();
        id = id_rand.Next(10000, 100000);
    }

    public void IncreasePlayCount(int increment)
    {
        playCount += increment;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play count: " + playCount);
    }

    public int getPlayCount() { return playCount; }
    public string getTitle() { return title; }
    public int getId() { return id; }
}