using TaskManagerConsolePractice2;

int userChoice = 0;
int Id = 1;

List<TaskItem> tasks = new List<TaskItem>();

while (userChoice != 4)
{
    Console.WriteLine("Please choose from the following options");
    Console.WriteLine("1. Create new task");
    Console.WriteLine("2. View Task History");
    Console.WriteLine("3. Delete or Edit Task.");
    Console.WriteLine("4. Exit");

    userChoice = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Please input a title..");
            string? title = Console.ReadLine();
            Console.WriteLine("Please Input a description");
            string? description = Console.ReadLine();
            Console.WriteLine("Task Saved..");
            TaskItem newTask = new TaskItem();
            newTask.Title = title;
            newTask.Description = description;
            newTask.Id = Id;
            tasks.Add(newTask);
            Id++;
            break;
        case 2:
            foreach (TaskItem in tasks)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Task Id: {tasks.Id}");
                Console.WriteLine($"Title: {tasks.Title}");
                Console.WriteLine($"Task Description: {tasks.Description}");
                Console.WriteLine("----------------------------------");
            }
            break;
        case 3:
            Console.WriteLine("Delete or edit task");
            break;
        case 4:
            Console.WriteLine("Exit");
            break;
    }
}




