# HangmanGame

This project is for learning purposes only, im planing on coming back from time to time to create more versions, to test my capabilities with diffrent approaches and solutions.
---
## Versions
<details>
  <summary><b>v1.x:</b> Simple C# console application.</summary>
  <details>
    
  <summary><b>v1.0:</b> Technical Overview</summary>
      
### How it works & Key Concepts

This initial version focuses on string manipulation, input validation, and managing game state transitions in a console interface.

  * **String Manipulation & Rebuilding:** Used `new string('_', length)` to generate hidden word masks, alongside `.Remove()` and `.Insert()` to update correctly guessed letters in real time.
  * **Input Validation & LINQ:** Created a `char[]` array of forbidden characters and used `.Any()` with `.Contains()` to reject special characters, numbers, and empty inputs.
  * **Looping & Game State:** Implemented a `while` loop that continuously checks remaining attempts (`attemptsLeft > 0`) and unsolved letters (`hiddenWord.Contains('_')`).
  * **Pattern Matching:** Used a `switch` expression in a custom helper method (`Galgen`) to dynamically render ASCII art based on remaining attempts.
  * **Console UX & Key Handling:** Managed screen resets using `Console.Clear()`, included ANSI escape sequences for bold text, and used `Console.ReadKey()` with `ConsoleKey.Backspace` for program exit logic.
    
  </details>
    
  <details>
  <summary><b>v1.1:</b></summary>
  </details>
</details>

<b>v2.x:</b> Future revision
