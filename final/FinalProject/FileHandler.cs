public class FileHandler
{
    public FileHandler(){}

    public void Save(){}
    public void Load(){}

    public bool CheckIDExists(int ID)
    {
        bool exists = false;
        string IDFile = "ID.txt";
        
        string[] lines = System.IO.File.ReadAllLines(IDFile);

        for (int i = 0; i < lines.Length; i++)
        {
            int line = int.Parse(lines[i]);
            
            if (ID == line)
            {
                exists = true;
            }
        }
        return exists;
    }

    public void AddID(int ID)
    {
        Console.Clear();
        FileHandler _fileHandler = new FileHandler();
        if (_fileHandler.CheckIDExists(ID))
        {
            Console.WriteLine($"Sorry, the ID {ID} exists already. ");
        }

        else
        {
            string IDFile = "ID.txt";
            using (StreamWriter outputFile = new StreamWriter(IDFile, true))
            {
                outputFile.WriteLine(ID); 
            }
        }
    }
}