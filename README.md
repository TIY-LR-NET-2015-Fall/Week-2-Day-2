# Week-2-Day-2 Generics

## Challenge

1. Find the sum of each set of numbers.
2. Find the average of ALL the numbers.

```c#
var numbers = new[]
                {
               new []{5,11,87,49,52,99},
               new []{20,5,67,34,12},
               new []{92,57,91,77,45,29,56,38,18,68,92,26,42,55,46},
               new []{56,18,10,92,54,14,84,79},
               new []{32,34,27,1,1,87,24,97},
               new []{93,2,78,45,96,94,16,74,99,14,33},
               new []{72,41,56,89,12,45,68,29,83,78,58,17,11,69},
               new []{29,26,38,96,99,2,54},
               new []{41,48,24,25,63,11,39},
               new []{ 4,27,40,88,10,59,90}
            };
```

#Today
1. Challenges
2. HW Review
3. Generics
4. Extensions
5. if time allows, exceptions

# Homework
Mechanic Shop

We are going to design an application for a local mechanic shop. 

They service 3 types of vehicles: Trucks, Race Cars, and Family Sedans. All vehicles can have their tires and oil changed.

When filling up gas for the vehicles, we have to be careful what type of gas we put in: Regular, High Performance, and Diesel. 

Create a 'Shop' class, using generics, that can handle these 3 types of cars. 

This 'Shop' class will perform the following functions: ChangeOil and FillUp()

The 'ChangeTire' function should be tacked on using an extension method of the Shop Class.

Demonstrate what your Shop Class can do by creating instances of all 3 car types, the shop and call the ChangeTire, FillUp, and ChangeOil functions for each type. 

Each function should briefly state what it is doing to the console.



