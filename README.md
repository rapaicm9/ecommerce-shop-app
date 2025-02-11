# ecommerce-shop-app
 
## Catalog.API Microservice

* Developed using Vertical Slice architecture with Feature folders
* Implemented CQRS using MediatR library
* Used CQRS Validation Pipeline Behaviors using MediatR and FluentValidation libraries
* Utilized Marten library to transform PostgreSQL into .NET Transactional Document DB
* Used Carter library for Minimal API endpoint definitions
* Cross-cutting concerns Logging, Global Exception Handling and Health Checks
* Containerized and orchestrated the service using Dockerfile and Docker Compose

## Basket.API Microservice

* Developed using Vertical Slice architecture with Feature folders
* Used Proxy, Decorator and Cache-aside patterns
* Implemented CQRS using MediatR library
* Used CQRS Validation Pipeline Behaviors using MediatR and FluentValidation libraries
* Utilized Marten library to transform PostgreSQL into .NET Transactional Document DB
* Used Carter library for Minimal API endpoint definitions
* Cross-cutting concerns Logging, Global Exception Handling and Health Checks
* Utilized Redis as a Distributed Cache over basketdb
* Implemented gRPC and RabbitMQ for interservice communication
* Containerized and orchestrated the service using Dockerfile and Docker Compose

## Discount.Grpc Microservice

* ASP.NET gRPC Service application
* Developed using N-Layer Architecture
* Used SQLite as Database solution
* Exposed Grpc Services by creating Protobuf messages

## Ordering.API Microservice

* Developed using DDD pattern and Clean Architecture
* Used Microsoft SQL Server as Database solution
* Utilized Entity Framework Core Code-First Approach
* Raised and handled Domain Events & Integration Events
* Consumed RabbitMQ BasketCheckout event queue using MassTransit-RabbitMQ Configuration
* Containerized and orchestrated the service using Dockerfile and Docker Compose

## Yarp.API Gateway Microservice

* Developed API Gateways with Yarp Reverse Proxy applying Gateway Routing Pattern
* Yarp Reverse Proxy Configuration: Route, Cluster, Path, Transform and Destinations
* Rate Limiting with FixedWindowLimiter on Yarp Reverse Proxy Configuration
* Containerized and orchestrated the service using Dockerfile and Docker Compose
