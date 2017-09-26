using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WikipediaArticle
{
    class Program
    {
        /*
      * Complete the function below.
    */
        static int getTopicCount(string topic)
        {
            string baseURI = "https://en.wikipedia.org/w/api.php?action=parse&section=0&prop=text&format=json&page={0}";
            string request = String.Format(baseURI, topic);
            int topicCount=0;

            using (HttpClient newClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = newClient.GetAsync(request).Result;
                    
                    response.EnsureSuccessStatusCode();

                    string responseBody = response.Content.ReadAsStringAsync().Result;


                    string queryCommand = "parse.text";

                    string returnText = GetJsonPropertyValue(responseBody,queryCommand);

                    int index = returnText.IndexOf(topic);

                    while (index >= 0)
                    {
                        index = returnText.IndexOf(topic, index + 1);
                        topicCount++;
                    }

                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Get response from URI {0} failed with exception {1}",request,e.Message);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Get response from URI {0} failed with exception {1}", request, e.Message);
                }
            }

            return topicCount;
        }

        public static string GetJsonPropertyValue(string json, string query)
        {
            string result="";
            try
            {
                JToken token = JObject.Parse(json);

                foreach (string queryCommand in query.Split('.'))
                {

                    token = token[queryCommand];
                }

                result = token.ToString();
           
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("Null Reference Exception happened in GetJsonPropertyValue");
            }
            catch(Exception)
            {
                throw new Exception("Exception happened in GetJsonPropertyValue");
            }

            return result;
        }

        static void Main(string[] args)
        {

         //   string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
          //  TextWriter tw = new StreamWriter(@fileName, true);
            int res;
            string _topic;
            _topic = Console.ReadLine();

            res = getTopicCount(_topic);
            //  tw.WriteLine(res);
            System.Console.WriteLine(res);


            System.Console.ReadLine();
         //   tw.Flush();
         //   tw.Close();
        }
    }
}
