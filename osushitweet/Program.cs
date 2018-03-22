using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTweet;

namespace osushitweet
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = CoreTweet.Tokens.Create(
                "XXXXXXXXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                "999999999999999999-XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            var text = "hello #test";
            tokens.Statuses.Update(new { status = text });
        }
    }
}
