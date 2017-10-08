

using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSocketSharp;

namespace WebApplication1.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            string where = "user_id=1";
            Models.dal dal = new Models.dal();
            var list = dal.GetModelByList(where);
            ViewBag.list = list;

            return View();
        }
        public ActionResult SendMessage()

        {
            //using (var ws = new WebSocket("ws://example.com"))
            //{
            //    ws.OnOpen += (sender, e) => { Console.WriteLine("websocket 链接开始"); };
            //    ws.OnMessage += (sender, e) =>
            //    {
            //        if (e.IsText)
            //        {

            //        }
            //        Console.WriteLine("Laputa says: " + e.Data);
            //    };
            //    ws.OnError += (sender, e) =>
            //    {
            //        Console.WriteLine("error:" + e.Message);
            //    };
            //    ws.Connect();
            //    ws.Send("BALUS");
            //    ws.Close();

            //}
            return View();
        }
    }
}