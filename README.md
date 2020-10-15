# OnlineStore
OnlineStore project based on ASP.Net Core 3.1 - ComIT.Net course.

This is a simple onlinestore web application include two small projects:

I - Retail onlinestore web application for display products and selling to customers. Overall business application specification:
- Create an online product catalog that customers can browse by category and page
- A shopping cart where users can add and remove products
- A checkout where customers can enter their shipping details. Note: this version has not integrated with payment processing yet.


II - Administration onlinestore web application
- Login management 
- Create , read, update and delete (CRUD) facilities for managing the catalog

Overall Application Architecture:
- Compliance with new Principal Architectural Design of Web Modern Application ASP.Net.
- Developed based on ASP.Net Core MVC framwork and integrated with two seperpated frameworks:
    - EntityFrameworkCore
    - ASP.Net Core Identity Framework
- Used Balazor Server for Administration OnlineStore App
- Architecture of this onlinestore application designed for maintable, extensible, well-structure code with excellent support for unit testing (Xunit unit testing framwork) by applying TDD process.
- Database is uing for this web application: Sqlite database.
