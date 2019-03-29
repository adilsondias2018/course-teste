using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Entities
{
    class Postagem
    {
        public DateTime MOment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = new List<Comments>(); // garatindo que a lista será instanciada


        public Postagem()
        {

        }

        public Postagem(DateTime mOment, string title, string content, int likes)
        {
            MOment = mOment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // Quando nos temos uma operação que contem muitos objeto e comum acresentar as operações addicionar e remover

        public void addComment(Comments comment)
        {
            Comments.Add(comment);

        }

        public void removeComment(Comments comment)
        {
            Comments.Remove(comment);

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(MOment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");

            foreach (Comments c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();


        }


    }
}
