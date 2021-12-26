# multitimezones_app
A tool to model multi-timezones application behavior

Create a new migration:
```
PS src\WebApi> dotnet ef migrations add Initial
PS src\WebApi> dotnet ef database update
```

Check operational:
```
PS > curl http://localhost:5000/Project -Method Post -Body '{"Code":"Prj", "CreatedDate":"2021-12-20", "StartDate":"2021-12-31", "EndDate":"2022-05-01"}' -ContentType 'application/json'
PS > curl http://localhost:5000/Ticket -Method Post -Body '{"ProjectId":"00000000-0000-0000-0000-000000000001", "Code":"Tck", "TransactionDate":"2021-12-20", "ReceivedOn":"2021-12-26T11:29:31+02:00"}' -ContentType 'application/json'
```