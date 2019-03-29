using System;
using Post.Entities;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {

            Comments c1 = new Comments("Have a nice trip");
            Comments c2 = new Comments("Wow that'x awsome!");


            Postagem p1 = new Postagem(DateTime.Parse("21/06/2018 13:05:33"), "Traveling to New Zealand", "I'm going to visiit this wonderful country", 12);


            p1.addComment(c1);
            p1.addComment(c2);



            Comments c3 = new Comments("I loved Australia");
            Comments c4 = new Comments("I want go back every year!!");


            Postagem p2 = new Postagem(DateTime.Parse("22/06/2018 13:05:33"), "Traveling to New Australia", "I'm going to visiit this wonderful country", 100);


            p2.addComment(c3);
            p1.addComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


           


        }
    }
}
