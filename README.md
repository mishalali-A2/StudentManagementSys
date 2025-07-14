# Student Management System
This is a simple ASP.NET Core MVC application for managing student records. The system allows you to perform CRUD (Create, Read, Update, Delete) operations on student data, including their personal information and enrollment details.

## Features

- View list of all students
- View detailed information about a specific student
- Add new students to the system
- Edit existing student records
- Delete student records
- Database persistence using SQL Server

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap (for frontend styling)

## Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/mishalali-A2/StudentManagementSys.git
   cd student-management-system
   ```

2. **Database Setup**:
   - Update the connection string in `appsettings.json` to point to your SQL Server instance:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=Students;Trusted_Connection=True;TrustServerCertificate=True;"
     }
     ```
   - Run the application to automatically create the database (EF Core will create it if it doesn't exist).

3. **Run the Application**:
   - Using Visual Studio:
     - Open the solution file
     - Press F5 to run
   - Using command line:
     ```bash
     dotnet run
     ```

4. **Access the Application**:
   - The application will launch in your default browser at `https://localhost:7251` or `http://localhost:5071`

## Project Structure

- `Controllers/StudentController.cs`: Contains all the controller logic for student operations
- `Models/Students.cs`: Defines the Student model
- `Data/Students_Context.cs`: Database context for Entity Framework
- `Views/Student/`: Contains all the Razor views for student operations
- `Program.cs`: Application startup and configuration
- `appsettings.json`: Configuration file with database connection string

## Usage

1. Navigate to the Students section
2. Use the interface to:
   - View all students (Index)
   - View student details (Details)
   - Add a new student (Create)
   - Edit an existing student (Edit)
   - Delete a student (Delete)
