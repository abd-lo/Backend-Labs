# Pool Club

A Windows Forms billing/timer app for a pool (billiards) club — tracks table usage time per player and calculates the fee owed based on an hourly rate.

## Features
- Reusable `ucPoolTabel` UserControl representing one pool table, so multiple tables can be placed on the same form.
- On starting a table, a popup dialog (`frmPlayerName`) collects the player's name and the hourly rate.
- Live running timer (`hh:mm:ss`) with Start/Pause control per table.
- On ending a session, automatically calculates total fees: `HourlyRate × ElapsedTime`.
- Raises a custom `GameInfoEvent` (with player name, table name, hourly rate, elapsed time, and total fee) that the main form listens to and displays as a summary.
- Timer/session can be reset for the next player.

## Tech Stack
- C# / .NET Framework 4.7.2, Windows Forms (custom UserControl + custom events)

## How to Run
1. Open `Pool Club.sln` in Visual Studio.
2. Build and run (F5).
3. Click **Start** on a table, enter the player name and hourly rate, then **End** to see the total fee.

## Project Structure
- `ucPoolTabel.cs` — reusable table control: timer, fee calculation, custom event.
- `frmPlayerName.cs` — dialog for entering player name and hourly rate.
- `Form1.cs` — hosts the table control(s) and handles the end-of-game summary.
