using System;

public class Log{
    string fileName = "Journal.txt";
    public string _dateTime;
    public string _response;
    public string[] _prompts ={
        "Did you talk to someone today and what about?","Did you accomplish anything today?","What were you most proud of today?","What did you eat today?"
    };

    public string displayprompt(){
        Random rand = new Random();
        int num= rand.Next(4);
        string prmt = _prompts[num];

        Console.Write("Here is a suggested prompt:");
        Console.WriteLine(prmt);
        return prmt;
    }
    

    public void SaveFile(string p){
        using (StreamWriter outputFile = new StreamWriter(fileName, true)){
                outputFile.WriteLine();
                outputFile.WriteLine(_dateTime);
                outputFile.WriteLine(p);
                outputFile.WriteLine(_response);
            }
    }
    

    
}
