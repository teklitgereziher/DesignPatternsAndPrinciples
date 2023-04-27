# Design Patterns And Principles 
## SOLID Design Principles

### Single Responsibility Principle (SRP)
SPR states that "A class should have only one reason to change". In other words, each class in a software should handle single responsibility from the set of functionalities provided by the software.
### Liskov Substitution Principle (LSP)
LSP states that "drive types must be substitutable for their base types". That means, if a class is inheriting from a base class, then the reference to the base class can be replaced with the derived class reference without affecting the functionality of the program. LSP is an extension of the OCP.
#### Main Implementation Guidelines
- Subtypes should not thow new exceptions unless they are part of the existing exception hierarchy.
- Clients should not know which specific subtype they are calling. The client should behave the same regardless of the subtype instance that is given.
- New derived classes should just extend the existing classes without replacing the functionality of old classes.

### Open /Closed Principle (OCP)

### Interface Segregation Principle (ISP)

### Dependency Inversion Principle (DIP)

## Design Patterns
