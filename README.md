# OnlineStore
OnlineStore project based on ASP.Net Core 3.1

This is a simple onlinestore web application include two small projects and is built base on ASP.Net Core and compliance with new Principal Architectural Design of Web Modern Application ASP.Net.

I - Retail onlinestore web application for display products and selling to customers. Overall business application specification:
- Create an online product catalog that customers can browse by category and page
- A shopping cart where users can add and remove products
- A checkout where customers can enter their shipping details. Note: this version has not integrated with payment processing yet.


II - Administration onlinestore web application
- Login management 
- Create , read, update and delete (CRUD) facilities for managing the product catalog and for managing shipping orders.


Top Level Design:

This application will serve a responsive graphical user interface through modern web browsers.The application contains two Web projects, one based on the MPA multi-page application created by MVC, and one based on the Spa single page app created by Razor.

Data of this web application is organized to store in SQLite version, but it can be migrated to apply on any database type such as: SQLServer, NoSQL DB, etc... The Data is stored into following tables including:

•	Order table contains user order item information and contains shipping address information.
•	Product table contains the products information and products category
•	CartLine table contains the shopping cart product information

The application will be structured base on Clean Architectural Design in three-layer correspondence:
1.	Applicationcore: Domain Layer
This is a core of application and is used to define and implement business rules. It is mainly use for entities, value objects, aggregation, warehousing, Domain Services and domain events.

2.	Infrastructure: Infrastructure Layer
Primarily provides common basic services and persistence such as database storage, logging activities, services email sending.

3.	Web/webrazorpages: Presentation Layer
Presentation layer is responsible for the coordination between the layer and domain layer, and coordinates the business logic to execute the specific application.

Test-Driven Development apllied in during develope this web application by using Xunit testing framework.
