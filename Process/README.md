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

- Piece Movement: I created scripts to handle the unique movement patterns for each chess piece (pawns, knights, bishops, rooks, queens, and kings). This required translating the traditional chess rules into code while adapting them for my smaller board size.

- Capture Mechanics: I implemented the standard capture rules, but with my special transformation twist where capturing pieces evolve into the type they captured while maintaining their original color.

- Game State Management: I developed systems to track the start state (with randomized piece placement) and end conditions (checkmate, stalemate, or insufficient material).

- Board Structure: Initially, I tested the game on a 3x5 chess board, which provided a compact playing field. However, after several playtests, I found this size too restrictive for interesting strategic play. I've decided to expand to a 4x5 board for my next iteration, which should offer more tactical possibilities while still maintaining a faster pace than traditional chess.

I encountered several technical challenges during implementation, particularly with ensuring all piece movements respected proper chess rules while accounting for the modified board dimensions. The knight's movement pattern, for instance, required special attention to prevent it from moving off the smaller board.

Another significant challenge was balancing the randomized starting positions. Without careful constraints, some initial setups created immediate advantages for one player or limited strategic options.

For my next iteration, I plan to:
- Complete the implementation of the 4x5 board
- Refine the piece transformation mechanic with appropriate visual feedback
- Create a simple AI opponent for single-player testing (however this will be last on my list)

Here's some photos of the functionality:

![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/IterativePrototype2.png)

# Journal-W08-Iterative Prototyping 3 
## Iterative Prototyping 3: Design Reflection; March 20th, 2025

This week, our team continued development on "Rock, Paper, Chess," focusing on testing different board configurations to determine the optimal setup before diving into implementation. Using an online chess simulator, we experimented with various board sizes and piece distributions to find the right balance for our unique RPS capture mechanic.

Our design goals were clear: create a chess variant where traditional captures trigger Rock-Paper-Scissors challenges, with winners either completing the capture (if the attacker wins) or reversing positions (if the defender wins). We needed a board that would generate frequent enough captures to make the RPS mechanic relevant while still maintaining enough strategic depth.

- Testing Different Board Configurations

- 3×3 Board Configuration

![3x3 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/3x3/3v3v1.gif)
![3x3 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/3x3/3v3v2.gif)
![3x3 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/3x3/3v3v3.gif)

We initially tested a minimalist 3×3 board with just 1 King, 1 Queen, and 1 Pawn per side. While extremely accessible, this configuration proved too simplistic. Games ended too quickly, often before the RPS mechanic could create any meaningful impact on gameplay. The limited piece selection created few decision points and little strategic depth.

- 3×4 Board Configuration

![3x4 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/3x4/3x4v1.gif)


Expanding to a 3×4 board with 1 King, 1 Queen, 1 Knight, 1 Rook, and 2 Pawns per side offered more tactical options but still suffered from fundamental issues. Kings were too vulnerable, and while captures happened frequently (good for our RPS mechanic), the game state changed so dramatically with each capture that strategic planning became difficult. Sometimes the games also ended in weird stalemate positiosn according to regular chess rules

- 4×4 Board Configuration

![4x4 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/4x4/4x4v1.gif)

The 4×4 board with 1 King, 1 Queen, 1 Bishop, 1 Knight, 1 Rook, and 3 Pawns per side showed more promise. This setup provided better spacing and allowed for some interesting tactical combinations. However, powerful pieces like the Queen and Rook still felt overly constrained. Also it was really awkward because the kings would start in check the way I set up the board, so we would really have to break some fundamental chess rules

- 5×4 Board Configuration

![5x4 Chess Board Configuration](https://github.com/AlexTerziyski/CART315/blob/main/Process/ChessMoves/5x4/5x4v1.gif)

After multiple tests, our team agreed that the 5×4 board offered the optimal balance for "Rock, Paper, Chess." Using 1 King, 1 Queen, 1 Bishop, 1 Knight, 2 Rooks, and 2 Pawns per side created a game where:
Captures occurred at a good frequency to trigger our RPS mechanic
The board provided enough space for meaningful pawn advancement
Players could develop multi-move strategies
The RPS mechanic had significant impact.
Games lasted approximately 10-15 minutes (although we might add a timer), hitting our target for casual play. Also as stalemates sometimes occured, I think this helped us come to the conclusion that to decided a stalemate game there will be one final Rock, Paper Scissors game.

- 5×5 Board Configuration
5×5 Board Configuration

We also tested a larger 5×5 configuration with 1 King, 1 Queen, 1 Bishop, 1 Knight, 1 Rook, and 5 Pawns per side. After researching existing mini-chess variants (including Gardner MiniChess as shown in videos like https://youtu.be/_vkgg-bJ9zc), we found that 5×5 chess can actually become quite advanced and strategically complex. Games on this board size tended to be more positional and multifaceted, with longer decision trees that pushed beyond what we're trying to achieve for this class project. While interesting from a pure chess perspective, this configuration reduced the frequency of captures, making our RPS mechanic less central to the gameplay. Additionally, games lasted significantly longer than our target 10-15 minute play session. Given our goal of creating an accessible, RPS-focused chess variant rather than a deep strategic challenge, we determined that the 5×5 board was less ideal for our specific concept.

- Implementation Progress

With our board configuration decided, we began implementing the basic chess movement rules for our chosen 4×5 board size. We've created the foundation for:
Proper piece movement and highlighting of valid moves
Basic capture detection that will trigger our RPS challenges
Check and checkmate detection (which will bypass the RPS system)

The most interesting design challenge has been determining how to handle consecutive RPS wins by the defender. After testing various options, we decided that consecutive defensive wins will continue to give the defender additional turns, creating a potential for dramatic gameplay swings that align with our "unfairly fair" design philosophy.

Next Steps

For our next iteration, we plan to:
Complete the RPS challenge UI that appears when captures are attempted
Implement the turn-switching logic based on RPS outcomes
Add visual and audio feedback to make the consequences of each RPS result clear
Begin playtesting with users outside our team to gauge initial reactions

# Journal-W09-Iterative Prototyping 4 
## Iterative Prototyping 4: Design Reflection; March 27th, 2025

# Journal-W10-Iterative Prototyping 5 
## Iterative Prototyping 4: Design Reflection; April 3rd, 2025

This week I've been working extensively with Godot to implement our "Rock, Paper, Chess" concept. I've made decent progress in terms of setting up the chess board and calculating the valid moves for each piece. The board representation is functioning properly, and I've successfully implemented the logic to highlight valid moves when a piece is selected.

However, I've encountered some challenges when trying to implement the actual movement mechanics, captures, and checking functionality. My limited experience with Godot has made these aspects more time-consuming than anticipated, particularly when handling the state changes after moves and ensuring all chess rules are properly enforced. The event system for piece interaction has been especially tricky to get right.

Despite these challenges, I remain confident that I can complete these core mechanics next week. My plan is to focus on finalizing the movement and capture systems, along with implementing proper check detection. Once these foundational chess elements are working correctly, Daniel and I will combine the chess component with the Rock-Paper-Scissors minigame we've been developing separately. This integration will be the final major step in bringing our hybrid game concept to life.

I'm looking forward to seeing how the two gameplay systems interact once fully combined, as this will be the true test of our design hypothesis about making chess more accessible through the RPS mechanic.

![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/IterativePrototype5.gif)
![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/IterativePrototype5.png)

# Journal-W11-Final Iterative Prototype
## Final Iterative Prototype: Design Reflection; April 10th, 2025
This past week marked a significant milestone in our "Rock, Paper, Chess" project as I finally implemented a functioning chess board with moving pieces and an AI opponent that automatically makes moves. The core system now consists of four main scripts in Godot:

- board.gd: Handles the visual representation of the board, piece placement, and move validation
- game.gd: Controls game state, player turns, AI moves, and win conditions
- globals.gd: Defines constants, enumerations, and piece configurations
- piece.gd: Manages individual piece behavior, movement patterns, and capture mechanics

These scripts work together with two main scenes: game.tscn (the main game scene) and Piece.tscn (the template for all chess pieces).

Throughout this project, I significantly underestimated the technical complexity involved, which limited my progress and led to moments of intense frustration having spent many hours stuck. Trying to combine the theoretical knowledge from the course with practical tutorials proved challenging 
(CREDIT - such as these ones: https://www.youtube.com/watch?v=5XQUnHYrUvs&t=54s, https://youtu.be/TBs1DX2xeFY?list=PLd_56bdSJ-tS4-q1gczTdKJhqMep3Ij_w&t=630), especially when adapting existing chess code to accommodate our RPS mechanic. Daniel and I haven't yet fully integrated the Rock-Paper-Scissors component with the chess gameplay, but we've established a solid foundation and are very close to completion.

Despite not reaching our final integration goal within the course timeframe, this project has been invaluable from a design prototyping perspective. It forced us to think carefully about how two distinct game mechanics could interact meaningfully, and the iterative process helped us refine our concept significantly.

What we've achieved:
A fully functioning chess board with proper piece movement logic
Drag-and-drop interface for moving pieces
Legal move validation (including check prevention)
A simple AI opponent that can make valid random moves
Pawn promotion mechanics
Win condition detection

What we're still working on:
Teleportation of chess pieces when capturing during turn sequences (the core RPS integration)
Implementing special moves like castling and en passant
Improving the AI's decision-making

Future plans:
We're committed to completing this project beyond the class requirements. Our next steps include fully integrating Daniel's RPS component and finalizing the hybrid gameplay. We believe this concept has potential as a unique chess variant that could appeal to both chess enthusiasts and casual players, so we plan to continue refining it for potential release.

The code structure we've developed is modular enough to accommodate our RPS mechanics once fully implemented. For example, when a piece attempts a capture in game.gd, we'll trigger the RPS minigame, and the outcome will determine whether the capture succeeds or results in a position swap. This design allows us to maintain chess's strategic depth while adding an element of chance that makes the game more accessible to players of varying skill levels.

This project has taught me valuable lessons about scope management, the importance of prototyping core mechanics early, and the challenges of blending different game systems. While ambitious, I believe our concept remains sound, and I'm excited to see it through to completion.

Image of gameplay (Black is AI):
![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/FinalIterativePrototype.gif)

Here are also some of the Game states and Labels that are used to transfer between scenes (x Player Won!, Play again...):
![alt text](https://github.com/AlexTerziyski/CART315/blob/main/Process/Images/GameStatesandLabels.png)
