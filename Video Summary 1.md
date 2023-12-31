# A2SV-Blog-CRUD-Clean-Architecture
Clean Architecture is a software architecture or design that aims to create 
maintainable, scalable and easily testable software product. This architecture's dependence on infrastructure is minimized. It focuses on domain logic rather than infrastructure.
## Clean Architecture Layers
### Core Layer
This layer contains the business logic of the application. It is independent of any other layer.
### Use-Cases
Use cases are the application-specific business processes.
### Interface Layer
Converts data between the use cases and the external layers.
### Infrastructure Layer
This layer contains the implementation of the external layers such as database, web, etc.