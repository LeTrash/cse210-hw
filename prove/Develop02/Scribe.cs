using System.IO;

public class Scribe{

  
public string userFile;

public string askfile(){

Console.WriteLine("Please provide a file name: ");
string fn = Console.ReadLine();
return fn;
}


public void replace(string filenam, string fileName){
    var pent = File.ReadLines(filenam);
    using(StreamWriter outputFile = new StreamWriter(fileName))
    foreach(string line in pent){
        outputFile.WriteLine(line);
    }
}



}