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
### *About Blazor and asp.net core* : 
Since Blazor is relatively new compared to MVC and Razor page, it has some really handy<br/>
features for modern web development. What I really like about blazor is first the routing. It is very clear and straightforward. <br /> 
I also like how you can use razor components where you can inject classes at the top of the pape to simplify coding process. <br />
Having frontend code and c# code on the same page makes it easier for me to debug ( Of course you can put the c# code in another file to make it
look like the razor page infrastructure). MVC and razor page make you understand better about how asp.net core works, but when it comes to overall development
experience I like Blazor the best. Combining it with Azure AD B2C makes the whole development process faster and easier. </br >

### *About database*  : 
It is my first time using NoSQL database. I really like it even though I didn't take advantage of EF core's </br >
features like scaffolding and  migration. It feels more like using Dapper with SQL to me and I like Dapper a lot. The overall use </br >
of mongoDB is easier than using SQL. You dont have to worry about duplicated data as long as it's not too absurd. I think I'll use MongoDB more
from now on if I build something from scratch and not want to worry too much of it being rational or not.<br/>

## *About Auth* :
First time using a third-party authentication system. It is easier to configure than using the built-in authentication system </br >
(Even though the set up part on Azure is kinda messy). The coding part is especially easier than implementing JWT from scratch by myself. </br >
The only thing I think users wouldn't like about it is the system UI. It looks very Microsoft and not custom enough even though you can change </br >
the icon and background picture. But overall it's really handy if you build a project from scratch and want something easier and faster. </br >You dont have to worry too much about authorization and security as it is being handled by Microsoft.
<br>
<br>


## Epilogue
Learned a lot from building this website. Struggled for a while to deploy it online but eventually figured it out after three days. </br>
Compared to Razor Page and MVC I think I like Blazor the best because it's really fast and straightforward. </br> 
I also like Azure AD B2C, the downside is that it's not free after a year and it handles 50000 monthly with the free tier azure (more than enough </br>
for my website :rofl:). MongoDB is nice too as there is no more DBContext stuff all you need is a dependency injection using a mongoDB client.</br >
I did implement responsive design in this website but somehow the virtualize box is not working properly. Have to fix that later so for now just </br >
use the desktop version lol





<br/><a href="https://sf6wishlist.azurewebsites.net/" target="_blank">Go to the website</a> <br/>
*(Please open the website on your computer and give it 15 to 30 seconds to load the website and database as it is being hosted on <br>
free tier Azure and Atlas. Please sign up to leave your ideas about what you want in Street Fighter VI if you like the series. :blush: <br> 
The mobile version is still in development.)*
<br>
<br>

## Credit
Big shout out to **IAmTimCorey** for sharing his knowledge,  <a href= "https://www.youtube.com/user/IAmTimCorey">check out his Youtube channel</a>.

## Things I'm still working on this project:
-Refactoring
  
Things I'm planning to add on this project:
-Maybe add another data access for practicing purpose, for example, MongoDB.
  
  
  
Things I like about this project:
  
  
Things I dont really like about this project:
  

# Street Fighter VI Wishlist Website
A wishlist website for the upcoming (2022?:expressionless:) video game Street Fighter VI.


