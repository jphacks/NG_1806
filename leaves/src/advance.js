function sendBottun(replyToken, lineId) {



  var DataClass = NCMB_KEY.DataStore("Users");
  var resultsU = DataClass
      .equalTo("line_id", lineId)
      .fetchAll();
  var userName =   resultsU[0].get("user_name");

  var DataClass = NCMB_KEY.DataStore("Cheer");

  var resultsC = DataClass
      .equalTo("Name", userName)
      .fetchAll();
  var actions = [];
  Logger.log(resultsC[0].get("Obj1") != null)
  if (resultsC[0].get("Obj1") != null){
    var action = {
      'type':'message',
      'label':resultsC[0].get("Obj1"),
      'text':resultsC[0].get("Obj1") + "を続けてます",
    };
    actions.push(action);

  };
  if (resultsC[0].get("Obj2") != null){
    action = {
      'type':'message',
      'label':resultsC[0].get("Obj2"),
      'text':resultsC[0].get("Obj2") + "を続けてます",
    };
    actions.push(action);
  };
  if (resultsC[0].get("Obj3") != null){
    action = {
      'type':'message',
      'label':resultsC[0].get("Obj3"),
      'text':resultsC[0].get("Obj3") + "を続けてます",
    };
    actions.push(action);
  };

  Logger.log(actions)
  var postData = {
         'replyToken': replyToken,
         "messages" : [
           {
               'type':'template',
               'altText':"どのタスクを続けてますか？",
               'template':{
                 'type':'buttons',
                 'text': "どのタスクを続けてますか？",
                 'actions':actions
               },
           },
         ]
  }
  var url = "https://api.line.me/v2/bot/message/reply";
  var headers = {
    "Content-Type" : "application/json; charset=UTF-8",
    'Authorization': 'Bearer ' + ACCESS_TOKEN,
  };
  var options = {
    "method" : "post",
    "headers" : headers,
    "payload" : JSON.stringify(postData)
  };
  return UrlFetchApp.fetch(url, options);
}


function water(replyToken, lineId, task){
  var DataClass = NCMB_KEY.DataStore("Users");
  var resultsU = DataClass
      .equalTo("line_id", lineId)
      .fetchAll();
  var userName =   resultsU[0].get("user_name");
  var DataClass = NCMB_KEY.DataStore("Cheer");
  var resultsC = DataClass
      .equalTo("Name", userName)
      .fetchAll();

  for (var i = 1; i < 4; i++) {
    Logger.log(task + "   " +  resultsC[0].get("Obj" + String(i)))
    if ((resultsC[0] != null) && (task == resultsC[0].get("Obj" + String(i)))) {
      resultsC[0].set("Water" + String(i), 3)
      resultsC[0].update();
      Logger.log(resultsC[0].get("Water"+ String(i)))
    }
  }
  reply(replyToken, "今日の目標達成！頑張ったね！")
}
