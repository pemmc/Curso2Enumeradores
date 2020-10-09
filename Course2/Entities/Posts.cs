using System;
using System.Collections.Generic;
using System.Text;

namespace Course2.Entities
{
    public class Posts
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        //1 para muitos
        public List<Comments> comments { get; set; } = new List<Comments>();

        public Posts()
        {

            //Construtor padrão

        }

        public Posts(DateTime moment, string title, string content, int likes)
        {

            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }

        public void AddComments(Comments comment)
        {

            comments.Add(comment);

           

        }

        public void RemoveComments(Comments comment)
        {

            comments.Remove(comment);

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);

            sb.Append(Likes);
            sb.Append(" Likes - ");

            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.AppendLine(Content);

            sb.AppendLine("Comments: ");

            foreach (Comments comment in comments)
            {

                sb.AppendLine(comment.Text);

            }

            return sb.ToString();

        }
    }
}
