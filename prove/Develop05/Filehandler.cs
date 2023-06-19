public class Filehandler
{

    public int Save(int totalPoints, List<Goal> goals, bool loaded, string filename)
    {
        Filehandler _filehandler = new Filehandler();

        if (!loaded)
        {
            totalPoints = _filehandler.Load(totalPoints, goals, filename);                            
            loaded = true;
        }

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine($"{totalPoints}");
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalDetails()); 
            }
        }
        return totalPoints;
    }

    public int Load(int totalPoints, List<Goal> goals, string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        totalPoints += int.Parse(lines[0]);
        int i;
        for (i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            string type = parts[0];

            if (type == "ChecklistGoal")
            {
                //return $"ChecklistGoal|{_goalName}|{_description}|{_pointValue}|{_bonus}|{_timesToComplete}|{_timesCompleted}";
                CheckListGoal checkListGoal = new CheckListGoal();
                string goalName = parts[1];
                checkListGoal.SetName(goalName);
                string goalDescription = parts[2];
                checkListGoal.SetDescription(goalDescription);
                int goalPoints = int.Parse(parts[3]);
                checkListGoal.SetPoints(goalPoints);
                int bonus = int.Parse(parts[4]);
                checkListGoal.SetBonus(bonus);
                int timesToComplete = int.Parse(parts[5]);
                checkListGoal.SetTimesToComplete(timesToComplete);
                int timesCompleted = int.Parse(parts[6]);
                checkListGoal.SetTimesCompleted(timesCompleted);
                goals.Add(checkListGoal);
            }

            else if (type == "SimpleGoal")
            {
                //  return $"SimpleGoal|{_goalName}|{_description}|{_pointValue}|{_completed}";
                SimpleGoal SimpleGoal = new SimpleGoal();
                string goalName = parts[1];
                SimpleGoal.SetName(goalName);
                string goalDescription = parts[2];
                SimpleGoal.SetDescription(goalDescription);
                int goalPoints = int.Parse(parts[3]);
                SimpleGoal.SetPoints(goalPoints);
                bool complete = bool.Parse(parts[4]);
                SimpleGoal.SetCompleteVariable(complete);
                goals.Add(SimpleGoal);
            }

            else if (type == "EternalGoal")
            {
                // return $"EternalGoal|{_goalName}|{_description}|{_pointValue}";
                EternalGoal eternalGoal = new EternalGoal();
                string goalName = parts[1];
                eternalGoal.SetName(goalName);
                string goalDescription = parts[2];
                eternalGoal.SetDescription(goalDescription);
                int goalPoints = int.Parse(parts[3]);
                eternalGoal.SetPoints(goalPoints);
                goals.Add(eternalGoal);
            }
        }
        return totalPoints;
    }
}