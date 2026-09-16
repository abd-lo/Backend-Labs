# PizzaProject

A Windows Forms pizza order calculator that lets a customer build a custom pizza and see the live total price update as options are selected.

## Features
- Choose pizza size (Small / Medium / Large), each with its own price.
- Choose crust type (Thin / Thick).
- Select multiple toppings (extra cheese, green peppers, mushrooms, olives, onion, tomatoes), each adding to the total.
- Choose dine-in or takeout, each with a different surcharge.
- Real-time price calculation and order summary as selections change — no "calculate" button needed.

## Tech Stack
- C# / .NET Framework 4.7.2, Windows Forms

## How to Run
1. Open `PizzaProject.csproj` (or its solution) in Visual Studio.
2. Build and run (F5).
3. Customize the pizza and watch the price update live.

## Project Structure
- `Form1.cs` — pricing logic (size, crust, toppings, dine-in/takeout) and live UI updates.
