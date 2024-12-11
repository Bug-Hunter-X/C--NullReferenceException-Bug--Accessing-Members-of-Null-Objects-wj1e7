# C# NullReferenceException Bug

This repository demonstrates a common C# bug: the `NullReferenceException`.  The bug occurs when attempting to access a member of an object that has not been initialized, resulting in a runtime error.

The `Bug.cs` file contains the problematic code. The `BugSolution.cs` file provides a corrected version that avoids the exception using null checks.

## Reproduction Steps

1. Clone this repository.
2. Open `Bug.cs` in a C# IDE.
3. Run the code. You should encounter a `NullReferenceException`.
4. Open `BugSolution.cs` and run the corrected code. It should execute without error.

## How to Fix

Always check if an object is null before accessing its members using the null-conditional operator (`?.`) or by explicitly checking for null using `if` statements.