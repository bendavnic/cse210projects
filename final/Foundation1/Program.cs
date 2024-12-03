using System;

class Program
{
    static void Main(string[] args)
    {
        Video catVideo= new Video("World's Strongest Kitten", "kittymang17", 344);
        Comment cute = new Comment("bman12989", "so cute!", catVideo);
        Comment swole = new Comment("lunkalarm", "tryna get swole like this kitty", catVideo);
        Comment lol = new Comment("MemeQueen44", "I had soda come out of my nose at 2:40", catVideo);
        Comment hater = new Comment("MephistoMan", "weights are fake!! ", catVideo);

        Video outdoors = new Video("Hiking Mount Denali in 24 Hours", "BushcraftKing", 2113);
        Comment cool = new Comment("newaroundhere", "This is awesome, man. I get to travel the world through your videos.", outdoors);
        Comment crush = new Comment("MemeQueen44", "Did you get a new haircut? It looks good!!! <3", outdoors);
        Comment boast = new Comment("SonicFan09", "Big deal. I climbed mount delani when I was 12.", outdoors);
        Comment bot = new Comment("Allen42", "looking for high mountains in your area? find them at singlepeaks (d0t) com", outdoors);

        Video gamer = new Video("Minecraft Modded Let's Play- Part 1712", "UberBLOX", 945);
        Comment backseat = new Comment("MinePro", "Bro how are we on part 1712 and you still haven't fixed that piston @ 4:15", gamer);
        Comment blood = new Comment("samallama6", "Man gets 14 views on his vids and still won't give up.", gamer);
        Comment dad = new Comment("BostonDad31", "My daughter loves to watch your videos, thanks for keeping it family friendly.", gamer);

        catVideo.Display();
        outdoors.Display();
        gamer.Display();
    }
}