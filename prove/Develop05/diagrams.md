==============================================
        Menu
-------------------------------------------------
        -public List<Goal> _goals 
--------------------------------------------------
        +Public Menu()
        +Display()
            *Create New Goal
            *List Goals
            *Save Goals
            *Load Goals
            *Record Event
            *Quit
==============================================

==============================================
        public abstract Goal
-------------------------------------------------
        -protected string _goalName
        -protected string _description
        -protected int _pointValue
        -protected bool _completed
--------------------------------------------------
        +public Goal()
        +public abstract void DisplayGoal()
        +public void SetName()
        +public string GetName()
        +public void SetPoints()
        +public int GetPoints()
        +public void SetDescription()
        +public void SetComplete()
        +public bool GetComplete()
===============================================
            
==============================================
        SimpleGoal : Goal
--------------------------------------------------
        -from base class
---------------------------------------------------
        +public SimpleGoal()
        +public override void DisplayGoal()
================================================

===============================================
        EternalGoal : Goal
--------------------------------------------------
        -from base class
---------------------------------------------------
        +public EternalGoal()
        +public override void DisplayGoal()
================================================

===============================================
        CheckListGoal : Goal
--------------------------------------------------
        -from base class
        -private int accomplishedPoints
        -private int timesToComplete
---------------------------------------------------
        +public ChecklistGoal()
        +public override void DisplayGoal()
        +public void SetAccomplishedPoints()
        +public void TimesToComplete()
        +public void CompleteTime()
================================================



    -------------------------------------------------------------
    |                                                           |
    |                                                           |
    \/                                                          |
txt file --> SimpleGoal ------>Goal --> ---\                    |
        |__> EternalGoal ----->Goal -->   Menu --> List<Goal> _goals 
        |__> ChecklistGoal --> Goal --> ---/



