# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, bug in C#: accessing uninitialized properties.  Uninitialized properties will have default values (0 for integers, null for objects, etc.), but relying on these defaults without explicit checks can lead to unexpected results in calculations and logic.

The `bug.cs` file shows an example of this issue.  The `bugSolution.cs` file demonstrates how to avoid the problem using null-conditional operators or explicit initialization.