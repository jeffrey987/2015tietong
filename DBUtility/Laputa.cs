using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace DBUtility
{
    public class Laputa : WebSocketBehavior
    {

        protected override void OnMessage(MessageEventArgs e)
        {
            var msg = "test";

            base.OnMessage(e);
        }
    }
}
