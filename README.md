My First Blazor Web Application
Overview
This Blazor web application allows users to create a new user with their personal information, validate input, display saved users in a table, and offer several additional features such as a To-Do list, editing users, and playing music across the entire website. The application is designed to be interactive, validating user input and ensuring seamless transitions between pages.

Key Features:
User Creation Form:

Users can create a profile by entering personal information such as name, age, username, email, city, and company name.
The form validates the entered information:
It checks if all fields are filled out.
It ensures the email is in a valid format.
When a new user is created, the data is saved to a list and persisted across page reloads.
Viewing Users:

The user list is displayed in a table.
Users can be added by creating new profiles, and the list is updated accordingly.
If no new users are created, the page loads a default list of Disney character users (stored in a file).
The table includes:
A plus (+) button to view additional details of each user.
A minus (-) button to delete a user from the list.
To-Do List:

Users can create and manage their own To-Do list.
Each item can be added, saved, and displayed. The list persists when the page is reloaded.
Edit User:

Users can edit their personal information (name, age, username, email, city, company name).
A dedicated Edit button allows users to update their data.
Music Player:

A music player embedded in the application plays throughout the website, ensuring music is heard on all pages.
API Integration:

Users have the option to populate the list with users from an external API. This provides dynamic user data that is also displayed in the table.
Technologies Used:
Blazor for building interactive web applications using C#.
HTML/CSS for designing the user interface.
JavaScript (optional) for adding any dynamic functionality if required.
File-based Storage for persisting users' data across page reloads.
Components Used:
Child Components: Multiple child components have been created for different sections, such as the user form, to-do list, and the user table.
EventCallback: Utilized to handle events between parent and child components, ensuring smooth communication and state management.
How it Works
Create a User:

The user is presented with a form where they can fill out their information.
Upon clicking the "Create" button, the form checks for empty fields or invalid email format.
If any errors are found, the form alerts the user.
If the form is valid, the user’s information is saved to a list and displayed on the next page.
View Users:

A list of users is displayed in a table format, which updates dynamically as new users are added.
Users can click the plus (+) button to see additional user details.
A minus (-) button next to each user allows them to be removed from the list.
To-Do List:

The To-Do list allows users to add, save, and persist their tasks.
This list is saved and remains accessible when the page is reloaded.
Edit User:

Users can click an "Edit" button next to their profile in the user table to edit their information (name, age, etc.).
This feature allows the user’s data to be updated and reflected in the list.
Music:

A song is played continuously throughout the website using an embedded <iframe> that allows for autoplay.
This music persists across page navigations.
API Integration:

The API button retrieves users from an external source and populates the user list with dynamic data.
This feature demonstrates how to integrate external APIs into a Blazor application.
How to Use:
Creating a User:

Go to the "Create User" section.
Fill in all fields in the form (name, age, username, email, city, company).
Press "Create" to save the new user.
Viewing Users:

Go to the "View Users" section from the menu.
You will see a list of users.
Click the plus (+) button to view additional information for each user.
To delete a user, press the minus (-) button next to their name.
Manage To-Do List:

Go to the "To-Do List" section.
Add new tasks, save them, and they will persist even after page reloads.
Editing a User:

Click the Edit button next to any user in the "View Users" section.
You can update any field, such as name, email, and city.
Playing Music:

The music will play automatically as soon as you load the page.
You can enjoy the song while navigating through the site.
Future Improvements:
User Authentication: Implementing a login system to authenticate users before they can edit or delete their data.
Enhanced API Integration: Fetching more detailed user data from external APIs.
Better Form Validation: Implement more complex validation rules and error handling for form fields.
Dynamic Styling: Adding more interactive and visually appealing styles to enhance user experience.
Conclusion
This project demonstrates basic CRUD operations, event handling, file storage, and integration with external APIs in a Blazor web application. It highlights the use of child components and event callback methods to manage and display user data interactively. The music feature adds a fun element to the site, ensuring that users have an enjoyable experience as they navigate through the various pages.
