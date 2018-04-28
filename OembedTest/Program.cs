using CoreTweet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OembedTest {
    class Program {
        static void Main(string[] args) {
            var t = Tokens.Create("zTYIj5gGCqlhYKFIX3ctsaKWr",
                                  "Z4iy30zrNMJ07ZsCyV33QQoWe8lJD0SfLTK538mizKYqsJ2arq",
                                  "160376374-RZ161IPRjPmyJD8lwqjojss3dELCSGOvXEx4b6Qq",
                                  "RzBDLR9sOPcLVkOm6yyORiECfejPHHzFWoEFAdQQGPjol");
            // 文章のみのツイート 988431204717281280
            long TextTweetId = 988431204717281280;
            // 文章のみ（スレッド） 988815281005867008
            long ThreadTweetId = 988815281005867008;
            // 画像付き 970310371847237632
            long PhotoTweetId = 970310371847237632;
            // 動画（youtube） 950399002557607936
            long VideoTweetId = 950399002557607936;

            //パラメータなし
            var emb = t.Statuses.Oembed(TextTweetId);
            Console.WriteLine("パラメータなし：{0}", emb.Html);
            //maxwidth指定 220
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , maxwidth => 220);
            Console.WriteLine("maxwidth220：{0}", emb.Html);
            //maxwidth指定 550
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , maxwidth => 550);
            Console.WriteLine("maxwidth550：{0}", emb.Html);
            //メディア表示
            emb = t.Statuses.Oembed(id => PhotoTweetId
                                    , hide_media => false);
            Console.WriteLine("メディア表示：{0}", emb.Html);
            //メディア非表示
            emb = t.Statuses.Oembed(id => PhotoTweetId
                                    , hide_media => true);
            Console.WriteLine("メディア非表示：{0}", emb.Html);
            //スレッド表示
            emb = t.Statuses.Oembed(id => ThreadTweetId
                                    , hide_thread => false);
            Console.WriteLine("スレッド表示：{0}", emb.Html);
            //スレッド非表示
            emb = t.Statuses.Oembed(id => ThreadTweetId
                                    , hide_thread => true);
            Console.WriteLine("スレッド非表示：{0}", emb.Html);
            //widgets.js読み込み有
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , omit_script => false);
            Console.WriteLine("scriptタグあり：{0}", emb.Html);
            //widgets.js読み込み無
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , omit_script => true);
            Console.WriteLine("scriptタグなし：{0}", emb.Html);
            //フレーム寄せ left
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , align => "left");
            Console.WriteLine("左寄せ（Left）：{0}", emb.Html);
            //フレーム寄せ center
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , align => "center");
            Console.WriteLine("中央寄せ（Center）：{0}", emb.Html);
            //フレーム寄せ right
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , align => "right");
            Console.WriteLine("右寄せ（Right）：{0}", emb.Html);
            //フレーム寄せ none
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , align => "none");
            Console.WriteLine("フレーム寄せ指定無し（none）：{0}", emb.Html);
            //related????
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , related => "Lychee_jam");
            Console.WriteLine("related指定：{0}", emb.Html);
            //言語仕様 english(既定？)
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , lang => "en");
            Console.WriteLine("言語仕様 英語(en)：{0}", emb.Html);
            //言語仕様 japanese
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , lang => "ja");
            Console.WriteLine("言語仕様 日本語(ja)：{0}", emb.Html);
            //テーマ（ウィジェット色） light(既定)
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , theme => "light");
            Console.WriteLine("テーマ light：{0}", emb.Html);
            //テーマ（ウィジェット色） dark
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , theme => "dark");
            Console.WriteLine("テーマ dark：{0}", emb.Html);

            //リンクカラー（ハッシュタグ/@hogehoge/URL）
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , link_color => "#2ECCFA");
            Console.WriteLine("リンクカラー：{0}", emb.Html);

            //ウィジェット仕様 ビデオ専用
            emb = t.Statuses.Oembed(id => VideoTweetId);
            Console.WriteLine("Video通常：{0}", emb.Html);
            emb = t.Statuses.Oembed(id => VideoTweetId
                                    , widget_type => "video");
            Console.WriteLine("Video専用：{0}", emb.Html);
            //dnt(データ利用可)
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , dnt => true);
            Console.WriteLine("広告利用可：{0}", emb.Html);
            //dnt(データ利用不可)
            emb = t.Statuses.Oembed(id => TextTweetId
                                    , dnt => false);
            Console.WriteLine("広告利用不可：{0}", emb.Html);
        }
    }
}
