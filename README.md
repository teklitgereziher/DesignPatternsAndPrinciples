# Design Patterns And Principles 
## SOLID Design Principles

### Single Responsibility Principle (SRP)
SPR states that "A class should have only one reason to change". In other words, each class in a software should handle single responsibility from the set of functionalities provided by the software. It increase cohesion and loose coupling of the software. SRP also enables you to follow the Separation of Concerns Principle (SCP). SCP states that a program should be broken down into distinct parts where each part addresses a specific concern or set of information that affects the program. That is, high-level business logic should not concern on the low-level implementation.
### Liskov Substitution Principle (LSP)
LSP states that "Drive types must be substitutable for their base types". That means, if a class is inheriting from a base class, then the reference to the base class can be replaced with the derived class reference without affecting the functionality of the program. LSP is an extension of the OCP.
##### Implementation Guidelines
- Subtypes should not thow new exceptions unless they are part of the existing exception hierarchy.
- Clients should not know which specific subtype they are calling. The client should behave the same regardless of the subtype instance that is given.
- New derived classes should just extend the existing classes without replacing the functionality of old classes.

### Open /Closed Principle (OCP)
OCP states that "Software entities such as classes, modules, and functions should be open for extension, but closed for modification".
That means, any new functionality should be implemented by adding new classes, attributes, or methods by driving from the original class instead of changing the current ones or existing ones.
##### Implementation Guidelines
- Implement the new functionality on new derived classes
- Allow clients to access the original class with an abstract interface.

### Interface Segregation Principle (ISP)
ISP states that no client should be forced to implement a method in an interface that it doesn’t use. If the clent does not have any reason to use the method, the class should not be forced to implement it. So, break down the big interface into smaller interfaces.
##### Implementation Guidelines
- No client should be forced to implement methods that it does not use them.
- Instead of one big interface break it down into small interfaces based on groups of methods with related functionalities.

### Dependency Inversion Principle (DIP)

## Design Patterns
