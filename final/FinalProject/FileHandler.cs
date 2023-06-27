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
}