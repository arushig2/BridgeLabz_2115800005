using System;
using System.Collections.Generic;

interface IMealPlan
{
    string Name { get; }
    int Calories { get; }
    List<string> Ingredients { get; }

    void DisplayMealInfo();
}

class VegetarianMeal : IMealPlan
{
    public string Name { get; }
    public int Calories { get; }
    public List<string> Ingredients { get; }

    public VegetarianMeal(string name, int calories, List<string> ingredients)
    {
        Name = name;
        Calories = calories;
        Ingredients = ingredients;
    }

    public void DisplayMealInfo()
    {
        Console.WriteLine($"Vegetarian: {Name} - {Calories} kcal");
        Console.WriteLine($"Ingredients: {string.Join(", ", Ingredients)}");
    }
}

class VeganMeal : IMealPlan
{
    public string Name { get; }
    public int Calories { get; }
    public List<string> Ingredients { get; }

    public VeganMeal(string name, int calories, List<string> ingredients)
    {
        Name = name;
        Calories = calories;
        Ingredients = ingredients;
    }

    public void DisplayMealInfo()
    {
        Console.WriteLine($"Vegan: {Name} - {Calories} kcal");
        Console.WriteLine($"Ingredients: {string.Join(", ", Ingredients)}");
    }
}

class KetoMeal : IMealPlan
{
    public string Name { get; }
    public int Calories { get; }
    public List<string> Ingredients { get; }

    public KetoMeal(string name, int calories, List<string> ingredients)
    {
        Name = name;
        Calories = calories;
        Ingredients = ingredients;
    }

    public void DisplayMealInfo()
    {
        Console.WriteLine($"Keto: {Name} - {Calories} kcal");
        Console.WriteLine($"Ingredients: {string.Join(", ", Ingredients)}");
    }
}

// Generic class to represent a meal
class Meal<T> where T : IMealPlan
{
    public T MealType { get; }

    public Meal(T meal)
    {
        MealType = meal;
    }

    public void ShowMeal()
    {
        MealType.DisplayMealInfo();
    }
}

class MealPlanGenerator
{
    private List<IMealPlan> mealPlans = new List<IMealPlan>();

    public void AddMeal<T>(Meal<T> meal) where T : IMealPlan
    {
        mealPlans.Add(meal.MealType);
    }

    public void DisplayAllMeals()
    {
        Console.WriteLine("\nPersonalized Meal Plan:");
        foreach (var meal in mealPlans)
        {
            meal.DisplayMealInfo();
        }
    }

    public static bool ValidateMeal<T>(Meal<T> meal, int maxCalories) where T : IMealPlan
    {
        return meal.MealType.Calories <= maxCalories;
    }
}

class Program
{
    static void Main()
    {
        MealPlanGenerator mealPlan = new MealPlanGenerator();

        var vegMeal = new Meal<VegetarianMeal>(new VegetarianMeal("Paneer Curry", 500, new List<string> { "Paneer", "Tomato", "Spices" }));
        var veganMeal = new Meal<VeganMeal>(new VeganMeal("Tofu Salad", 350, new List<string> { "Tofu", "Lettuce", "Olive Oil" }));
        var ketoMeal = new Meal<KetoMeal>(new KetoMeal("Grilled Chicken", 600, new List<string> { "Chicken", "Butter", "Garlic" }));

        mealPlan.AddMeal(vegMeal);
        mealPlan.AddMeal(veganMeal);
        mealPlan.AddMeal(ketoMeal);

        mealPlan.DisplayAllMeals();

        Console.WriteLine($"\nIs '{vegMeal.MealType.Name}' within 400 kcal? {MealPlanGenerator.ValidateMeal(vegMeal, 400)}");
        Console.WriteLine($"Is '{veganMeal.MealType.Name}' within 400 kcal? {MealPlanGenerator.ValidateMeal(veganMeal, 400)}");
    }
}
