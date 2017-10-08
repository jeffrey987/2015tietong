using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBUtility;
using System.Data;
using System.Text;

namespace WebApplication1.Models
{
    public class dal
    {
        public List<Models.message> GetModelByList(string where)
        {
            List<Models.message> lists = new List<message>();

            StringBuilder strSql = new StringBuilder();

            strSql.Append("select * from Message  ");
            if (!string.IsNullOrEmpty(where))
            {
                strSql.Append("where " + where);
            }

            var ds = DbHelperSQL.Query(strSql.ToString());

            try
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    var temp_model = DataRowToModel(item);
                    lists.Add(temp_model);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lists;
        }
        private Models.message DataRowToModel(DataRow row)
        {
            Models.message model = new Models.message();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["texts"] != null)
                {
                    model.texts = row["texts"].ToString();
                }
                
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
            }
            return model;
        }
    }
}