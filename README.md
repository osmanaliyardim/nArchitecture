# nArchitecture
nArchitecture Implementation Base

** Rent A Car Website Project

- CQRS implementation, Mediatr
- Business rules with SOLID Principles
- Automapper
- Role based structure
- Pipelines for caching, logging and validation
- Global exception handling and logging
- ElasticSearch
- Security (Email, OTP, Hashing, Refresh token)
- Dynamic repository implementation with paging, queries and joins
- Event driven approach (RabbitMQ, Kafka)
- Tests

* Core Layers:
1 - Application
2 - CrossCuttingConcerns
3 - ElasticSearch
4 - Mailing
5 - Persistance
6 - Security

* Project Layers: 
1 - Application (Business, Event Control)
2 - Domain (Entities, Enums, Event Implementations)
3 - Infrastructure (Adapters, 3rd Party Connections)
4 - Persistance (DB implementations, Migrations, Repositories)
5 - WebAPI (Controllers, Injections)
