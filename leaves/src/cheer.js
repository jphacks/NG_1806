

//定期実行
function cheer() {
  var DataClass = NCMB_KEY.DataStore("Users");
  var resultsU = DataClass
    .fetchAll();
  Logger.log(resultsU.length)
    var userNames = [];
    for (var i = 0; i < resultsU.length; i++) {
      var userName = resultsU[i].get("user_name");
      Logger.log(userName)
      var DataClass = NCMB_KEY.DataStore("Messages");
      var resultsM = DataClass
        .equalTo("Byname", userName)
        .fetchAll();
        Logger.log(resultsM[0])
      if (resultsM[0] != undefined){
       var number = Math.floor(Math.random()*resultsM.length);
      // Logger.log(resultsM);
       Logger.log(resultsM[number].get("Message"));
       push(resultsU[i].get("line_id"), "応援メッセージが届いています！\n\n" + resultsM[number].get("Message"));
       }
//      var text =   resultsM[0].get("message");

    }
}

//水減らす
function dry(){
  var DataClass = NCMB_KEY.DataStore("Cheer");
  var results = DataClass
    .fetchAll();
  for (var j = 0;j < results.length; j++){
  for (var i = 1;i < 4; i++){
  if (results[j].get("Water" + String(i)) != null){
    results[j].set("Water" + String(i), results[j].get("Water"  + String(i)) - 1)
    }
  }
     results[j].update()
   }
}
