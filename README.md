# Blog-Website 
is written as a Practice in .Net And HCI school project 
Blog Website is simple, beautiful, light-weight blog written in .NET Core. This cross-platform, highly extendable and customizable web application brings all the best blogging features in small, portable package



## Screen short

![screencapture-localhost-57084-2021-01-02-11_01_57](https://user-images.githubusercontent.com/65861136/103453356-2f075500-4cea-11eb-8a82-65df3266fd05.png)

##SEND GRID API

for new subscribers to get notification through Email you can integrate the Application with send Grid. It is one of the cloud email providers recommended for ASP.NET Core. It is free for under 100 daily emails and has paid options if someone needs more.

## HOW TO USE

To use SendGrid, blogger would need to sign up for service and get API key. Once you have API key, all that required is to update __appsettings.json:__


```
{
  "Blogifier": {
    "SendGridApiKey": "YOUR-SENDGRID-API-KEY",
    "SendGridEmailFrom": "admin@blog.com",
    "SendGridEmailFromName": "Blog admin"
  }
}
```

## System Requirements
- Windows, Mac or Linux
- ASP.NET Core 3.1
- Visual Studio 2019, VS Code or other code editor (Atom, Sublime etc)
- SQLite by default, MS SQL Server, PostgreSQL and MySQL out of the box, EF compatible databases should work

## Getting Started
- Clone or download source code
- Run application in Visual Studio or using your code editor
- Use admin/admin to log in
