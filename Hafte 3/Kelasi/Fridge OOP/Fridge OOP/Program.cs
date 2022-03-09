Fridge fridge1 = new Fridge("fridge1");
fridge1.OpenDoor();
fridge1.AddNewFood("apple", 50, 10);
fridge1.AddNewFood("orange", 60, 5);
fridge1.AddNewFood("banana", 100, 12);
fridge1.AddNewFood("apple", 100);
fridge1.AddOldFood("peach", 100);
fridge1.AddOldFood("banana", 5);
fridge1.PrintFoodList();
