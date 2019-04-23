# ODataWithSwagger

Hitting `/api/Companies?$Select=Id` throws

```json
{
  "error": {
    "code": "",
    "message": "The query specified in the URI is not valid. The property 'id' cannot be used in the $select query option.",
    "details": [],
    "innererror": {
      "message": "The property 'id' cannot be used in the $select query option.",
      "type": "Microsoft.OData.ODataException",
      "stacktrace": "   at Microsoft.AspNet.OData.Query.Validators.SelectExpandQueryValidator.ValidateSelectItem(SelectItem selectItem, IEdmProperty pathProperty, IEdmStructuredType pathStructuredType, IEdmModel edmModel)\r\n   at Microsoft.AspNet.OData.Query.Validators.SelectExpandQueryValidator.ValidateRestrictions(Nullable`1 remainDepth, Int32 currentDepth, SelectExpandClause selectExpandClause, IEdmNavigationProperty navigationProperty, ODataValidationSettings validationSettings)\r\n   at Microsoft.AspNet.OData.Query.Validators.SelectExpandQueryValidator.Validate(SelectExpandQueryOption selectExpandQueryOption, ODataValidationSettings validationSettings)\r\n   at Microsoft.AspNet.OData.Query.Validators.ODataQueryValidator.Validate(ODataQueryOptions options, ODataValidationSettings validationSettings)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.ValidateQuery(HttpRequest request, ODataQueryOptions queryOptions)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.<>c__DisplayClass1_0.<OnActionExecuted>b__3(ODataQueryContext queryContext)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.ExecuteQuery(Object responseValue, IQueryable singleResultCollection, IWebApiActionDescriptor actionDescriptor, Func`2 modelFunction, IWebApiRequestMessage request, Func`2 createQueryOptionFunction)\r\n   at Microsoft.AspNet.OData.EnableQueryAttribute.OnActionExecuted(Object responseValue, IQueryable singleResultCollection, IWebApiActionDescriptor actionDescriptor, IWebApiRequestMessage request, Func`2 modelFunction, Func`2 createQueryOptionFunction, Action`1 createResponseAction, Action`3 createErrorAction)"
    }
  }
}
```
