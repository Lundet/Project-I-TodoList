// Class for Tasks - Contains properties for task status (bool), title (string), due date (DateTime), and project (string)

// Constructor to initialize the task status, title, due date, and project


// Load tasks from a file when the program starts
//    - If the file does not exist, create a new file
//    - Implement error handling for file reading (e.g., corrupted or missing data)

// Menu - Provides options for adding, listing, editing, saving, and quitting tasks
//    - After loading, show the menu along with the task summary ("You have X tasks to do and Y tasks done.")
//    - Validate user input to ensure only valid menu options are selected


// ListTasks [1] - Ask user to choose sorting by [1] Project or [2] Due Date
//    - Display tasks sorted by either project or due date based on the user's choice
//    - Handle cases where there are no tasks available to display


// AddTask [2] - Creates a new task with a title (string), due date (DateTime), project (string), and default status (bool: false)
//    - Validate user input for empty title or project name
//    - Ensure the due date is a valid future date
//    - Handle errors in user input (e.g., incorrect date format)


// EditTask [3] - Allows updating task details, marking a task as done (bool: true), or deleting a task
//    - Ensure the selected task exists before editing or deleting
//    - Validate user input when updating task details


// Save and Quit [4] - Saves the current task list to a file and exits the program
//    - Handle errors during file saving (e.g., permission issues, disk full)
