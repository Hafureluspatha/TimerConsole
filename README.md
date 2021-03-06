# Console Timer
This console program has four timers.

```3 6 9 =``` clear the timers,  
```2 5 8 -``` add a shift (shifts are stackable)  
```1 4 7 0``` start or stop the corresponding timer  

Timers are implemented with System.Diagnostics.Stopwatch, so the timers will continue counting even when computer is in sleep mode.

Main things I've done in this project:
1. Deepened my understanding of time tracking in C#. It turns out usual ticking mechanisms are not precise, so I had to use the _Stopwatch_ class.
2. Understood how to work with several threads, as I used it to separate the display and the timers.

With regards to refactoring and code conventions, the program does what it was intended to do, therefore no further refactoring was necessary.
