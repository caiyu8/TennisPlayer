 ## Tennis player API

### Description
An Asp.Net Core Web API project containing following end points:

API| Description|Request Body|Response Body
----------------------------| -----|------|-------|
GET /api/players|Get all players ordered by Id|None|Array of players
GET /api/players/{id}|Get a player by Id|None|A player or 404 if Id doesn't exists |
DELETE /api/players/{id}|Delete a player by Id|None|A player or 404 if Id doesn't exists |

### How to run and test
**0. Install Visual Studio 2019 and .Net Core 2.2 SDK**

**1. Run the unit tests** </br>
Under the test project folder, type the command *dotnet test <test_project_name>* to run the unit tests

![unit test by CLi](unittest1.png)
</br>
We can also use **Test Explorer** of Visual Studio to run the test: 
</br>
![unit test by CLi](unittest2.png)

**2. Run the API project**</br>
Under the API project folder, type the command *dotnet run* to start the API locally
![Run APi](StartApi.PNG)

**3. Test the API locally**</br>
(1) To test the two GET end points, we can simply type the end point url in a brower:

**Get all players**</br>
![GetAllPlayers](get.png)

**Get a player by Id**</br>
![Get A Players](get2.png)

**Get a non existant player**</br>
![Get non existent Players](get1.png)

(2) To test the DELETE end points, we can use **Postman**

**Delete a player by Id:**</br>

![delete a player](delete.png)

**Delete a non existant player**</br>
![delete a player](delete1.png)