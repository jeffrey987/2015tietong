using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class mu_users
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _user_name;

        public string user_name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }
        private string _mobile;

        public string mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private string _weixin;

        public string weixin
        {
            get { return _weixin; }
            set { _weixin = value; }
        }
        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        private DateTime _reg_time;

        public DateTime reg_time
        {
            get { return _reg_time; }
            set { _reg_time = value; }
        }
        private string _reg_ip;

        public string reg_ip
        {
            get { return _reg_ip; }
            set { _reg_ip = value; }
        }
        private string  _remark;

        public string  remark
        {
            get { return _remark; }
            set { _remark = value; }
        }



    }
}