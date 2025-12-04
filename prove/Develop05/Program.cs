/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
November 14, 2025

W10 Prove: Developer
Polymorphism Development Project
Unit 05 Develop: Eternal Quest Program
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm1 = new GoalManager();
        gm1.Start();        
    }
}





/* 
Sites I used for help:

BYU-Idaho Videos
Chad Macbeth CSE:210 Week 5 Assignment
https://video.byui.edu/media/t/1_6lpgm7dz

*/


/*
Rubric:

Principle: Encapsulation:
All member variables are private, or they are protected if a derived class needs direct acces.

Principle: Inheritance:
Each specific type of goal class is derived from a base class.

Principle: Polymorphism:
Method overriding is used in all places where it is appropriate.

Principle: Inheriting attributes:
All methods and member variables that could be shared among classes are definied in the base class.

Functionality: Simple Goals:
Simple goals can be displayed, checked off, and points received.

Functionality: Eternal Goals:
Eternal Goals can be displayed and points received, but they cannot be markes as completed (which is the correct behavior for these goals.)

Functionality: Checklist Goals:
Checklist goals can be displayed and prgrogress can be recorded incrementally. Points are awarded each time with a bonus when the goal is finished. The goal shows as being completed when it has been accomplished the required number of times.

Functionality: User-created Goals:
The user can create new goals and specify their parameters as definied in the program specification.

Functionality: Saving/Loading:
The list of goals along with the user's progress on those goals can be saved and loaded.

Style: Whitespace vertical and horizontal whitespace (blank lines and indentation) is correct.

Style: Naming Conventions:
Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.

Shows creativity and exceeds core requirements:
The program exceeds the core requirements as explained in comments in the Program.cs.
*/