## Word Game Steps

In this game you are given a beginWord, an endWord and a Dictionary. Starting from the beginWord you must travel trough the Dictionary until you arrive to the endWord; you must do this by changing one letter at a time from the begin word, after changing the letter you acumulate 1 point if the resulting word exists in the dictionary or if it is the endWord. When you reach the endWord the game is over and you should return the amount of points you collected. To win you must return the most amount of points possible in a given set.

## **Example**

>**beginWord** -> "hit"
>
>**endWord** -> "cog"
>
>**Dictionary** -> ["hot", "hog", "dog", "fog", "cog", "you"]

Return the most amount of steps taken from beginWord to endWord by changing one character at a time. If endWord cannot
be reached return 0.

>**Steps** hit > hot > hog > dog > fog > cog
>
>**Output:** 5