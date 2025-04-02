


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

using Project_I;

class Program
{
    static List<TaskItem> tasks = new List<TaskItem>(); // List to store tasks

    static void Main(string[] args)
    {
        // Directly create some example tasks here
        tasks = new List<TaskItem>
        {
        new TaskItem("Complete project report", new DateTime(2023, 12, 1), "Work"),
        new TaskItem("Buy groceries", new DateTime(2023, 11, 25), "Personal"),
        new TaskItem("Schedule dentist appointment", new DateTime(2023, 12, 5), "Health"),
        new TaskItem("Prepare presentation", new DateTime(2023, 12, 7), "Work"),
        new TaskItem("Call plumber", new DateTime(2023, 11, 28), "Home")
        };
        // Mark the "Buy groceries" task as done
        tasks[1].Status = true;

        LoadTasks(); // Load tasks from a file
        ShowMenu();  // Show the menu
    }

    static void LoadTasks()
    {
        // Load tasks from a file
        // If the file does not exist, create a new file
        // Implement error handling for file reading (e.g., corrupted or missing data)
    }
     
    static void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Task Manager");
            Console.WriteLine($"You have {tasks.Count} tasks.");
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Save and Quit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ListTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    EditTask();
                    break;
                case "4":
                    SaveAndQuit();
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ListTasks()
    {
        // Count the number of tasks that are done
        int doneCount = tasks.Count(task => task.Status);

        // Display the tasks
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine($"You have {tasks.Count} tasks in total, {doneCount} tasks done.");
        Console.WriteLine("How would you like to sort the tasks?");
        Console.WriteLine("1. By Project");
        Console.WriteLine("2. By Due Date");
        Console.Write("Select an option: ");

        string sortOption = Console.ReadLine();
        List<TaskItem> sortedTasks = new List<TaskItem>();

        switch (sortOption)
        {
            case "1":
                sortedTasks = tasks.OrderBy(task => task.Project).ToList();
                break;
            case "2":
                sortedTasks = tasks.OrderBy(task => task.DueDate).ToList();
                break;
            default:
                Console.WriteLine("Invalid option. Displaying unsorted tasks.");
                sortedTasks = tasks;
                break;
        }

        Console.WriteLine("List of Tasks:");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("| {0,-20} | {1,-12} | {2,-15} | {3,-10} |", "Title", "Due Date", "Project", "Status");
        Console.WriteLine("--------------------------------------------------------------");

        foreach (var task in sortedTasks)
        {
            // Print each task in a formatted row
            Console.WriteLine("| {0,-20} | {1,-12} | {2,-15} | {3,-10} |",
                task.Title.Length > 20 ? task.Title.Substring(0, 17) + "..." : task.Title,
                task.DueDate.ToString("MM/dd/yyyy"),  // Use short date format for readability
                task.Project.Length > 15 ? task.Project.Substring(0, 12) + "..." : task.Project,
                task.Status ? "Done" : "Pending");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }

        Console.Write("Enter task due date (MM/dd/yyyy): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate) || dueDate <= DateTime.Now)
        {
            Console.WriteLine("Invalid due date. Please enter a future date in the format MM/dd/yyyy.");
            return;
        }

        Console.Write("Enter task project: ");
        string project = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(project))
        {
            Console.WriteLine("Project cannot be empty.");
            return;
        }

        tasks.Add(new TaskItem(title, dueDate, project));
        Console.WriteLine("Task added successfully.");
    }

    static void EditTask()
    {
        // Implementation for editing a task
    }

    static void SaveAndQuit()
    {
        // Implementation for saving tasks and quitting the program
    }
}
