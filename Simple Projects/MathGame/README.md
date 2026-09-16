# MathGame

A Windows Forms arithmetic quiz game that generates random math questions based on the player's chosen difficulty, operator, question count, and time limit per question.

## Features
- Choose difficulty level: Easy, Medium, Hard, or Mix (controls the number range used).
- Choose operator: Addition, Subtraction, Multiplication, Division, or Mix (random operator each round).
- Configurable number of questions and time per question.
- Input validation on all setup controls (via `ErrorProvider`) before the game can start.
- Smart question generation: avoids invalid subtraction (negative results) and guarantees clean division (no remainders).
- Live score tracking during the game.
- End-of-game results screen showing correct/incorrect answers and percentage score.

## Tech Stack
- C# / .NET Framework 4.7.2, Windows Forms

## How to Run
1. Open `MathGame.sln` in Visual Studio.
2. Build and run (F5).
3. Select a difficulty, operator, number of questions, and time per question, then click **Start Game**.

## Project Structure
- `Form1.cs` — game setup, question generation, answer validation, scoring, and results screen.
- `frmTest.cs` — auxiliary form.
