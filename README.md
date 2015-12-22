# UnityProject-CatchGame
Alina Danci 
##Problem With Developer Account!
-I Could not access my developer account and other people I asked had problems with putting their projects on the App store too. So I could not get my project on the app store! Or get others to put it.If I can access the account I will put it on the store then.

##Functionality 
This game was designed in Unity.This game comes with a splashscreen and a START button.When the start button is pressed 
the game begins.It is a basic game where is a hat that catches rabbits, this game includes timer to show how much time is 
left for the game. It also includes a score. Every time a rabbit is cought in the hat the score increases. When the game is over 
you get a GAME OVER! sign and a RESTART button. I only made a basic game on unity and I spent most of the time trying to get the Mobile services working since it was the most important part of the project. I have only recently found out that you have uploaded a working version of it on Visual studio.

##Functionality I didn't have time to add
Also this was my first time using unity and it took a long time to get used to the different technique used.
*What i could improve on.The game only spawns the rabits which fall. I also had bombs I wanted to add.
GameObject ball = balls[Random.Range (0, balls.Lenght)];- This is the way it sould work. The bomb and the rabbit will be falling
randomly from the top. Then when a bomb will hit the hat it would take away from the score. That would of made the game more fun.

##Mobile services
I spent alot of time trying to get the mobile service working and to familiarise myself with azure.And Azure in Unity..had alot of probles with it so decided to take it out.I followed tutorials and nothingworked on my game. I created a new mobile service on azure and i reated a leaderboard. In this leaderboard i added columns. And when the game connects to the service it would bring in a name of the user and the score. The next step was to add this into unity. Created a new script which held
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



