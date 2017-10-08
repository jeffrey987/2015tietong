using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class message
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _user_id;

        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        private string _texts;

        public string texts
        {
            get { return _texts; }
            set { _texts = value; }
        }
        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }


    }
}