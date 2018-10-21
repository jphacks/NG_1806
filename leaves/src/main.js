
// line developersに書いてあるChannel Access Token
var ACCESS_TOKEN = "G8SDFCxZENS92HvcGCelyn+dMmoNzBknec03kiDo05vO3PG+jKUTe8+aoL2yWuc4FRmiybXI9uzJGGbLchQ9xW/YaJEwOt6yYiTi8IQGQbZ0oSmsxpXy5IVFqx0wN0i+kQAiBjE/j9H5FoCzfQlrGQdB04t89/1O/w1cDnyilFU="
// pushしたいときに送る先のuser_idで、自分の値はスプレッドシートに残るログを見ればわかる
//var user_id = ‘*****’;
var WATSON_ID = 'U5f0607c7da83ff31526d46ac6c1ca009';
// postされたログを残すスプレッドシートのid
//var spreadsheet_id = "11HOihEMwMFq_UyCvtT4EjHq489rq_pY0qqV1_NGhUjw";

/**
 * postされたときの処理
 */
function doPost(e) {
  var json = JSON.parse(e.postData.contents);
  var post = json.events[0];
  //  var data = SpreadsheetApp.openById(spreadsheet_id).getSheetByName('log1').getRange(1, 1).setValue(json.events);
  var type = post.type;
  var gotText = post.message.text;
  var replyToken = post.replyToken;
  var userId = post.source.userId;
  //SpreadsheetApp.openById(spreadsheet_id).getSheetByName('log1').getRange(1, 2).setValue(gotText);
  //SpreadsheetApp.openById(spreadsheet_id).getSheetByName('log1').getRange(1, 3).set Value(json.events[0].timestamp / 1000);
  //  var talkType = json.events[0].source.type;



switch (type) {
  case 'follow'://追加

    break;
  case 'unfollow': //ブロック

    break;
  case 'message'://メッセージの場合
    var message = post.message;
    var chk = chkUser(gotText, userId);
    switch (chk) {
      case 0:
        reply(replyToken, "ユーザーデータがありません。")
        break;
      case 1:
        reply(replyToken, "登録しました。")
        break;
      case 2:
          reply(replyToken, "もう登録されています。")
        break;
      case 3:
        if (gotText == "継続") {
          sendBottun(replyToken, userId);
        }else if (gotText.match(/を続けてます$/) != null) {
          water(replyToken, userId, gotText.slice(0, gotText.length - 6));

        }else{
        };
        break;
      default:

    }
    break;
  default:
    break;
  }





 }




/**
 * pushをしてみる
 */
function debug(text) {
  push(WATSON_ID, text);
}
