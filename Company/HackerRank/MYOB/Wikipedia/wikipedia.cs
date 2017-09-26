using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
class Solution {


  /*
   * Complete the function below.
   */
      static int getTopicCount(string topic) {


      }


  static void Main(String[] args) {
    string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
    TextWriter tw = new StreamWriter(@fileName, true);
    int res;
    string _topic;
    _topic = Console.ReadLine();

    res = getTopicCount(_topic);
    tw.WriteLine(res);

    tw.Flush();
    tw.Close();
}
}
