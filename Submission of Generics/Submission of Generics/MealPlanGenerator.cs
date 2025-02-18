using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{
    interface IMealPlan
    {
        string Name { get; }
        int Calories { get; }
        void DisplayMealDetails();
    }

    
    class VegetarianMeal : IMealPlan
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }

        public VegetarianMeal(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public void DisplayMealDetails()
        {
            Console.WriteLine($"[Vegetarian] {Name} - {Calories} kcal");
        }
    }

    class VeganMeal : IMealPlan
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }

        public VeganMeal(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public void DisplayMealDetails()
        {
            Console.WriteLine($"[Vegan] {Name} - {Calories} kcal");
        }
    }

    class KetoMeal : IMealPlan
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }

        public KetoMeal(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public void DisplayMealDetails()
        {
            Console.WriteLine($"[Keto] {Name} - {Calories} kcal");
        }
    }

    class HighProteinMeal : IMealPlan
    {
        public string Name { get; private set; }
        public int Calories { get; private set; }

        public HighProteinMeal(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public void DisplayMealDetails()
        {
            Console.WriteLine($"[High-Protein] {Name} - {Calories} kcal");
        }
    }

    // 🟢 Step 3: Implement Generic Meal Class
    class Meal<T> where T : IMealPlan
    {
        private List<T> mealList = new List<T>();

        public void AddMeal(T meal)
        {
            mealList.Add(meal);
            Console.WriteLine($"{meal.Name} added to the meal plan.");
        }

        public void DisplayAllMeals()
        {
            Console.WriteLine("\n--- Meal Plan ---");
            foreach (var meal in mealList)
            {
                meal.DisplayMealDetails();
            }
            Console.WriteLine("-----------------------------\n");
        }
    }

   
    class MealPlanner
    {
        public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
        {
            Console.WriteLine("\nGenerating Meal Plan...");
            meal.DisplayMealDetails();
            Console.WriteLine("Meal Plan Successfully Created!\n");
        }
    }
}
 
