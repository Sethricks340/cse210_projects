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