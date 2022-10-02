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

* Core Layers:  </br>
1 - Application </br>
2 - CrossCuttingConcerns  </br>
3 - ElasticSearch  </br>
4 - Mailing  </br>
5 - Persistance  </br>
6 - Security  </br>

* Project Layers:  </br>
1 - Application (Business, Event Control)  </br>
2 - Domain (Entities, Enums, Event Implementations)  </br>
3 - Infrastructure (Adapters, 3rd Party Connections)  </br>
4 - Persistance (DB implementations, Migrations, Repositories)  </br>
5 - WebAPI (Controllers, Injections)  </br>

# Dynamic Queries usage for API consumers
{
  "sort": [
    {
      "field": "name",
      "dir": "asc"
    }
  ],
  "filter": {
    "field": "name",
    "operator": "eq",
    "value": "Series 4",    
    "logic": "and",
    "filters": [
      {
        "field": "dailyPrice",
        "operator": "eq",
        "value": "3300"
      }    
    ]
  }
}
