Employee Profile & Activity Report Generator

Scenario
You are developing an Employee Management System for an IT company. The application should collect employee details, 
process employee information, and generate a formatted employee profile and activity report.

1. Employee Details
Get the following details from the user:
    - Employee ID
    - Employee Name
    - Email Address
    - Department
    - Designation
    - City
    - Skills (comma-separated)
    - Employee Address
  
2. String Operations
Use the string class to perform the following operations:
    1. Convert the employee name into uppercase.
    2. Extract the employee's first name and last name.
    3. Validate whether the email contains @ and ends with .com.
    4. Check whether the employee belongs to the IT department using Equals().
    5. Check whether the employee's name starts with a particular character.
    6. Replace the old department name with a new department name.
    7. Remove unnecessary spaces from the employee address using Trim().
    8. Split the skills into individual values using Split().
    9. Check whether a particular skill exists using Contains().
    10. Display the total number of characters in the employee's name.
  
3. StringBuilder Operations
Use StringBuilder to generate a complete employee profile report.
    1. Use Append() to add employee details.
    2. Use AppendLine() to display each employee detail on a separate line.
    3. Use Insert() to add the company name at the beginning of the report.
    4. Use Replace() to update the employee's designation.
    5. Use Remove() to remove an unwanted section from the report.
    6. Use Append() to add all employee skills.
7. Generate a formatted employee summary with proper separators.

4. Final Output
              Display the following employee report:
              ========== EMPLOYEE PROFILE REPORT ==========
              
              Company Name : XYZ Technologies
              
              Employee ID  : 101
              Employee Name: AJITH KUMAR
              First Name   : Ajith
              Last Name    : Kumar
              
              Email        : ajith@gmail.com
              Department   : IT
              Designation  : Senior Developer
              City         : Chennai
              
              Skills:
              C#, ASP.NET Core, SQL, JavaScript
              
              Address:
              Nagercoil, Tamil Nadu
              
              =============================================
              
              Total Name Characters : 11
              Total Skills          : 4
              Email Validation      : Valid
              Department            : IT
              
              =============================================
