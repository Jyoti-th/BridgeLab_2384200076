using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{
    class CallingAllClass
    {
        //Smart Warehouse Management System
        public void CallingWarehouse()
        {
            Storage<Electronics> electronicItem = new Storage<Electronics>();
            electronicItem.Add(new Electronics("Laptop", 70000));
            electronicItem.Add(new Electronics("SmartPhone", 20000));
            electronicItem.Add(new Electronics("Iron", 500));
            electronicItem.Add(new Electronics("Mixer", 1500));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");


            Storage<Groceries> groceryItem = new Storage<Groceries>();
            groceryItem.Add(new Groceries("Rice", 200));
            groceryItem.Add(new Groceries("Pulse", 100));
            groceryItem.Add(new Groceries("Sugar", 50));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");

            Storage<Furniture> furnitureItem = new Storage<Furniture>();
            furnitureItem.Add(new Furniture("Chair", 1000));
            furnitureItem.Add(new Furniture("Table", 2300));
            furnitureItem.Add(new Furniture("Sofa", 15000));
            furnitureItem.Add(new Furniture("Bed", 35000));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n");

            electronicItem.DisplayAllItems();
            groceryItem.DisplayAllItems();
            furnitureItem.DisplayAllItems();
        }

        //Dynamic Online Marketplace
        public void CallingOnlineMarketplace()
        {
            BookCategory bookCategory = new BookCategory();
            ClothingCategory clothingCategory = new ClothingCategory();


            Product<BookCategory> book = new Product<BookCategory>("C# Programming", 1000, bookCategory);
            Product<ClothingCategory> shirt = new Product<ClothingCategory>("Formal Shirt", 2000, clothingCategory);


            book.DisplayInfo();
            shirt.DisplayInfo();


            DiscountManager.ApplyDiscount(book, 10);
            DiscountManager.ApplyDiscount(shirt, 15);


            book.DisplayInfo();
            shirt.DisplayInfo();
        }

        //Multi-Level University Course Management System
        public void CallingCourse()
        {
            Course<ExamCourse> examCourses = new Course<ExamCourse>();
            examCourses.Add(new ExamCourse("Data Structures", 4));
            examCourses.Add(new ExamCourse("Operating Systems", 3));

            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
            assignmentCourses.Add(new AssignmentCourse("Web Development", 3));
            assignmentCourses.Add(new AssignmentCourse("Machine Learning", 4));

            examCourses.DisplayAllCourses();
            assignmentCourses.DisplayAllCourses();
        }

        //Personalized Meal Plan Generator

        public void CallingMealPlan()
        {
            // Creating Vegetarian Meal Plan
            Meal<VegetarianMeal> vegetarianMeals = new Meal<VegetarianMeal>();
            vegetarianMeals.AddMeal(new VegetarianMeal("Paneer Tikka", 350));
            vegetarianMeals.AddMeal(new VegetarianMeal("Vegetable Biryani", 500));

            // Creating Vegan Meal Plan
            Meal<VeganMeal> veganMeals = new Meal<VeganMeal>();
            veganMeals.AddMeal(new VeganMeal("Vegan Salad", 200));
            veganMeals.AddMeal(new VeganMeal("Tofu Stir-Fry", 300));

            // Creating Keto Meal Plan
            Meal<KetoMeal> ketoMeals = new Meal<KetoMeal>();
            ketoMeals.AddMeal(new KetoMeal("Grilled Chicken", 400));
            ketoMeals.AddMeal(new KetoMeal("Avocado Omelette", 450));

            // Creating High-Protein Meal Plan
            Meal<HighProteinMeal> highProteinMeals = new Meal<HighProteinMeal>();
            highProteinMeals.AddMeal(new HighProteinMeal("Protein Shake", 250));
            highProteinMeals.AddMeal(new HighProteinMeal("Grilled Fish", 500));

            // Display all meal plans
            vegetarianMeals.DisplayAllMeals();
            veganMeals.DisplayAllMeals();
            ketoMeals.DisplayAllMeals();
            highProteinMeals.DisplayAllMeals();

            // Generate a meal plan dynamically using the generic method
            MealPlanner.GenerateMealPlan(new VeganMeal("Vegan Burger", 350));

        }

        // AI-Driven Resume Screening System
        public void CalingResume()
        {
            // Creating Job Roles
            SoftwareEngineer softwareEng = new SoftwareEngineer();
            DataScientist dataSci = new DataScientist();

            // Creating Resumes
            Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Alice", 5, softwareEng);
            Resume<DataScientist> resume2 = new Resume<DataScientist>("Bob", 3, dataSci);

            // Resume Screening Pipeline
            ResumeScreening screeningSystem = new ResumeScreening();
            screeningSystem.AddResume(resume1);
            screeningSystem.AddResume(resume2);

            // Display Screening Results
            screeningSystem.DisplayScreeningResults();
        }

    }
}


