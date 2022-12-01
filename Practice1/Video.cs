using System;
using System.Collections.Generic;

namespace Practice1
{
    public class Video
    {
        private string _title = "";
        private string _author = "";
        private int _length = 0;
        public List<Comments> _comment;

        public Video()
        {

        }

        public string GetData()
        {
            return _title + " " + _author + " " + _length.ToString();
        }
        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            _title = title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public void SetAuthor(string author)
        {
            _author = author;
        }
        public int GetLength()
        {
            return _length;
        }
        public void SetLength(int length)
        {
            _length = length;
        }
        public int GetCommentCount()
        {
            return _comment.Count;
        }
       
    }
}
