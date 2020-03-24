using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                float cityPopulation = float.Parse(task.City.Population);
                float sickPercentage = float.Parse(task.City.SickPercentage);
                float deathRate = float.Parse(task.Virus.KillProbability); 

                float sickPeopleCount = cityPopulation * sickPercentage;
                float deadPeopleCount = sickPeopleCount * deathRate;

                string result = $"There are {Math.Truncate(sickPeopleCount)}" +
                $" people sick with {task.Virus.Name} in the city of {task.City.Name}," +
                $" {Math.Truncate(deadPeopleCount)} of which died";

                return result;
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
