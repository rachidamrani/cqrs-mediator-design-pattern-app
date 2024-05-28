# CQRS Mediator Design Pattern example

A simple CRUD application that uses CQRS design pattern.

- [CQRS Mediator Design Pattern example](#cqrs-mediator-design-pattern-example)
- [Usage](#usage)
- [API Definition](#api-definition)
  - [Create Person](#create-person)
    - [Create Person Request](#create-person-request)
    - [Create Person Response](#create-person-response)
  - [Get Person](#get-person)
    - [Get Person Request](#get-person-request)
    - [Get Person Response](#get-person-response)
  - [Get All Persons](#get-all-persons)
    - [Get All Persons Request](#get-all-persons-request)
    - [Get All Persons Response](#get-all-persons-response)
---

# Usage

Simply `git clone https://github.com/rachidamrani/cqrs-mediator-design-pattern-app` and `dotnet run --project CqrsMediatorDesignPatternApp`.

# API Definition

## Create Person

### Create Person Request

```js
POST /persons
```

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "firstName": "string",
  "lastName": "string"
}
```

### Create Person Response

```js
201 Created
```

```yml
Location: {{host}}/persons/{{id}}
```

```json
{
   "id": "71c2b7f8-ce8f-4cfc-a92d-28c146826831",
   "firstName": "John",
   "lastName": "Doe"
},
```

## Get Person

### Get Person Request

```js
GET api/persons/{{id}}
```

### Get Person Response

```js
200 Ok
```

```json
{
  "id": "71c2b7f8-ce8f-4cfc-a92d-28c146826831",
  "firstName": "John",
  "lastName": "Doe"
}
```


## Get All Persons

### Get All Persons Request

```js
GET api/persons
```

### Get All Persons Response

```js
200 Ok
```

```json
[
  {
    "id": "71c2b7f8-ce8f-4cfc-a92d-28c146826831",
    "firstName": "John",
    "lastName": "Doe"
  },
  {
    "id": "5e498223-6f2d-47ae-85b7-cc8ca81e6c3d",
    "firstName": "Sue",
    "lastName": "Storm"
  }
]
```