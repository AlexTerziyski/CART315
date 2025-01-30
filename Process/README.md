# Journal-W01-MakeaThing

## Make-a-Thing: Design Reflection; January 23rd, 2025

For my "Make-a-Thing" project, I created a very short text-based game using Ink, a narrative scripting language. The game is simple, but using something new like Ink is always a cool experience.

What Worked:
Ink's structure made it easy to set up branching choices quickly. Commands like * for choices and -> for directing the flow helped me keep everything organized, even with a short story.

What Didn't Work:
The syntax was a bit tricky at first. Ink's formatting is different from other coding languages I've used like Javascript or Python, and understanding how to use commands like === (sections), -> DONE (end of a path), and -- (non-branching outcomes) took some getting used to and was a bit confusing. Even small mistakes, like misplacing an indent, caused issues.

Reflection:
Although the game is short, it was a good introduction to interactive storytelling. I learned how to use Ink's basic features, like creating choices with * and adding sub-choices with * *. I’d like to explore more of Ink’s features, like tracking player decisions or adding conditions, in future projects.

Quick Syntax Notes:
->: Directs the flow to a specific section.
===: Marks the start of a new section.
*: Creates a choice.
**: Adds a sub-choice.
--: Non-branching outcomes.
-> DONE: Ends a sequence or path.
-> END: Ends the story completely.

Here’s a screenshot of Ink’s interface and the short game interaction I made:
![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/InklePhoto.png)


#Play tested in-class and people liked it more than expected. It was just something to get started with, so I will expand on it in the future.

# Journal-W02-Prototype1
## Prototype 1: Design Reflection; January 30th, 2025

For this week’s Prototype 1 project, I attempted to make a simple 2D game with Unity and C#. I focused on applying some of the concepts we covered in class, like collision detection, physics, scripting, and working with game objects.

What Worked:
Setting up the basic game mechanics went smoothly. Unity’s built-in physics engine made it easy to apply movement, and scripting player controls felt straightforward once I got familiar with how Unity handles inputs. Collision detection also worked well, and I was able to make the player react to obstacles properly.

What Didn’t Work:
Scripting the game manager was trickier than expected. Managing states like starting, restarting, and ending the game required more organization than I anticipated. At first, my code got a bit messy, and I had trouble keeping track of different game objects interacting with each other. Debugging also took longer than I thought, especially when trying to get UI elements (like a score system) to update correctly.

Reflection:
Even though it’s just a basic prototype, this project helped me get more comfortable with Unity and C#. I learned how to structure my scripts better and troubleshoot issues more effectively. Next time, I want to refine the UI elements and add more interaction to make the game feel more polished.

Here's a short gif of the game:
![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/Prototype1.gif)