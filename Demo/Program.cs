using System.Reflection.Metadata;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Text;

namespace Demo
{
    internal class Program
    {

        //.NET is a versatile platform for building various types of applications, including desktop, web, cloud, mobile, gaming, IoT, and AI.

        //It includes common base libraries, infrastructure, runtime components, compilers, and supports multiple languages like C# and F#.

        //.NET 6 is highlighted as a unified platform for all types of applications, with tools like Visual Studio, GitHub, and NuGet.

        //.NET : Unified Development Platform 
        // 1.Common Base Libraries
        // 2.Infrastructure [Runtime components - Compilers - Languages]


        // Asp.net has 3 projects :
        //Mvc 
        //Razor
        //Web Api 


        //.net blazor 
        // Server app : multiple
        // Web Assembly : SPA


        // ASP.NET MVC
        //ASP.NET MVC is one of the products under ASP.NET, following the Model-View-Controller (MVC) architectural pattern.

        //Model: Represents data and business logic - Represents database tables(C# classes).

        //MVC Components

        //View: Handles the UI and presentation - Represents HTML pages.
        //Controller: Manages user input and interactions.
        //Controllers are classes that inherit from the Controller class and contain public non-static functions called actions, typically performing CRUD operations - Functions



        //A controller is a class that inherits from Controller.
        //The name must end with "Controller".
        //Contains public non-static functions called Actions.

        //Basic CRUD actions:

        //GetAll()
        //GetById()
        //Add()
        //Update()
        //Delete()


        //HTTP : HyperText transfer protocol [REquest and response]
        //FTP  : File transfer protocol
        //TCP  : Transmission control protocol


        //Https vs Http
        //Https is more secure
        //HTTP (Hypertext Transfer Protocol) is the foundation of data communication on the web.
        //HTTPS adds a security layer(SSL/TLS) to encrypt data, protecting sensitive information like passwords.


        //URL Structure
        //A URL consists of several parts: protocol, domain, port, path, and query string.
        //URI(Uniform Resource Identifier) includes URL(Uniform Resource Locator) and URN(Uniform Resource Name).

        //Url : Uniform Resource Locator
        //Http -> protocol
        //www -> Sub-Domain
        //Domain: name of website
        //TLD : .com/.net etc.



        //Uri = Urn + Url : Uniform Resource Identifier


        //Server : Computer or device its ip is accessible through the internet

        //Server Types
        //Physical Server: A hardware server.
        //Virtual Server: A software-based server running on a physical server, managed by a hypervisor.

        //A physical server : a dedicated, standalone hardware that runs an operating system and applications directly on its hardware.

        //Advantages:

        //High performance (direct access to hardware). 
        //More stable(no resource sharing).
        //Better for high workloads(databases, high-traffic websites).

        //Disadvantage : 

        //Expensive - Limited Scalability

        //Virtual Server : software-based machine running on a physical server using virtualization

        //Advantages:

        //Cost-efficient - Scalable - Backup & Recovery

        //Disadvantage : 

        //Shared resources - Security risks 

        //Http Messages 
        //1.Request

        //Request Line : Method + Path + Protocol + Version 
        // Methods : Get , Post , Put , Delete

        //2.Response
        //Status line 
        //100 - 199 -> Info
        //200 - 299 -> Successful
        //300 - 399 -> Redirection
        //400 - 499 -> Client Error
        //500 - 599 -> Server Error


        //ASP.NET Framework : [Web Forms - Web Pages - Mvc ]


        //ASP.NET Core : [Razor Pages - Mvc ]


        //ASP.NET SignalR : [Model - Controller ]


        //Kestrel : Internal Web Server
        //Used in reverse proxy configuration


        //Asp hosting : windows [IIS] - linux/mac [Apache-nginx] 


        //ASP.NET Core
        //ASP.NET Core is a cross-platform framework for building modern web applications.

        //It supports reverse proxy servers like IIS, Nginx, and Apache, and can run on Windows, Linux, and macOS.


        //Two deployment profiles are recommended: using Kestrel as an edge server or in a reverse proxy configuration.

        //Routing and Constraints
        //Routing in ASP.NET Core maps URLs to controller actions.

        //Route constraints (e.g., alpha, int, regex) ensure that URL segments match specific patterns or data types.

        //Templates and Project Structure
        //ASP.NET Core provides templates for creating empty projects or MVC projects with predefined folders for controllers, views, and models.


        //The startup process involves configuring services and setting up the request pipeline.


        //MVC Separation of Concerns
        //Model: Manages data storage, integrity, and queries.


        //View: Handles presentation and UI.


        //Controller: Processes user input, updates views, and interacts with models.


        //HTTP Messages and Status Codes
        //HTTP messages include request and response headers and bodies.


        //Status codes indicate the result of an HTTP request, such as success (200-299), redirection(300-399), client errors(400-499), and server errors(500-599).

        //Client-Side vs.Server-Side Code
        //Client-Side: HTML, CSS, JavaScript.

        //Server-Side: Languages like PHP, Python, and frameworks like ASP.NET, NodeJS.

        //This file serves as a comprehensive guide to understanding.NET, ASP.NET MVC, and related web development concepts, with a focus on architecture, deployment, and best practices.

    }
}
