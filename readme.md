# .NET Intermediate Mastery: 30-Day Plan

This plan is designed to take you from a basic understanding of C#/.NET to a confident intermediate level. It focuses on core language features, modern development practices, and essential libraries.

## Prerequisites
- Basic understanding of C# syntax (variables, loops, classes).
- .NET SDK installed.
- VS Code or Visual Studio installed.

---

## **Week 1: Advanced Language Features**
**Goal**: Master the tools that make C# expressive and powerful.

### **Day 1: Generics**
- **Concepts**: Generic classes, methods, interfaces, and constraints (`where T : class`, `new()`).
- **Task**: Create a `Repository<T>` class that mimics a database store using an internal `List<T>`. Implement methods like `Add(T item)`, `Get(int id)`, and generic constraints to ensure `T` has an `Id` property.

### **Day 2: Delegates & Events**
- **Concepts**: `delegate`, `Func`, `Action`, `Predicate`, `event` keyword.
- **Task**: Build a `VideoEncoder` class that simulates encoding a video and notifies subscribers (like `MailService` or `MessageService`) via an event when encoding is finished. Use both custom delegates and `EventHandler<T>`.

### **Day 3: Lambda Expressions & Anonymous Types**
- **Concepts**: Lambdas (`=>`), closures, anonymous types (`var obj = new { Name = "X" }`).
- **Task**: Refactor the Day 2 task to use `Action<VideoEventArgs>` instead of custom delegates. Experiment with creating a list of objects and using lambdas to filter them.

### **Day 4: Extension Methods**
- **Concepts**: Static classes, `this` keyword in parameters.
- **Task**: Write extension methods for:
  - `string`: `WordCount()`, `ToTitleCase()`.
  - `DateTime`: `TimeAgo()` (e.g., returns "5 mins ago").

### **Day 5: LINQ (Essentials)**
- **Concepts**: `IEnumerable<T>`, Deferred Execution vs. Immediate Execution.
- **Task**: Create a `List<Product>` and use LINQ Query Syntax to filter by price and group by category.

### **Day 6: LINQ (Advanced Operators)**
- **Concepts**: `SelectMany`, `Join`, `GroupJoin`, `Zip`, `Aggregate`.
- **Task**: Simulate a database with `Students` and `Courses`. Use `Join` to list students and their course names. Use `Aggregate` to calculate total stats.

### **Day 7: Deep Dive Review & Practice**
- **Task**: Combine Days 1-6. Create a "Library Management System" (console layout) using Generics for the storage, Events for "BookBorrowed", and LINQ for searching books.

---

## **Week 2: Asynchronous Programming & Internals**
**Goal**: Write efficient, non-blocking code and understand how memory works.

### **Day 8: Garbage Collection & Memory**
- **Concepts**: Stack vs. Heap, Value Types vs. Reference Types, Garbage Collection generations.
- **Task**: Experiment with `struct` vs `class`. Write a small program using `GC.GetTotalMemory()` to see memory changes when creating thousands of objects.

### **Day 9: IDisposable & The `using` Statement**
- **Concepts**: Unmanaged resources, `IDisposable` interface, `User` pattern.
- **Task**: Create a class `FileWriter` that implements `IDisposable`. In `Dispose()`, ensure the file stream is closed. Use it in a `using` block.

### **Day 10: Task Parallel Library (TPL) Basics**
- **Concepts**: `Task`, `Task.Run`, `Task.WhenAll`.
- **Task**: Write a program that calculates the size of files in 3 different directories concurrently using `Task.Run` and waits for all of them to finish.

### **Day 11: Async & Await**
- **Concepts**: `async`, `await`, Deadlocks, handling exceptions in async voids.
- **Task**: Refactor Day 10 to use `async/await`. Simulate a long-running API call using `Task.Delay()` and display a "Loading..." message while waiting.

### **Day 12: CancellationTokens & Progress Reporting**
- **Concepts**: `CancellationTokenSource`, `IProgress<T>`.
- **Task**: Create a long-running task (iterating numbers) that can be cancelled by pressing a key. Report progress (e.g., "50% complete") to the console.

### **Day 13: File I/O & Streams**
- **Concepts**: `FileStream`, `StreamReader`/`Writer`, `MemoryStream`.
- **Task**: Write a tool that reads a large text file efficiently using streams (not `File.ReadAllText`) and counts the occurrences of a specific word.

### **Day 14: Reflection & Attributes**
- **Concepts**: `System.Reflection`, Custom Attributes.
- **Task**: Create a custom attribute `[LogExecution Time]`. Use Reflection to scan for methods with this attribute and print their names (Advanced: Use a simple proxy or just manual check to simulate AOP).

---

## **Week 3: Data Access & Architecture**
**Goal**: Persist data and structure applications correctly.

### **Day 15: Introduction to Dependency Injection (DI)**
- **Concepts**: Inversion of Control (IoC), Constructor Injection, Service Lifetimes (Singleton, Scoped, Transient).
- **Task**: Manually implement a mini DI container or use `Microsoft.Extensions.DependencyInjection` in a console app to inject a `ILogger` into a `UserService`.

### **Day 16: Entity Framework Core (Setup & Model)**
- **Concepts**: DbContext, DbSet, Code-First approach.
- **Task**: Install `Microsoft.EntityFrameworkCore.Sqlite`. Create a `BlogContext` with `Blog` and `Post` entities. Generate the initial migration.

### **Day 17: EF Core (CRUD)**
- **Concepts**: usage of `Add`, `SaveChanges`, `Find`, `Update`, `Remove`.
- **Task**: Write a console menu to Add a Blog, List all Blogs, and Update a Blog URL using EF Core.

### **Day 18: EF Core (Relationships & Eager Loading)**
- **Concepts**: One-to-Many, Many-to-Many, `.Include()`, `.ThenInclude()`.
- **Task**: Update the app to allow adding Posts to a Blog. When listing Blogs, use `.Include()` to show the count of posts for each blog.

### **Day 19: The Option Pattern & Configuration**
- **Concepts**: `appsettings.json`, `IOptions<T>`, `IConfiguration`.
- **Task**: Add a JSON config file with settings like `"MaxPostsPerBlog": 10`. Load this into a strongly-typed class and inject it into your services.

### **Day 20: Logging & Diagnostics**
- **Concepts**: `ILogger`, Serilog (optional), Structured Logging.
- **Task**: Integrate `Microsoft.Extensions.Logging`. Log warnings if a user tries to add a post but the Blog doesn't exist.

### **Day 21: Week 3 Review - Data Layer**
- **Task**: Refactor Day 7's Library System to use EF Core (SQLite) instead of in-memory lists. Use Dependency Injection to manage the Context and Repositories.

---

## **Week 4: Professional Practices & Capstone**
**Goal**: Testing, Validation, and putting it all together.

### **Day 22: Unit Testing (xUnit)**
- **Concepts**: Facts vs Theories, Assertions.
- **Task**: Create a test project. Write tests for the `Calculator` or `StringHelper` logic from Week 1.

### **Day 23: Mocking**
- **Concepts**: Interfaces for testing, Moq library.
- **Task**: Mock a database repository `IStoreRepository` to test a `OrderService` logic without hitting a real database.

### **Day 24: Middleware (Concept)**
- **Concepts**: Chain of Responsibility, Pipelines (even in Console apps you can simulate this pattern).
- **Task**: Implement a simple pipeline pattern where a "Request" passes through "LoggingMiddleware" -> "ValidationMiddleware" -> "Execution".

### **Day 25: HTTP Client**
- **Concepts**: `HttpClient`, `IHttpClientFactory`.
- **Task**: Fetch data from a public API (like JSONPlaceholder) using `HttpClient`. Deserialize the JSON result into C# objects.

### **Day 26: Validation**
- **Concepts**: FluentValidation or DataAnnotations.
- **Task**: Use FluentValidation to validate a `UserRegistration` object (e.g., Email format, Password strength) before processing it.

### **Day 27: Performance Tuning**
- **Concepts**: `Span<T>`, `Memory<T>`, Benchmarking (`BenchmarkDotNet`).
- **Task**: Compare string concatenation vs `StringBuilder` using BenchmarkDotNet.

### **Day 28: Review & Planning Capstone**
- **Task**: Review tricky concepts. Sketch out the design for the final project.

---

## **Capstone Project (Days 29-30)**
**Project**: **"TaskMaster CLI"** - A robust task management tool.

### **Requirements**:
1.  **Architecture**: Use Dependency Injection to wire up services.
2.  **Data**: Store Tasks in a SQLite database using EF Core.
3.  **Features**:
    - Add, Edit, Delete, Convert to "Done".
    - Export tasks to a JSON file (use Async File I/O).
    - Search tasks using LINQ.
4.  **Quality**:
    - Validate inputs (Empty titles not allowed).
    - Unit test the "Business Logic" (e.g., calculating overdue tasks).
    - Handle exceptions gracefully (no crashes).

### **Execution**:
- **Day 29**: Project setup, EF Core Models, DI wiring.
- **Day 30**: Logic implementation, File Export feature, Testing/Polishing.
