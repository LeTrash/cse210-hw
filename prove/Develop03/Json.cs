using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


//     try{
//         string path = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/book-of-mormon-flat.json";
//         StreamReader r = new StreamReader(path);
//         var json = r.ReadToEnd();
//         r.Close();
//         Console.WriteLine(json + "was read from"+path);
//     }
//     catch(FileNotFoundException){
//         Console.WriteLine("No file with such a name was found!");
//     }
//     catch (DirectoryNotFoundException){
//         Console.WriteLine("Directory doesn't exist!");
//     }
//     catch (Exception ex){
//         Console.WriteLine("Something went wrong..."+ ex.Data);
//     }
//     }
// }

//  "verses": [
//         {
//             "reference": "1 Nephi 1:1",
//             "text": "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."
//         },
//         {
//             "reference": "1 Nephi 1:2",
//             "text": "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians."
//         },

public class Json
{


    public string verses { get; set; }
    public string references { get; set; }
    public string verse { get; set; }

    public void readToFile(string filepath)
    {

        Console.WriteLine("Please enter a heading:");
        string u_heading = Console.ReadLine();
        Console.WriteLine("Please enter the chapter number: ");
        string u_chapt = Console.ReadLine();
        Console.WriteLine("Please enter the verse number: ");
        string u_verse = Console.ReadLine();
        string u_ref = u_heading + " " + u_chapt + ":" + u_verse;

        StreamReader reader = new StreamReader(filepath);
        bom = reader.Parse(File.ReadAllText(filepath));
        while (!reader.EndOfStream || reader.key = u_ref)
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
        reader.Close();





    }
}








// JArray data = JArrary.Parse(File.ReadAllText(filepath));            
// foreach(KeyValuePair<string, string> i in readText){
//     if(i["reference"] == u_ref){
//         Console.WriteLine("reference: {0}, text: {1}", i.Key, i.Value);
//     }
// if (filepath["reference"] == u_ref){
// string v = filepath["text"];
// }
