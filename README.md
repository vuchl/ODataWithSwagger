# ODataWithSwagger

Hitting `/swagger` shows all options on `api/v1/Companies` that are enabled via
```csharp
  routeBuilder.Select().Count().OrderBy().Filter().Expand();
```

the `[EnableQuery(AllowedQueryOptions = Select | Filter | Expand)]` on the `Controllers\CompaniesController.cs` are not honored
