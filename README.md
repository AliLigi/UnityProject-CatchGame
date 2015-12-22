# UnityProject-CatchGame
Alina Danci 

##Functionality 
This game was designed in Unity.This game comes with a splashscreen and a START button.When the start button is pressed 
the game begins.It is a basic game where is a hat that catches rabbits, this game includes timer to show how much time is 
left for the game. It also includes a score. Every time a rabbit is cought in the hat the score increases. When the game is over 
you get a GAME OVER! sign and a RESTART button. I only made a basic game on unity and I spent most of the time trying to get the Mobile services working since it was the most important part of the project. I have only recently found out that you have uploaded a working version of it on Visual studio.

##Functionality I didn't have time to add
*What i could improve on.The game only spawns the rabits which fall. I also had bombs i wanted to add.
GameObject ball = balls[Random.Range (0, balls.Lenght)];- This is the way it sould work. The bomb and the rabbit will be falling
randomly from the top. Then when a bomb will hit the hat it would take away from the score. That would of made the game more fun.

##Mobile services
I created a new mobile service on azure and i reated a leaderboard. In this leaderboard i added columns. And when the game connects to
the service it would bring in a name of the user and the score. The next step was to add this into unity. Created a new script which held
:public class TodoScript
{
public int? Id {get; set;}
[JasonProperty(PropertyName = “complete”)]
public bool Complete {get; set;}
public override string ToString()
{ 
	Return Id+ “,” +Text +”,” + Complete;
}
}.
Then create a new script LEADERBORED.
Using UnityEngine;
Using System.Collections.Generic;
Uning Newtonsoft.Json;
Using Syste.Collections.Generic;
Using System;
Public class LeaderBoard
{
Public string Id {get; set;}
[JsonProperty(PropertyName = “username”)]
Public string UserName {get; set;}
JsonProperty(PropertyName = “score”)]
Public string Score {get; set;}
Public override string ToString()
{
	Return UserName + “”+Score;
}



