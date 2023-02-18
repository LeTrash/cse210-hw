using System;
// using System.IO;
// using System.Net.Http;
// using System.Net.Http.Json;
// using System.Text.Json;
using Newtonsoft.Json.Linq;


public class Json
{

    public string phrase = "hi";

    public string Getphrase()
    {
        return phrase;
    }

    public async void readToFile(string filepath)
    {
        // List<string> v_text = new List<string>();

        Console.WriteLine("Please enter a heading:");
        string u_heading = Console.ReadLine();
        Console.WriteLine("Please enter the chapter number: ");
        string u_chapt = Console.ReadLine();
        Console.WriteLine("Please enter the verse number: ");
        string u_verse = Console.ReadLine();
        string u_ref = u_heading + " " + u_chapt + ":" + u_verse;
        // Console.WriteLine(filepath);

        // StreamReader reader = new StreamReader(filepath);
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(filepath);

        response.EnsureSuccessStatusCode();
        String responseBody = await response.Content.ReadAsStringAsync();
        JObject json = JObject.Parse(responseBody);
        foreach (JObject i in json["verses"])
        {

            if ((string)i["reference"] == u_ref)
            {
                phrase = (string)i["text"];
                Console.Write(i["reference"]);


            }
        }


    }
}


// foreach (var word in words)
// {
//     Console.Write($" {word} ");
// }


// string[] words = phrase.Split(" ");
// v_text.Add((string)i["text"]);
// Console.WriteLine(string.Join(" ", v_text));


// JArray data = JArrary.Parse(File.ReadAllText(filepath));            
// foreach(KeyValuePair<string, string> i in readText){
//     if(i["reference"] == u_ref){
//         Console.WriteLine("reference: {0}, text: {1}", i.Key, i.Value);
//     }
// if (filepath["reference"] == u_ref){
// string v = filepath["text"];
// }
// bom = reader.Parse(File.ReadAllText(filepath));
// while (!reader.EndOfStream || reader.key = u_ref)
// {
//     string line = reader.ReadLine();
//     Console.WriteLine(line);
// }
// reader.Close();

// data['username]
//foreach(var "reference" in "")