/* 
1st step: makapag enter ng todo
2nd: idisplay
3rd makapag mark as done
column = id  date status[f not yet done, t already done]
rows = values ex: task1 task2
1st view to do, add to do mark as done exit
sa mark to do = enter the  task id, i mark as  done or true

*/

using System.Xml.Serialization;

string[,] tasks = new string[100, 4];
int c = 0;

do
{
    Console.WriteLine("====================");
    Console.WriteLine("[1]: VIEW TO DO");
    Console.WriteLine("[2]: ADD TO DO");
    Console.WriteLine("[3]: MARK AS DONE");
    Console.WriteLine("[4]: EXIT");
    Console.WriteLine("====================");

    Console.Write("Enter Choice: ");
    int choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            Console.WriteLine("\n             ID".PadRight(18) + "DATE".PadRight(12) + "STATUS");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(
                            tasks[i, 0].PadRight(14) +
                            tasks[i, 1].PadRight(6) +
                            tasks[i, 2].PadRight(12) +
                            tasks[i, 3]
                        );

            }
            break;

        case 2:
            Console.Write("Enter your Task:");
            string t = Console.ReadLine();

            tasks[c, 0] = t;
            tasks[c, 1] = (c + 1).ToString();
            tasks[c, 2] = DateTime.Now.ToString("MM/dd/yy");
            tasks[c, 3] = "F";

            c++;
            Console.WriteLine("Task Added!");
            break;

        case 3:


            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine()!);

            bool found = false;

            for (int i = 0; i < c; i++)
            {
                if (int.Parse(tasks[i, 1]) == id)
                {
                    tasks[i, 3] = "T";
                    found = true;
                    Console.WriteLine("Task marked as done!");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Task ID not found!");
            }

            break;

        case 4:

            Console.WriteLine("Thank you for using!");
            break;

        default:
            Console.WriteLine("Invalid choice!");
            break;


    }

} while (c != 4);






   

