# TournamentTracker
Your daily tool of hosting tournaments :joy:
  


<br>
<br>

<img width="602" alt="Tournament_ViewerUI" src="https://user-images.githubusercontent.com/28534915/172692479-ff584644-4366-423d-8d1e-d835cc628461.PNG">


<br>
<br>

<img width="661" alt="Tournament_CreateTournamentUI" src="https://user-images.githubusercontent.com/28534915/172692528-efb3c58e-ed05-42ac-b1fe-a4154a0bd88b.PNG">

<br>
<br>

<img width="732" alt="Tournament_CreateTeamAndMemberUI" src="https://user-images.githubusercontent.com/28534915/172692539-780fe41e-a1ce-44ad-a7de-9e6ea59cfd40.PNG">

<br>
<br>
<img width="434" alt="Tournament_CreatePrizeUI" src="https://user-images.githubusercontent.com/28534915/172692554-75c10ab1-7672-409d-b3c6-8470a6856d89.PNG">
<br>
<br>
<img width="623" alt="Tournament_Viewer" src="https://user-images.githubusercontent.com/28534915/172692571-6f29b4ad-6279-47f5-8b74-16b5131c6ff0.PNG">


<br>
<br>


## About the application
Tools I used to build the app: </br>
*Framework* : .NetFramework 4.7.2. </br>
*Frontend* : Winform.<br/>
*Database* : Microsoft SQL Server, local textfiles. <br/>
*Other tools: Dapper, etc.*



<br>
<br>

## What I learned 
### *About .NetFramework* : 
First time using Microsoft .Net and it was pretty fun. It feels very different from the tools I have used </br>
before, like Unity. At that time I was building this project following a tutorial online, I wasn't very familiar</br>
with some concepts in .Net , like dependency injection and etc. So you will see me using a public static variable </br>
plus a enum and switch to swap  between the two databases. With the fundametals of c#, it is actually not that hard</br>
to get started with .Net. The file structure is clear and not overwhelming. It is because of this project that I really</br>
started to get interested in .Net development and decided to learn more about it. 


### *About database and ORM*  : 

First time using SQL with an ORM. Although I learned SQL long time ago back in school, I didn't actually build a project with it.  </br>
So this is very first time using database plus a ORM. Speaking of Dapper, I knew there is this other ORM called Ef core and it was pretty </br>
popular, but I still used ORM because the tutorial did so :rofl:. So now after I learned ef core too, I'm thinking maybe I should add another</br>
implementation of the dataaccess with EF core. There is also a second database which is a local textfile database.

### *About Winform* :

I had used Winform once before I started this project. The impression of Winform to me is simplicity. You just drag</br> 
and drop every thing and it is way easier than the web frontend development. Even though Winform is outdated nowadays</br>, it's still
good if you want something fast and simple for your frontend and focusing on your backend. The down side is that it is </br>not very pretty.

### *About algorithm to add bots to fill up the round*

One thing that got me interested in building this project was this small part of algorithm of how to fill up the</br> 
tournament if there was not enough teams to compete. For me algorithm is always the tricky, hard yet fun part of</br> 
programming. The logic of populating rounds is very interesting in tournament. Let's say you dont have enough </br>
teams, the idea that comes to your mind natually is to add bots to fill up the teams so the number of teams is</br>
to the power of 2. For example, you have 7 teams in the tournament. What is gonna happen is that one team doesn't </br>
have to compete in the first round. This is where we add the bot so what whatever team that plays the bot means the </br>
team doesn't have to compete in the first round. In this way, you don't have to worry about the round 2 above</br>
because it is always gonna be to the powerful of 2 after round 1. You need to populate the number of rounds of the </br>
tournament, the number of bots you need for the first round, a method to generate the first round, another </br>
method to generate round 2 and above. Of course, you have to randomize the entered teams before putting them </br>
in the first round, I did that using model.EnteredTeams.OrderBy(a => rng.Next()).ToList();

###



<br>
<br>


## Epilogue
This is my very first project after taking a break from game development. The whole developing experience</br>
was not very smooth at the begining because of the long break. I had to research a lot of things for .Net </br>
which I didn't have much experience with as well as the tools and knowledge I used before. After working on</br>
it for a few days, it got better and better and I began to really get interested in .Net development. I watched </br>
quite a lot of videos and followed a few youtube channels taking about .Net development. I also started to read</br>
Microsoft documentaries which I found is very helpful. It is this project that really got me started my journey </br>
in the .Net world until today and I'm still learning more about .Net, mainly asp.net for web dev and other tools too. 



## Credit
Big shout out to **IAmTimCorey** for sharing his knowledge,  <a href= "https://www.youtube.com/user/IAmTimCorey">check out his Youtube channel</a>.






