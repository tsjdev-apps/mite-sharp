# MiteSharp

A .NET client wrapper for https://mite.de written in .NET Standard 2.0 using [Refit](https://github.com/reactiveui/refit).

> **Warning**
> Currently this package is under construction and no NuGet package is available at the moment.

## What is *mite*?

*mite* is a slim online tool for recording and evaluating working hours. Designed in close collaboration with and for teams and freelancers: advertising agencies, architects, lawyers, designers, universities and so on.

*mite* makes time recording as convenient as possible for you and your team. Enter your times manually or let the stopwatch work for you - detailed reports are immediately available. For evaluation directly in mite or third-party programs.


## Usage of `MiteSharp`

This wrapper written in .NET Standard provides different *services* to access the *mite* API. 

- Install the NuGet package.
- Activate the API access in your *mite* account.
- Copy the API key from *mite*.
- Create the needed service(s) by providing the `host` and the `API key` from *mite*

Each answer is wrapped in as a `MiteResponse`. These response provides a property `IsSuccess` to check if the request was successful. If an error occured `IsSuccess` is false and the property `error` contains more information. If `IsSuccess` is `true` than the property `Response` contains the *data*.

### MiteAccountService

```csharp
/// <summary>
///     Gets the account information
/// </summary>
Task<MiteResponse<Account>> GetAccountAsync(CancellationToken ct = default);
```

### MiteCustomerService

```csharp
/// <summary>
///     Creates a new customer asynchronously
/// </summary>
Task<MiteResponse<Customer>> CreateAsync(CustomerRequest customerRequest, CancellationToken ct = default);

/// <summary>
///     Deletes a customer asynchronously
/// </summary>
Task<MiteResponse<bool>> DeleteAsync(int customerId, CancellationToken ct = default);

/// <summary>
///     Gets all active customers asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveAsync(CancellationToken ct = default);

/// <summary>
///     Gets all active customers with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets all archived customers asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedAsync(CancellationToken ct = default);

/// <summary>
///     Gets all archived customers with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets a customer by ID asynchronously
/// </summary>
Task<MiteResponse<Customer>> GetByIdAsync(int customerId, CancellationToken ct = default);

/// <summary>
///     Updates a customer asynchronously
/// </summary>
Task<MiteResponse<Customer>> UpdateAsync(int customerId, CustomerRequest customerRequest, CancellationToken ct = default);
```

### MiteProjectService

```csharp
/// <summary>
///     Creates a new project asynchronously
/// </summary>
Task<MiteResponse<Project>> CreateAsync(ProjectRequest projectRequest, CancellationToken ct = default);

/// <summary>
///     Deletes a project asynchronously
/// </summary>
Task<MiteResponse<bool>> DeleteAsync(int projectId, CancellationToken ct = default);

/// <summary>
///     Gets all active projects asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Project>>> GetAllActiveAsync(CancellationToken ct = default);

/// <summary>
///     Gets all active projects with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Project>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets all archived projects asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedAsync(CancellationToken ct = default);

/// <summary>
///     Gets all archived projects with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets a project by ID asynchronously
/// </summary>
Task<MiteResponse<Project>> GetByIdAsync(int projectId, CancellationToken ct = default);

/// <summary>
///     Updates a project asynchronously
/// </summary>
Task<MiteResponse<Project>> UpdateAsync(int projectId, ProjectRequest projectRequest, CancellationToken ct = default);
```

### MiteServiceService

```csharp
/// <summary>
///     Creates a new service asynchronously
/// </summary>
Task<MiteResponse<Service>> CreateAsync(ServiceRequest serviceRequest, CancellationToken ct = default);

/// <summary>
///     Deletes a service asynchronously
/// </summary>
Task<MiteResponse<bool>> DeleteAsync(int serviceId, CancellationToken ct = default);

/// <summary>
///     Gets all active services asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Service>>> GetAllActiveAsync(CancellationToken ct = default);

/// <summary>
///     Gets all active services with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Service>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets all archived services asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedAsync(CancellationToken ct = default);

/// <summary>
///     Gets all archived services with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets a service by ID asynchronously
/// </summary>
Task<MiteResponse<Service>> GetByIdAsync(int serviceId, CancellationToken ct = default);

/// <summary>
///     Updates a service asynchronously
/// </summary>
Task<MiteResponse<Service>> UpdateAsync(int serviceId, ServiceRequest serviceRequest, CancellationToken ct = default);
```

### MiteUserService

```csharp
/// <summary>
///     Gets all active users asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllActiveAsync(CancellationToken ct = default);

/// <summary>
///     Gets all active users with a specific email asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllActiveByEmailAsync(string email, CancellationToken ct = default);

/// <summary>
///     Gets all active users with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets all archived users asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllArchivedAsync(CancellationToken ct = default);

/// <summary>
///     Gets all archived users with a specific email asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByEmailAsync(string email, CancellationToken ct = default);

/// <summary>
///     Gets all archived users with a specific name asynchronously
/// </summary>
Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

/// <summary>
///     Gets a user by ID asynchronously
/// </summary>
Task<MiteResponse<User>> GetByIdAsync(int userId, CancellationToken ct = default);

/// <summary>
///     Gets the current user asynchronously
/// </summary>
Task<MiteResponse<User>> GetCurrentUserAsync(CancellationToken ct = default);
```


## Available API requests

- [X] Account
  - [X] Get current account.
- [ ] Time Entries
  - [ ] Time Entries
    - [ ] Get time entries.
    - [ ] Get time entries for a day.
    - [ ] Group time entries.
    - [ ] Get time entry by ID.
    - [ ] Create a time entry.
    - [ ] Update a time entry.
    - [ ] Delete a time entry.
  - [ ] Bookmarks
    - [ ] Get bookmarks.
    - [ ] Get bookmark by ID.
    - [ ] Get time entries for a bookmark.
- [ ] Tracker
  - [ ] Get tracker.
  - [ ] Start tracker.
  - [ ] Stop tracker.
- [X] Customers
  - [X] Get all active customers. 
  - [X] Get archived customers.
  - [X] Get customer by ID.
  - [X] Create a customer.
  - [X] Update a customer.
  - [X] Delete a customer.
- [X] Projects
  - [X] Get all active projects. 
  - [X] Get archived projects.
  - [X] Get project by ID.
  - [X] Create a project.
  - [X] Update a project.
  - [X] Delete a project.
- [X] Services
  - [X] Get all active services. 
  - [X] Get archived services.
  - [X] Get services by ID.
  - [X] Create a services.
  - [X] Update a services.
  - [X] Delete a services.
- [X] Users
  - [X] Get current user.
  - [X] Get all active users.
  - [X] Get archived users.
  - [X] Get user by ID.


## Buy Me A Coffee

I appreciate any form of support to keep my _Open Source_ activities going.

Whatever you decide, be it reading and sharing my blog posts, using my NuGet packages or buying me a coffee/book, thank you ❤️.

<a href="https://www.buymeacoffee.com/tsjdevapps" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-yellow.png" alt="Buy Me A Coffee" height="41" width="174"></a>


## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.


## License

[MIT](https://choosealicense.com/licenses/mit/)
