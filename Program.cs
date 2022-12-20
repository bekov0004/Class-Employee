using Empoyee;

Employee employee1 = new Employee(15,"Anushervon","Bekov",2500);
Console.WriteLine($"Имя Фамилия работника: {employee1.GetName()}");
Console.WriteLine($"Эго зарплата с увеличеним процентом: {employee1.RaiseSalary(5)}");
Console.WriteLine($"Информатсия о {employee1.ToString()}");
Console.WriteLine($"Эго зарплата за 12 месяцев: {employee1.GetAnnalSalary()}");