Employee Information System is a web based information system which is designed for employee information management. It allows Admin to create a short profile of any employee details. An email will be generated and send to the employee with login credentials. Employee is able to login and update his or her profile and the updated profile will reflect on Admin's dashboard.

Admin can upload an excel sheet with multiple employees information and multiple emails will be generated to the respective employees with their login credentials. 

Admin should also have right to full search and update or delete any record.

The application is an n-tier Single Page Application (SPA) built on.Net platform using various  technologies for various layers. The architecture of the application as follows:

1.Data access layer use Entity Framework code first approach with repository pattern to connect to the SQL Server database. 

2.Business logic layer use C#.net to access data from Data access layer and pass the result to Service layer.

3.Service layer use ASP.NET WEB API to organise the information from the business logic layer and provide RESTful API to frontend applicaiton.

4.Authentication + authorization is applied for both client and server side.

5.Data Validation applied  both client side and server side.

6.User interface use layter user angularjs + bootstrap and jquery

7.Data migrations is managed by entity framework
