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

It's a jumping game where you click to jump over an obstacle, if you get hit, the game ends and you can restart the game to play again. There is also a point system that adds 10 points everytime you succesfully jump over the object.

Here's a short gif of the game:


![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/Prototype1.gif)

# Journal-W03-Prototype2
## Prototype 2: Design Reflection; February 6th, 2025

For this week’s Prototype 2 project, I continued to experiment with Unity. I focused on adding some simple features, like making the ball change color and increase in size every time it hits either the paddle or the wall, as well as having the paddle size increase after each hit.

What Worked:
The ball's behavior when it changes color after each collision worked smoothly. I used Random.value to generate a random color for the ball, and it successfully updates every time the ball hits the paddle or the wall. It added a bit of randomness and visual appeal to the game.

The paddle size increase was also implemented as planned. Each time the ball hits the paddle, I increased the paddle size by a fixed amount of 0.5f. This added a cool dynamic element to the game, making the player’s paddle grow after each successful hit, which makes it easier to hit the ball again.

What Didn’t Work:
One issue I faced was with the ball script not working as expected. After spending a lot of time debugging, I realized I hadn’t assigned the correct tag to the ball object in Unity, which led to the script not referencing it properly during collisions. It was a small mistake, but it was a good reminder to always check object tags when referencing them in code.

Reflection:
This week, I continued to explore Unity’s scripting system, and I’m starting to feel more comfortable with its workflow. The random color change and paddle size increase are small features, but they made the game feel more dynamic. For the future, I’d like to implement more gameplay-changing mechanics, such as obstacles or power-ups, that could alter the way the player interacts with the game. I also want to refine the gameplay further, possibly by introducing difficulty progression or adding new challenges to keep things interesting.


![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/Prototype2.gif)