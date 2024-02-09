# TDD workshop exercise - Bowling score

## Scoring Rules
- There are 10 turns called frames. Each frame begins with 10 pins, and the bowler gets up to two tries to knock them all over.
- One point is scored for each pin that is knocked over, and when fewer than all ten pins are knocked down in two rolls in a frame (an open frame), the frame is scored with the total number of pins knocked down. 
- Strike: When all ten pins are knocked down on the first roll, the frame receives ten pins plus the next two rolls (not frames!). A strike in the tenth (final) frame receives two extra rolls as a bonus.
- Spare: When the second roll of a frame knocks down all pins, the frame receives ten pins plus the next roll. A spare in the tenth (final) frame receives a third roll as a bonus.
- Bonus pins: No additional rolls are received for a strike/spare in the bonus balls. 

## Requirements
- Given the number of pins you knock down each time you roll, calculate the total score so far.

### Some examples
Assuming the rolls are in a ordered sequence:

[5] → 5

[5, 4] → 9

[5, 5] → 10 (spare, we have to add the next roll when it happens)

[5, 5, 3] → 16 (10+3 for the first frame plus the 3 of the second frame)

[0, 10, 3, 5] → 21 (10+3 for the first frame plus the 3 and 5 of the second frame)

[10] → 10 (strike, we have to add the two next rolls when they happen)

[10, 5] → 20 (10+5 for the first frame plus 5 for the second frame, one more roll to be added)

[10, 5, 5] → 30 (10+5+5 for the first frame plus 5+5 for the second frame)

[10, 10, 10, 10, 10,
 10, 10, 10, 10, 10,
 10, 10] → 300 a perfect game: 10 x 30 (each frame scores 10+10+10 points)

A random complete game: 
[10, 7, 3, 9, 0, 10, 0, 8, 8, 2, 0, 6, 10, 10, 10, 8, 1] → 167 


