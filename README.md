## Project Overview

Gym Management System (GMS) is a Windows desktop application designed to organize and manage the essential operations of a gym through a centralized system.

The system provides dedicated modules for managing people, users, members, trainers, employees, classes, payments, and subscriptions, helping streamline daily administrative operations.

The application is built using C# and .NET Framework, following a Three-Tier Architecture that separates the Presentation Layer, Business Logic Layer, and Data Access Layer. It uses ADO.NET for database connectivity and Microsoft SQL Server for data storage.

This project was developed collaboratively by a team of three developers, focusing on practical software development, database design, object-oriented programming, layered architecture, and collaborative development using Git and GitHub.

flowchart TB
    subgraph PL["Presentation Layer"]
        UI["Forms and User Controls"]
    end

    subgraph BL["Business Logic Layer"]
        B["Business Classes"]
    end

    subgraph DL["Data Access Layer"]
        D["Data Access Classes"]
        CS["Data Access Settings"]
    end

    DB[("Microsoft SQL Server")]

    UI -->|"Business Operations"| B
    B -->|"Data Operations"| D
    D -->|"SQL Queries"| DB
    D --> CS
