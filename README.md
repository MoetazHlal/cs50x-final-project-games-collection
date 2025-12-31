# CS50 Final Project - Game Collection

#### Video Demo:  <https://www.youtube.com/watch?v=GBsQd6UnDHM>

## Introduction
This project is the final project for CS50x.
It is a small game collection built using C# and Windows Forms.
The purpose of this project is to demonstrate my understanding of
programming fundamentals, event-driven programming, and basic game development concepts.

The application contains three classic games presented in a simple graphical interface.
Each game is implemented in its own form, and a main menu is used to navigate between them.
The project focuses on clean structure, clear logic, and user interaction rather than advanced graphics.

---

## Project Overview
The project consists of the following games:

1. Guess The Number
2. Tic Tac Toe
3. Rock Paper Scissors

Each game uses its own logic and rules, but all of them share common concepts such as:
event handling, conditional logic, random number generation, and score tracking.

Windows Forms was chosen as the framework because it allows fast development of
event-driven applications and provides an easy way to manage UI elements such as
buttons, labels, and images.

---

## Main Menu (mainForm.cs)
The main menu is the entry point of the application.
It contains buttons that allow the user to choose which game to play.

The main responsibilities of this form are:
- Displaying the main menu interface
- Handling button hover and click effects
- Opening the selected game form
- Hiding itself while another form is active

Each game form receives a reference to the main form so that the user can return
to the menu when closing the game.

---

## Guess The Number (GuessTN.cs)
Guess The Number is a simple guessing game where the player must guess a randomly
generated number.

Key features of this game include:
- Random number generation
- Score tracking
- Difficulty scaling based on the current score
- User feedback such as "High", "Low", or "Correct"

As the player’s score increases, the range of possible numbers becomes larger,
making the game more challenging.
This design choice was made to keep the game engaging instead of static.

The game uses basic conditional statements and event handlers to compare
the user input with the generated number and update the score accordingly.

---

## Tic Tac Toe (TTTForm.cs)
Tic Tac Toe is a two-player game implemented using a 3x3 grid of PictureBox controls.

An enum called `CellState` is used to represent the state of each cell:
- None
- X
- O

Each PictureBox stores its current state in the `Tag` property.
This approach simplifies winner detection and avoids complex data structures.

The game checks all possible winning combinations after each move.
When a player wins, all cells are disabled and a message is displayed.

Using an enum for cell states was a deliberate design choice because it makes
the code more readable, safer, and easier to maintain compared to using integers or strings.

---

## Rock Paper Scissors (RPSForm.cs)
Rock Paper Scissors is a single-player game where the user plays against the computer.

The player selects an option using buttons, and the computer generates a random choice.
The game logic determines whether the result is a win, loss, or tie.

A simple score system is implemented:
- The player gains points for winning
- Loses points after repeated losses
- No score change for ties

This game demonstrates conditional logic and random number generation in a clear
demonstration of basic game mechanics.

---

## Resources and Assets
All images used in the project, such as backgrounds and symbols (X and O),
are stored in the Resources folder and managed through the Properties system.

Using embedded resources ensures that all assets are included with the application
and eliminates dependency on external files.

---

## Design Decisions
Several design decisions were made during development:

- Each game was placed in its own form to maintain separation of concerns.
- Simple logic was preferred over complex patterns to keep the project readable.
- Windows Forms was chosen for simplicity and rapid development.
- Enums were used where possible to represent game states clearly.

The goal was not to create a complex engine, but a clean and understandable project
that demonstrates solid fundamentals.

---

## How to Run
1. Open the solution file in Visual Studio
2. Build the project
3. Run the application
4. Select a game from the main menu

---

## Conclusion
This project represents my final submission for CS50x.
Through this project, I applied fundamental programming concepts such as
event handling, conditional logic, enums, and basic state management.

The project helped reinforce my understanding of C# and event-driven applications,
and it provided hands-on experience in structuring a multi-form application.

Kind regards,
Moetaz Hlal
