using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class ImagePost:Post
    {
        protected string ImageURL { get; set; }

        public ImagePost()
        {
            
        }

        public ImagePost(string title,string sendByUsername,string imageURL,bool isPublic)
        {
            //the following properties and the GetNextID method are inherited from Post.
            this.ID=GetNextID();
            this.Title=title;
            this.SendByUsername=sendByUsername;
            this.IsPublic=isPublic;
            //Property ImageUrl is a member of ImagePost,but not of Post
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL}- {this.SendByUsername}");
        }
    }
}
