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
        +public void GetName()
        +public void SetPoints()
        +public void GetPoints()
        +public void SetDescription()
        +public void SetPointValue()
        +public void SetComplete()
        +public void GetComplete()
===============================================
            
==============================================
        SimpleGoal : Goal
--------------------------------------------------
        -from base class
---------------------------------------------------
        +public SimpleGoal()
        +public override void PrintGoal()
================================================

===============================================
        EternalGoal : Goal
--------------------------------------------------
        -from base class
---------------------------------------------------
        +public EternalGoal()
        +public override void PrintGoal()
================================================

===============================================
        ChecklistGoal : Goal
--------------------------------------------------
        -from base class
        -private int accomplishedPoints
        -private in timesToComplete
---------------------------------------------------
        +public ChecklistGoal()
        +public override void PrintGoal()
        +public void SetaccomplishedPoints()
        +public void timesToComplete()
        +public void CompleteTime()
================================================



    -------------------------------------------------------------
    |                                                           |
    |                                                           |
    \/                                                          |
txt file --> SimpleGoal ------>Goal --> ---\                    |
        |__> EternalGoal ----->Goal -->   Menu --> List<Goal> _goals 
        |__> ChecklistGoal --> Goal --> ---/



