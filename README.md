# HotelManagement
This project is for maintaining hotel transaction and accountability for efficient cost optimization and calculations.

# CLI commands to build the Application to production folder

# HotelManagement.Server  [ASP.NET Core Web API 8]
dotnet publish -c Release -o ..\..\Production\Server

# HotelManagement.UserInterface [Angular]
ng build --configuration production --output-path=../Production/UserInterface  


# Run the Application

# HotelManagement.Server
Locate to Production/Server and Just serve the .exe file by clicking , it will default run on localhost:5000 , test it by localhost:5000/swagger

# HotelManagement.UserInterface
Create a global http server using npm command "npm install -g http-server"
Locate to Production/UserInterface/browser , open command prompt use "http-server" , the angular app will run on localhost:8080


# Production 
Locate to folder production and execute the ps1 script , the applications will be on running locally.



