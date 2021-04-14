// Project: Cheat with ubersuggest 
// 4-13-2021 (14 years now)
// Start: 11:29 AM
// End:   11:43 AM

//You don't need to buy a pro version of ubersuggest for unlimited keyword research. 
//Just put all of your keyword in the allkeyword arry.
//And visit the site that the code recomend you to visit.


using System;
class HelloWorld {
   static String[] allkeywords={"keyword_1_here","keyword_2_here","keyword_3_here"};// You can delate or add more keywords to it.
       // for example: static String[] allkeywords={"how","to","make","money","online"};//
       // Dont't use any SPACE between keywords. Take another string in this arry and put your next keyword there.
  static void Main() {
      if(allkeywords.Length>0){
                
     Console.WriteLine("Visit This Site(if you didn't use any spcae between your krywords)-->>");
      
     Console.WriteLine(theurl());
      }else{
          Console.WriteLine("You need atleast 1 keyword");
      }
  }
  
  static String theurl(){
      
      int keywordslength=allkeywords.Length;
      
      String url="https://app.neilpatel.com/en/ubersuggest/keyword_ideas?keyword=";
      
      if(keywordslength>1){
          for(int i=0;i<keywordslength-1;i++){
          url+=allkeywords[i]+"%20";
          }
        url+= allkeywords[keywordslength-1]+"&locId=2840&lang=en";
      }else{
          url+=allkeywords[0]+"&locId=2840&lang=en";
      }

      return url;
  }
  
}
