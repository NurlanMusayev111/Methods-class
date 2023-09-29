using Models_methods;
using System.Net;
using System.Xml.Linq;



//static Employee[] getUsersData()
//{
//    Employee employee1 = new Employee()
//    {
//        id = 1,
//        name = "Nurlan",
//        surname = "Musayev",
//        address = "Nerimanov",
//        email = "nurlan@mail.com",
//        age = 21
//    };


//    Employee employee2 = new Employee()
//    {
//        id = 2,
//        name = "Ramin",
//        surname = "Mahmudov",
//        address = "Bineqedi",
//        email = "ramin@mail.com",
//        age = 27
//    };


//    Employee employee3 = new Employee()
//    {
//        id = 3,
//        name = "Rufet",
//        surname = "Nesibov",
//        address = "Qazax",
//        email = "rufat@mail.com",
//        age = 25
//    };


//    Employee employee4 = new Employee()
//    {
//        id = 4,
//        name = "Zaur",
//        surname = "Ehmedov",
//        address = "Baki",
//        email = "zaur@mail.com",
//        age = 35
//    };


//    Employee[] employees = { employee1, employee2, employee3, employee4 };

//    return employees;

//};


//1)  Yashi methoda parametr kimi gelen yashdan boyuk olan employee -lerin  siyahisini qaytaran method


//static void ageOfCompar(int age)
//{
//    Employee[] employees = getUsersData();

//    var result = Array.FindAll(employees, x => age > age);

//    foreach (var item in result)
//    {
//        Console.WriteLine(item.name + " " + item.surname);

//    }
//}

//ageOfCompar(25);


//2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method


//static int getCountAge()
//{
//    int count = 0;

//    Employee[] employees = getUsersData();

//    foreach(Employee employee in employees)
//    {
//        if (employee.age >20 && employee.age<30)
//        {
//            count++;
//        }

//    }

//    return count;
//}

//Console.WriteLine(getCountAge());







//3)  Butun Emloyeelerin yashlarinin cemini qaytaran method


//static int sumOfAge()
//{
//    int sum = 0;

//    Employee[] employees = getUsersData();

//     for(int i = 0; i < employees.Length; i++)
//    {
//        sum += employees[i].age;
//    }

//    return sum;
//}


//Console.WriteLine(sumOfAge());




//4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method


//----------------------------------------------------------------












//1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin




