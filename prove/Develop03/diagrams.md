
What I came up with on my own:
============================
        Scripture
----------------------------
        -private string _scripture
        -private string _reference
-----------------------------
        + Scripture()
        + DisplayScripture()
        + RemoveRandomWords()
        + ScriptureCompletelyHidden
=============================
            
============================
        Reference
-----------------------------
        -private string book
        -private int chapter
        -private int firstVerse
        -private int lastVerse = ""
------------------------------
        +Reference(string book, int chapter, int firstVerse)
        +Reference(string book, int chapter, int firstVerse, int lastVerse)
        +AddSemicolon() ?
==============================

=============================
        Word
-----------------------------
        -Private List<Letter>
------------------------------
        +Word()
        +ReplaceWordWithSpaces()
==============================



What we did in class:
============================
        Scripture
----------------------------
        -List<word> _words
        -Reference ref
-----------------------------
        + HideRandomWord
        + ScriptureCompletlyHidden
        + ParseScripture
        + Display
=============================
            
============================
        Reference
-----------------------------
        -string book
        -int chapter
        -int firstVerse
        -int lastVerse = ""
------------------------------
        +Reference(string book, int chapter, int firstVerse)
        +Reference(string book, int chapter, int firstVerse, int lastVerse)
        +Display()
==============================

=============================
        Word
-----------------------------
        -string word
        -boolean shown = true
------------------------------
        +display()
        +hideword()
==============================