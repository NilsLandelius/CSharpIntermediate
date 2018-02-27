using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }
        private int _Votes { get; set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Created = DateTime.Now;
            this._Votes = 0;
        }

        public void UpVote()
        {
            this._Votes += 1;
        }
        public void DownVote()
        {
            this._Votes -= 1;
        }
        public int VoteValue()
        {
            return this._Votes;
        }
    }
}
