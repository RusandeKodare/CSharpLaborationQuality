# My First Blazor Web Application

## Overview

This Blazor web application allows users to create new profiles with personal information, validates input, displays saved users, and provides several interactive features such as a To-Do list, user editing, and background music. The app also allows you to view and manage users with options to delete or edit their profiles, and retrieve data from an external API.

### Key Features:
1. **User Creation Form**:
    - Users can create a profile by filling out a form with their personal information: name, age, username, email, city, and company name.
    - The form validates the input:
        - Checks if all required fields are filled.
        - Verifies the email format.
    - The user data is saved to a list and persists across page reloads.

2. **View and Manage Users**:
    - The users created will be displayed in a table.
    - If there are no new users, the app loads a default list of Disney character users (from a file).
    - The table features:
        - **Plus (+) Button**: View additional information about a user.
        - **Minus (-) Button**: Delete a user from the list (only created users).

3. **To-Do List**:
    - Users can add tasks to their To-Do list.
    - The list persists even after reloading the page, ensuring your tasks are saved.

4. **Edit User**:
    - Users can edit their personal information: name, age, username, email, city, or company name.
    - The application allows editing of user details via an **Edit** button.

5. **Music Player**:
    - A music player is embedded in the application to play music continuously across the entire website.
  
6. **API Integration**:
    - Users have the option to populate the list from an external API, which provides dynamic user data.

### Technologies Used:
- **Blazor** for building the interactive web app with C#.
- **HTML/CSS** for UI design and styling.
- **File-based Storage** for persisting user data across page reloads.
- **API Integration** for dynamically populating the user list.

### Components Used:
- **Parent and Child Components**: The application utilizes both parent and child components to organize functionality. Parent components manage child components, like the User Management Page or To-Do List Page, while child components handle individual tasks such as displaying the user form, showing the to-do list, and presenting user details in a table.
- **EventCallback**: Used for communication between parent and child components, allowing for dynamic updates and interaction.
- **Validation**: Form validation ensures that all required fields are filled, and the email format is correct before submitting user data.
- **Routing**: Blazor's routing system is used to navigate between pages, enabling users to seamlessly move between different sections of the app (e.g., Create User, View Users).

## How it Works

1. **Create a User**:
    - The user navigates to the "Create User" form, fills out their personal information, and clicks the **Create** button.
    - The form performs validation to ensure all fields are filled and the email is valid.
    - Once validated, the user information is added to the list, which is displayed when navigating to the user table.

2. **View and Manage Users**:
    - Users are displayed in a table, showing their basic information.
    - Clicking the **plus (+)** icon shows additional details about a user.
    - Users can be deleted by clicking the **minus (-)** icon next to their name (only created users).

3. **To-Do List**:
    - Users can manage their To-Do list by adding new tasks. The tasks are saved and persist across page reloads.
    - To add a new item, navigate to the table where the specific user is and click the plus sign. This will open up additional information about the suer. You will then be able to see the Todo-list button.
    - 
4. **Edit User**:
    - Users can edit their personal details by clicking the **Edit** button next to their profile (only created users).
    - This brings up a form where they can modify fields like name, age, email, city, etc.

5. **Music Player**:
    - A song is embedded and plays continuously on the website, regardless of which page the user navigates to.

6. **API Integration**:
    - The **Fetch Users** page allows users to fetch dynamic user data from an external API.
    - This populates the user table with fresh data and allows the user to interact with it.

## How to Use:

### Prerequisites:
Ensure the following are installed:
- **.NET SDK** (version 6.0 or higher)
- A modern web browser (Google Chrome, Microsoft Edge, or Firefox)

### Installation:

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/your-username/your-repository-name.git
    ```

2. Navigate to the project directory:
    ```bash
    cd your-repository-name
    ```

3. Restore the project dependencies (if needed):
    ```bash
    dotnet restore
    ```

4. Run the application:
    ```bash
    dotnet run
    ```

5. Open your browser and go to `https://localhost:5001` to access the application.

### Usage:

- **Create a User**: Go to the "Create User" page, fill out the form, and submit.
- **View Users**: Navigate to the "View Users" page to see the list of created users.
- **Edit a User**: Click the **Edit** button next to a user's profile to modify their details.
- **Manage To-Do List**: Add and save tasks to your To-Do list. It will persist even after page reloads.
- **Play Music**: Enjoy the background music that plays across the website.

### Further improvements:
-Using an API to store all new users.
-Let the user create an account and log into the website with their credentials
-Adding the option to change, play and stop the song
