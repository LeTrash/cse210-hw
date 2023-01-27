using System.IO;

public class Save{

public string _newfilenam;
public string _journalEntries;
public void SaveJournal(string journal){
    var jelly = File.ReadLines(_journalEntries);
using (StreamWriter outputFile = new StreamWriter(_newfilenam,true))
foreach(string line in jelly)
{
    outputFile.WriteLine(line);
}
}
}