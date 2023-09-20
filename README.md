# Planets_API

An implementation of a .NET CORE API that communicates with and manipulates a database with HTTP requests. 
The project's data consist of an integer value namely "id", a planet's name as a string value and its distance from the sun in km,
also as a string value.

![interface](https://github.com/JohnSymeon/Planets_API/assets/125981941/7b09840b-3e56-435b-9f78-249caae079a8)

It makes use of these HTTP requests:
1) GET: gets all data from the database
2) POST: used to create a new value by providing a name and the distance with the id being automatically created
3) GET: returns the data of specific id
4) PUT: updates in accordance with a value's id
5) DELETE: it removes a value from the database according to its id
