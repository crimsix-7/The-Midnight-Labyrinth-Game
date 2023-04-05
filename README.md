# The-Midnight-Labyrinth-Game
This Unity maze game has 5 levels, each with unique design and difficulty that progressively builds upon acquired skills. Players navigate a 2D maze while being chased by an AI bot with limited vision due to a fog of war effect. Achievements based on time and damage were added, targeting puzzle and adventure game enthusiasts.

# Clone and Build Unity Project

This is a step-by-step guide on how to clone a Unity project from GitHub to your local computer and build it to generate an executable.
Prerequisites

    Unity Hub installed on your computer.
    Unity version used to create the project installed on your computer.
    Git/Github Desktop installed on your computer

    Here is an additional video explaining the process of accessing the files in git
    https://youtu.be/pNUdu-6ZNBg  

    

# Clone the Unity Project using Git

    Open a web browser and navigate to the GitHub repository containing the Unity project you want to clone.
    Click on the "Code" button and copy the URL of the repository.
    Open Git Bash or your preferred Git client and navigate to the directory where you want to clone the project.
    Run the command git clone <repository-url> and wait for the project to finish cloning.

# Open the Project in Unity

    Open Unity Hub and click on the "Projects" tab.
    Click on the "Add" button and navigate to the directory where you cloned the Unity project.
    Select the project folder and click on the "Open" button.
    Wait for Unity to finish importing the project.

# Build the Project

    Click on the "File" menu and select "Build Settings".
    In the "Build Settings" window, select the platform you want to build the executable for.
    Click on the "Add Open Scenes" button to add all scenes in the project to the build.
    For Our purposes, make sure Scene0 has index 0 and SampleScene has index 1
    Click on the "Build" button and select the directory where you want to save the executable.
    Wait for Unity to finish building the project.

# Run the Executable

    Navigate to the directory where you saved the executable.
    Double-click on the executable ending with .exe or Apple File System to run it.
    Test the executable to ensure it runs correctly.
# What to Expect (Interim Demo).
    
    
    Sound Effects: Players can expect sound effects when they die, which will be an electronic buzz.

    Special Items: Players will have access to a special item (Potion) that will boost their speed and another item (Blue line) that will remove the speed boost.           Implemeting the special items usecase.

    AI Bot: The game will feature an AI bot that will chase the player, using a pathfinding algorithm. This usecase is implemented such that AI bot avoids obstacles to     reach the Player within the shortest distance possible.

    Player Maneuverability: Players will be able to navigate through a maze, using various maneuvers to evade the AI bot and reach their goals. 
     The game's mechanics will allow players to avoid the AI bot QUite smoothly.
    
# What to Expect (Final Demo).
    All the usecase proposed in the the final demo in the project proposal have been applied.
    
    Achievement indicator: Radar indication showcasing presence of enemy.

    All 5 levels built.

    Special Items and traps added.

    Design principles implemented.


# Accessing Source Code
    To access the source code go to the folder "The Midnight Labyrinth" => "Assets" => "SRC"

Congratulations, you are ready to play THE MIDNIGHT LABYRINTH
