# InterfacesAndComplexEntities

## Table of Contents

- [Introduction](#introduction)
- [Application](#application)
- [Instructions](#instructions)
- [Structure](#structure)
- [Functionalities](#functionalities)

---

## **INTRODUCTION**

- .Net studying project to practice:
  - Complex Data Types in Entities
  - Interfaces
  - Tests with xUnit

---

## **APPLICATION**

 - Framework net6.0
 - Console Application
 - No Database

---

## **INSTRUCTIONS**

- This is a study project to be run locally only.
- Just run the application.
    
---

## **STRUCTURE**

>- People
>  - Client
>  - Employee

>- Products
>  - Food
>  - Beverage

>- Sale
>  - List of products
>  - Client
>  - Employee
---

## **FUNCTIONALITIES**

Since it's a Console application, all the functionalities happen in **Program.cs**

> Managing **People**:
>- In **Program.cs**, instantiate the controllers:
>  - var client = new ClientController();
>  - var employee = new EmployeeController();
>

> Managing **Products**:
>- In **Program.cs**, instantiate the controllers:
>    - var food = new FoodController();
>    - var beverage = new BeverageController();

> Managing **Sale**:
>- In **Program.cs**, instantiate the controllers:
>    - var sale = new SaleController();
>    - A product, a client and an employee must be instantiated in order to create a sale.