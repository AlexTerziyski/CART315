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

# Journal-W04-Prototype3
## Prototype 3: Design Reflection; February 13th, 2025

For this week's Prototype 3 project, I expanded upon the Breakout game by implementing a power-up system and UI display features. The main focus was on creating different types of special bricks that would affect gameplay elements like paddle size, ball speed, and lives when destroyed.

What Worked:
The implementation of different power-up bricks worked successfully after some refinement. I created three distinct power-up types (ExtendPaddle, SpeedUp, and ExtraLife) that spawn randomly among the regular bricks using a percentage-based system. The BrickLayerManager script now successfully generates a mix of regular and power-up bricks at the start of each game, adding variety to the gameplay.

The UI display system was also implemented effectively, showing real-time updates of important game statistics including lives, ball speed, paddle size, and score. This addition helps players track their progress and understand the effects of different power-ups during gameplay.

What Didn't Work:
Initially, I faced several challenges with the power-up brick implementation. The first version had the power-up bricks falling down due to an unnecessary fallSpeed variable in the script, which wasn't the intended behavior for stationary bricks. Additionally, there were issues with collision detection between the ball and power-up bricks, which was resolved by properly implementing both OnCollisionEnter2D and OnTriggerEnter2D methods and ensuring the ball object had the correct tag assigned.

Another challenge was getting the power-up effects to work correctly. Initially, all power-up bricks were triggering the same effect (paddle extension) regardless of their type. This was fixed by properly assigning the correct PowerUpType to each prefab in the Unity Inspector and ensuring the switch statement in the ApplyPowerUp method was properly implemented.

Reflection:
This week's prototype helped me better understand Unity's collision system and the importance of proper object tagging and prefab configuration. The implementation of the power-up system demonstrated how small additions can significantly impact gameplay variety. The UI system showed me how to effectively communicate game state to players.

For future implementations, I'd like to add more sophisticated power-up effects, perhaps including negative effects that could add challenge to the game. I'm also interested in implementing a proper scoring system that takes into account different brick types and potentially adding a high score feature. Additionally, creating a more polished visual feedback system for power-up effects would enhance the player experience.



![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/Prototype3.gif)
# Journal-W05-Prototype4
## Prototype 4 (Continuation of Prototype 3): Design Reflection; February 20th, 2025

This week, I continued developing my Breakout-style game by attempting to implement power-up mechanics. The main focus was trying to add a MultiBall power-up that would spawn additional balls when specific bricks are hit. While the concept seemed straightforward initially, I encountered several challenges during implementation that I haven't fully resolved yet.

The main hurdle was properly spawning the additional balls. My initial approach of trying to clone the existing ball led to complications with ball properties and behaviors. While I was able to get the power-up bricks to register hits and trigger debug messages, the actual spawning of new balls isn't functioning as intended. Based on troubleshooting and research, I believe creating a dedicated MultiBall prefab might be a more effective solution, giving better control over the spawned balls' properties such as size, color, and physics behavior. This will be my next approach when I continue working on this feature.

I also worked on ensuring game over conditions work properly, preventing lives from going negative and implementing a basic game end state. While there's still work to be done on the power-up system, these fundamental gameplay improvements help create a more polished base experience.

![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/Prototype4.png)

## Extra Credit: Game Analysis; February 20th, 2025
The Binding of Isaac's procedural generation system offers valuable insights into effective game design. What makes it particularly interesting is how it balances randomization with carefully structured patterns. While each run feels unique, the game maintains consistency through predetermined room layouts and item pools tied to specific locations.

The designers succeeded in creating variety without chaos - rooms are randomly selected but follow specific rules about enemy placement, item availability, and overall difficulty progression. This creates an experience that feels fresh each time while remaining fair and learnable.

Where some roguelikes fail with pure randomness, Isaac succeeds by implementing "controlled randomness." This approach ensures that while players never know exactly what they'll encounter, they can develop strategies based on consistent underlying systems.

For my future projects, I'm inspired to implement similar principles of controlled variability. Rather than pure randomization, I could create systems where elements vary within defined parameters - perhaps power-ups that appear in specific patterns but with randomized timing, or level layouts that combine pre-designed segments in different ways. This would help create replayable experiences while maintaining game balance and design integrity.

# Journal-W06-Iterative Prototyping 1 (Conceptualizing)
## Iterative Prototyping 1 (Conceptualizing): Design Reflection; March 6th, 2025
Design Values - Throughout my ideation, I focused on these core design values:

- Strategic Depth: Games that reward planning and forethought
- Accessibility: Easy to learn but difficult to master
- Replayability: Different experience each playthrough
- Elegance: Simple rules that create complex gameplay

Precedents - My thinking was influenced by:
- Chess and its variations (particularly mini-chess variants)
- Roguelike games with their procedural generation
- Puzzle games like Hive and Onitama
- Auto-battlers that use randomized elements

Top 3 Ideas

1. Geo-Battleship: A geography-based battleship game where players must answer trivia questions about countries or regions to make shots. Correct answers allow for precise targeting, while incorrect answers result in random shots. This combines educational content with the classic battleship mechanic.

2. Chess Puzzle Evolution: A 5x5 chess variant where players start with randomly generated pieces. When capturing an opponent's piece, your piece transforms into the captured piece (but remains your color). This creates an ever-evolving strategic puzzle where your available moves constantly change.

3. Recipe Rush: A cooking-themed puzzle game similar to 2048, where players drag and combine ingredients on a grid to create increasingly complex recipes. Different combinations create different dishes, with players racing against time or competing for the most elaborate creations.

Initial Prototype:
I decided to focus on the Chess Puzzle Evolution concept, creating a look/feel prototype using Photoshop to visualize the game board and piece transformations. 

Goals of the Prototype:
- Visualize how the 5x5 board would look compared to standard chess
- Illustrate the piece transformation mechanic after captures
- Explore different visual cues to help players track piece movements and abilities

![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/IterativePrototype1.png)

Prototype Format - I created a series of mockup screens showing:
- The initial board setup with randomly generated pieces
- A visualization of a move sequence
- The transformation effect when a piece captures another
- The end-game state

Fidelity Level:
This was a medium-fidelity visual prototype focusing on the look and feel rather than implementation. I used simplified chess piece designs but paid attention to how color and visual effects could communicate the transformation mechanic clearly to players.

What I Learned - Creating this visual prototype helped me realize:
- The 5x5 board creates a more condensed, faster-paced experience than traditional chess
- The transformation mechanic creates interesting strategic decisions about which pieces to capture
- Clear visual feedback is essential for players to track their pieces' changing abilities
- Random initial setups need some constraints to ensure balanced gameplay

Next Steps - For my next iteration, I plan to:
- Create a physical paper prototype to test the actual gameplay
- Develop rules for the random generation of starting pieces to ensure balanced games
- Test different board sizes (7x7 vs 5x5) to find the optimal complexity
- Explore simplified movement rules for pieces to make the game more accessible to non-chess players
- The look/feel prototype was valuable for visualizing the concept, but now I need to test if the core mechanics create engaging gameplay through a role prototype with actual moves and captures.

# Journal-W07-Iterative Prototyping 2 
## Iterative Prototyping 2: Design Reflection; March 13th, 2025

This week, I focused on developing the core functionality for my chess puzzle game. My primary goal was to establish the fundamental mechanics that would serve as the foundation for the entire experience. I concentrated on implementing several critical chess elements:

Piece Movement: I created scripts to handle the unique movement patterns for each chess piece (pawns, knights, bishops, rooks, queens, and kings). This required translating the traditional chess rules into code while adapting them for my smaller board size.

Capture Mechanics: I implemented the standard capture rules, but with my special transformation twist where capturing pieces evolve into the type they captured while maintaining their original color.

Game State Management: I developed systems to track the start state (with randomized piece placement) and end conditions (checkmate, stalemate, or insufficient material).

Board Structure: Initially, I tested the game on a 3x5 chess board, which provided a compact playing field. However, after several playtests, I found this size too restrictive for interesting strategic play. I've decided to expand to a 4x5 board for my next iteration, which should offer more tactical possibilities while still maintaining a faster pace than traditional chess.

I encountered several technical challenges during implementation, particularly with ensuring all piece movements respected proper chess rules while accounting for the modified board dimensions. The knight's movement pattern, for instance, required special attention to prevent it from moving off the smaller board.

Another significant challenge was balancing the randomized starting positions. Without careful constraints, some initial setups created immediate advantages for one player or limited strategic options.

For my next iteration, I plan to:
- Complete the implementation of the 4x5 board
- Refine the piece transformation mechanic with appropriate visual feedback
- Create a simple AI opponent for single-player testing (however this will be last on my list)

Here's some photos of the functionality:

![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/IterativePrototype2.png)