# CinemaTA

## Index
1. [About](#about)
2. [APIs](#apis)  
2.1. [GET](#get)  
2.2. [POST](#post)  
2.3. [PUT](#put)  
2.4. [DELETE](#delete)

---

## About
This is the source code of my test assignment, where I was supposed to write a simple Web API with CRUD operations, and deploy it to Azure. [CinemaTA](http://cinemata.azurewebsites.net/) is a fictional cinema, and you are the back-end developer working there. Your duties are as simply, as it can only be: **add** new movies to the affiche, **edit** the records with typos in the details, **delete** the old ones, and periodically just **check** whether everything is fine.

---

## APIs
When I was developing this project, I was using [Postman](https://www.postman.com/) to interact with APIs, so I assume you're gonna use it as well.

As you may see, [Movie](https://gitlab.com/ElijahLaMoon/cinemata/-/blob/master/CinemaTA/Models/Movie.cs)'s model comprises a bunch of field:
- `int` `Id`
- `string` `Title`
- `string` `Director`
- `int` `ReleaseYear`

`Id` is a **`[Key]`**, and three others are **`[Required]`**. Below you'll find examples of valid requests

---

### GET
Header  
```
GET https://cinemata.azurewebsites.net/api/Movies
```
or
```
GET https://cinemata.azurewebsites.net/api/Movies/{id}
```

---

### POST
Header
```
POST https://cinemata.azurewebsites.net/api/Movies
```
Body
```json
{
    "title": "Cherkasy",
    "director": "Tymur Yashchenko",
    "releaseYear": 2020
}
```

---

### PUT
Header
```
PUT https://cinemata.azurewebsites.net/api/Movies
```

Body
```json
{
    "id": 2,
    "title": "Joker",
    "director": "Todd Phillips",
    "releaseYear": 2019
}
```

---

### DELETE
Header
```
DELETE https://cinemata.azurewebsites.net/api/Movies/{id}
```

---

Have fun :^)