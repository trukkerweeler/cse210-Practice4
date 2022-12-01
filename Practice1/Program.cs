using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videoList = new List<Video>();
            
            //Kwai
            Video kwai = new Video();
            videoList.Add(kwai);
            kwai.SetAuthor("Alec Guiness");
            kwai.SetTitle("The Bridge on the River Kwai");
            kwai.SetLength(1957);
            List<Comments> kwaiComments = new List<Comments>();
            Comments cmtKwai = new Comments();
            cmtKwai._userName = "Saito";
            cmtKwai._comments = "Be happy in your work.";
            kwaiComments.Add(cmtKwai);
            
            kwai._comment = kwaiComments;

            //Lawrence of Arabia
            Video loa = new Video();
            videoList.Add(loa);
            loa.SetAuthor("Peter O'Toole");
            loa.SetTitle("Lawrence of Arabia");
            loa.SetLength(1962);
            List<Comments> loaComments = new List<Comments>();            
            Comments cmtLoa = new Comments();
            cmtLoa._userName = "Lawrence";
            cmtLoa._comments = "My fears are my concern.";
            loaComments.Add(cmtLoa);
            
            Comments cmtLoa1 = new();
            cmtLoa1._userName = "Ali";
            cmtLoa1._comments = "Truly for some men, nothing is written, unless they write it.";
            loaComments.Add(cmtLoa1);

            Comments cmtLoa2 = new();
            cmtLoa2._userName = "Lawrence";
            cmtLoa2._comments = "The trick, William Potter, is not minding that it hurts.";
            loaComments.Add(cmtLoa2);

            loa._comment = loaComments;

            Video chl = new();
            videoList.Add(chl);
            chl.SetAuthor("Paul Newman");
            chl.SetTitle("Cool Hand Luke");
            chl.SetLength(1967);
            List<Comments> chlComments = new List<Comments>();
            Comments cmtChl = new();
            cmtChl._userName = "Martin";
            cmtChl._comments = "What we've got here is failure to commune-cate.";
            chlComments.Add(cmtChl);

            chl._comment = chlComments;

            //For whom the bells toll
            Video fwbt = new();
            videoList.Add(fwbt);
            fwbt.SetAuthor("John Donne");
            fwbt.SetTitle("Meditation 17");
            fwbt.SetLength(1624);
            List<Comments> fwbtComments = new List<Comments>();
            Comments cmtFwbt = new();
            cmtFwbt._userName = "Donne";
            cmtFwbt._comments = "for affliction is a treasure and scarce any man have enough of it";
            fwbtComments.Add(cmtFwbt);

            Comments cmtFwbt1 = new();
            cmtFwbt1._userName = "Donne";
            cmtFwbt1._comments = "no man is an island";
            fwbtComments.Add(cmtFwbt1);

            Comments cmtFwbt2 = new();
            cmtFwbt2._userName = "Donne";
            cmtFwbt2._comments = "...it tolls for thee";
            fwbtComments.Add(cmtFwbt2);

            fwbt._comment = fwbtComments;

            //Display
            foreach (Video v in videoList)
            {
                Console.WriteLine("----");
                Console.WriteLine($"{v.GetData()} (Comment count: {v.GetCommentCount()})");
                //Console.WriteLine(v.GetCommentCount());
                foreach (Comments c in v._comment)
                {
                    Console.WriteLine($"  ({c._userName}) {c._comments}");
                }
            }
        }
    }
}