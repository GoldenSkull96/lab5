using lab_5;

var engeneer = new Engineer(10000, 3, 15, "Vasya");
var mechanic = new Mechanic(10000, 3, 15, "Petya");
var architecturalEngineer = new ArchitecturalEngineer(10000, 3, 15, "Valera");
var Workers = new List<Work>() {engeneer, mechanic, architecturalEngineer };
var director = new Director(150000, 15, 50, Workers);
var manager = new Manager(50000, 10, 30, Workers);
manager.PrintInfo();
engeneer.PrintInfo();
mechanic.product();