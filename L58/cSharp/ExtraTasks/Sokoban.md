# Sokoban

Sokoban is a small game where the player has to move on a map and push boxes to their destination location.

> This task equals a full exam.
> __Reading and understanding the task sheet isn't part of the exam time__.
> coding time is about 45 to 135 min.
>
> 1. Read through the games rules
> 2. think about how you would code this
> 3. maybe make a rough plan on paper *"but dont begin coding on paper"*
> 4. start the timer and begin coding
>
> I think this mark destribution should be roughly the same as in a real exam
> 
> marks:
> - < 45min -> 10X Developer
> - \> 45min -> 0.0
> - 60min -> 1.0
> - 75min -> 2.0
> - 90min -> 3.0
> - 105min -> 4.0
> - 120min -> 5.0
> - 135min -> 6.0
>
> Tipp mark deduction:
> 0.25 marks per tipp
>
> example mark:
> - time = 75min
> - tipps = 2
> - mark = 2.5

Use this as your game map:
```
#######
# .   #
#     #
#  @  #
#   $ #
#     #
#######
```
```cs
//cs template
char[][] map = new char[][]{
                new char[]{'#','#','#','#','#','#','#'},
                new char[]{'#',' ','.',' ',' ',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#',' ',' ','@',' ',' ','#'},
                new char[]{'#',' ',' ',' ','$',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#','#','#','#','#','#','#'}
            };
```
Perform the following steps, using the above map, to test your game:
```
down
down
right
up
up
up
up
right
right
up
up
left
left
Now you should have won the game.
```


## Game Rules
```
Symbols
'#' == walls
' ' == empty space
'.' == destination location
'@' == player
'$' == box
'+' == player on destination location
'*' == box on destination location

Example map
#######
# .   #
#     #
# @   #
#   $ #
#     #
#######
Player is on destination field
#######
# +   #
#     #
#     #
#   $ #
#     #
#######
Player has won
#######
# *   #
# @   #
#     #
#     #
#     #
#######
```
Rules
1. The player can move up/down/left/right
2. The player can move to any empty space
3. The player can not move to or push walls
4. The player can move to the location of a box by pushing it away (1 field in the direction he moves in)
5. 4 does not apply if behind the box is a wall or a other box
6. The player can move to a destination location (symbol changes to '+' to indicate player on destionation location)
7. The player can push a box on a destionation location (symbol changes to '*' to indicate box on destination location)
8. If all boxes are on destination locations the player wins the game
```
Example moves
player pushes box on destination field
#######
# .   #
# $   #
# @   #
#     #
#     #
#######
what move do you want to do?
up/down/left/right:
up
#######
# *   #
# @   #
#     #
#     #
#     #
#######
Winner!

player pushes box on empty space
#######
# .   #
#     #
# $   #
# @   #
#     #
#######
what move do you want to do?
up/down/left/right:
up
#######
# .   #
# $   #
# @   #
#     #
#     #
#######

player pushes box on wall
#######
# .   #
#     #
#     #
#   @$#
#     #
#######
what move do you want to do?
up/down/left/right:
right
#######
# .   #
#     #
#     #
#   @$#
#     #
#######

player pushes box on box
#######
# .   #
# $   #
# $   #
# @   #
#   . #
#######
what move do you want to do?
up/down/left/right:
up
#######
# .   #
# $   #
# $   #
# @   #
#   . #
#######

player pushes box on empty space from destination location
#######
#     #
#     #
# $   #
# +   #
#     #
#######
what move do you want to do?
up/down/left/right:
up
#######
#     #
# $   #
# @   #
# .   #
#     #
#######
```
## TIPPS
```
#############
ONLY READ IF YOU ARE SURE YOU NEED A TIPP!
#############
- FREE TIPP -> use `continue` to jump to the beginning of a loop(while/do-while/fori/forEach)
- 1 Tipp -> looping the game
- 2 Tipp -> checking the diffrent moves
- 3 Tipp -> assinging the chosen direction
- 4 Tipp -> using the player position
- 5 Tipp -> applying the diffrent directions
#
#
#
#
#
### 1 Tipp
use do `{}while(true)` and `return` to loop and exit the game
###
#
#
#
#
#
### 2 Tipp
use a switch to check the different moving directions
###
#
#
#
#
#
### 3 TIPP
assign two variables: xDifference and yDifference
they will hold either 0, -1(up/left) or 1(down/right) depending in wich direction the player wants to move
###
#
#
#
#
#
### 4 Tipp
use a double for loop (loop in loop) to search for your player and assign two variables xPlayerPos and yPlayerPos those values.
###
#
#
#
#
#
### 5 TIPP
use a switch to check the space your player wants to move to
###
```