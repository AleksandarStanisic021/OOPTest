using OOPTest;

Farm farm=new Farm();
farm.Name = "Kluks farm";

Chicken chicken = new Chicken()
{
    Name = "Alfred",
    Age=   1
};

Chicken ruster = new Chicken()
{
    Name = "Sofronie",
    Age = 2
};


Cat cat = new Cat()
{
    Name = "Tom",
    Age = 1
};

Dog dog = new Dog()
{
    Name = "Wolfy",
    Age = 3
};

chicken.Walk();
cat.Walk();
dog.Walk();


chicken.RunAway(cat);
ruster.RunAway(cat);

cat.RunAway(dog);
dog.RunAway(chicken);



dog.Speak();
chicken.Speak();
cat.Speak();

farm.List.Add(cat);
farm.List.Add(dog);
farm.List.Add(chicken);
farm.List.Add(ruster);

Console.WriteLine("We have "+farm.List.Count+ " Animals");

farm.ReadList();




Console.WriteLine("*****");
Console.ReadLine();
