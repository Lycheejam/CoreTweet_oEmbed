using CoreTweet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTweet.Streaming;
using CoreTweet.Rest;

namespace CoreTweetTest {
    class Program {
        static void Main(string[] args) {
            //var s = OAuth.Authorize("Consumer_key", "Consumer_Secret");
            //PINコードを取得するためのURLを発行
            //Console.WriteLine("access here: {0}", s.AuthorizeUri);

            //PINコードを入力
            //var pin = Console.ReadLine();
            //var t = s.GetTokens(pin);

            //テストツイート
            //t.Statuses.Update(status => "CoreTweet Tutorial hello");

            //テストがてらタイムラインを取得
            //foreach (var status in t.Statuses.HomeTimeline(count => 50).Where(x => x.Text.Length > 60))
            //Console.WriteLine("long tweet by {0}: {1}", status.User.ScreenName, status.Text);


            //作成されたトークンからAccessTokenとAccessTokenSecretを取得
            //Console.WriteLine("AccessToken:{0}",t.AccessToken);
            //Console.WriteLine("AccessTokenSecret:{0}", t.AccessTokenSecret);

            //先程取得したAccessTokenとAccessTokenSecretを貼り付けてトークンを生成
            //var t = Tokens.Create("Consumer_key",
            //    "Consumer_Secret",
            //    "AccessToken",
            //    "AccessTokenSecret");
            ////PINコード無しでツイートできる。
            //var res = t.Statuses.Update(status => "CoreTweetReplyTest");
            ////リプライツイートのテスト
            //res = t.Statuses.Update(status => "Reply Test1", in_reply_to_status_id => res.Id);
            //res = t.Statuses.Update(status => "Reply Test2", in_reply_to_status_id => res.Id);
        }
    }
}
