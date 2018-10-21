var APPLICATION_KEY = "c9562aced31c61c39b020f1a4f1e9065c04f3a097b96da3f935bf6322f2ba3a2";
var CLIENT_KEY = "bc06b250ce74514e61400017fda151486294f13a03ce7e04d9cdf017d1b88a43";
var NCMB_KEY = NCMB.init(APPLICATION_KEY, CLIENT_KEY);

function abcdefg() {
//var Data = NCMB_KEY.DataStore("FarmsData");

  var DataClass = NCMB_KEY.DataStore("");
  var results = DataClass
    .fetchAll();

  var text =   results[0].get("");
  //Logger.log(text);
  //push(user_id, text);
}


function sendData(userName, lineId) {
  var Data = NCMB_KEY.DataStore("Users");
  var data = new Data();
  data.set("user_name", userName)
      .set("line_id", lineId)
      .save();
}




function chkUser(userName, lineId) {
  var DataClass = NCMB_KEY.DataStore("Users");
  var results = DataClass
    .fetchAll();
  var userNames = [];
  for (var i = 0; i < results.length; i++) {
    if (results[i].get("user_name") == userName) {
      if (results[i].get("line_id") == lineId) {
        return 2;//登録済み
      }else {
        results[i].set("line_id", lineId)
                  .update();
        return 1;//登録
      }
    }else if (results[i].get("line_id") == lineId) {
      return 3;//達成！！かも
    };

  }

  return 0;//登録できない

}


function asfghj() {
  sendData("わだどん", WATSON_ID);
 // var userNames = chkUser("gjkl")
 // Logger.log(userNames);
}
