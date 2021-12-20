# multitimezones_app
A tool to model multi-timezones application behavior

Create a new migration:
```
PS src\WebApi> dotnet ef migrations add Initial
```

Check operational:
```
PS > curl http://localhost:5000/Project -Method Post -Body '{"Code":"Prj", "CreatedDate":"2021-12-20"}' -ContentType 'application/json'
```