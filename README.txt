# QA Automation Task – C# + Selenium

This repository contains a test automation solution for a full-stack login web application. The task was completed as part of a QA technical assessment.

## 🔧 Technologies Used
- C#
- Selenium WebDriver
- NUnit
- .NET SDK

## 📁 Project Structure
QA_Part2_CSharpSelenium/
├── Tests/
│ └── LoginTests.cs
│ └── RegisterTests.cs
├── Drivers/
│ └── DriverFactory.cs
├── Pages/
│ └── LoginPage.cs
│ └── RegisterPage.cs
├── Utilities/
│ └── TestBase.cs
├── QA_Part2_CSharpSelenium.csproj
└── README.md

pgsql
Copier
Modifier

## 🧪 Test Scenarios Automated
- Register new user (valid and invalid input)
- Login (valid and invalid credentials)
- Logout functionality

Each test includes both positive and negative cases with clear assertions.

## ▶️ How to Run the Tests
1. Clone the repository.
2. Open the project in Visual Studio or any C# IDE.
3. Make sure the target web application is running locally (e.g., http://localhost:3000).
4. Run the tests using the built-in test explorer or via console with `dotnet test`.

## 📌 Notes
- ChromeDriver is required and should match your Chrome version.
- Modify base URLs in `TestBase.cs` if needed.

## 🐞 Bugs Found
See `QA_Part3_BugReports.pdf` for detailed documentation of the bugs discovered during testing.

---

**Author:** Abderrahman Lyassi  
