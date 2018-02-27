using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Titeln", "Vad har jag att säga");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.VoteValue());
            post.UpVote();
            post.DownVote();
            Console.WriteLine(post.VoteValue());
            post.DownVote();
            Console.WriteLine(post.VoteValue());
            post.DownVote();
            Console.WriteLine(post.Created);
            Console.WriteLine(post.Title + "  " + post.Description);
            Console.WriteLine(post.VoteValue());
            Console.ReadLine();

        }
    }
}
