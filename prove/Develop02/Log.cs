using System;

public class Log{
    
    public string _dateTime;
    public string _response;
    public string[] _prompts ={
        "Write about the most depressing thing in your life.","Write about loss.","fghj","Go to jail"
    };

    public string displayprompt(){
    Random rand = new Random();
    int num= rand.Next(4);
    string prmt = _prompts[num];

    Console.Write("Here is a suggested prompt:");
    Console.WriteLine(prmt);
    return prmt;
    }
    
    string fileName = "Journal.txt";

    public void SaveFile(string p){
        using (StreamWriter outputFile = new StreamWriter(fileName, true)){
                outputFile.WriteLine();
                outputFile.WriteLine(_dateTime);
                outputFile.WriteLine(p);
                outputFile.WriteLine(_response);
            }
    }
    

    
}
