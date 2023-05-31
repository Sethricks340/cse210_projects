==============================================
        Menu
-------------------------------------------------
        -private _breathing Breathing
        -private _reflection Reflection
        -private _listing Listing
--------------------------------------------------
        +Display()
==============================================

==============================================
        Mindfulness
-------------------------------------------------
        -private string _startmessage
        -private string _end_message
        -private int _duration
--------------------------------------------------
        +Mindfulness(int duration)
        +PrintStartMessage()
        +PrintEndMessage()
        +PromptDuration()
        +public virtual void Pause()
===============================================
            
==============================================
        Breathing : Mindfulness 
--------------------------------------------------
        -private string _startmessage
        -private string _end_message
---------------------------------------------------
        +Breathing() : Base(duration)
        +BreathIn(int duration)
        +BreathOut(int duration)
        +public override void Pause()
================================================

===============================================
        Reflection : Mindfulness
--------------------------------------------------
        -private string _startmessage
        -private string _end_message
        -private List<string> _prompts
---------------------------------------------------
        +Reflection() : Base(duration)
        +public override void Pause()
        +AskReflectionQuestions(duration)
        +SelectRandomPrompt()
================================================

===============================================
        Listing : Mindfulness
--------------------------------------------------
        -private string _startmessage
        -private string _end_message
        -private List<string> _prompts
---------------------------------------------------
        +Listing() : Base(duration)
        +public override void Pause()
        +AskListingQuestion(duration)
        +SelectRandomPrompt()
================================================