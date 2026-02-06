Vehicle Manager

.NET Microservices CRUD app

Owen Williams 8932017

Domain vehicle JSON example:
Number of wheels cannot be less than 1
{
    "id": 2,
    "numberOfWheels": 4,
    "numberOfDoors": 4,
    "brand": "Ford"
}

endpoints:

PORT:5062

get all is GET

get one is GET /{id}

add one is POST with JSON body

update one is PUT /{id} with JSON body

delete one is DELETE /{id}