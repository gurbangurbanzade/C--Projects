//// tam eded------------------------------------------------------------
//int number = 5;
//Console.WriteLine(number);

//// kesr eded-----------------------------------------------------------
//float number2 = 12.5f;
//double number3 = 12.6;
//decimal number4 = 12.4m;
//Console.WriteLine(number2);
//Console.WriteLine(number3);
//Console.WriteLine(number4);

//// string--------------------------------------------------------------
//string name = "gurban gurbanzada";
//char simvol = 'a';
//Console.WriteLine(simvol);  
//Console.WriteLine(name);

//// boolean-------------------------------------------------------------
//bool result = true;


//// toplama emeliyyati--------------------------------------------------
//Console.Write("number1-");
//int number5 = int.Parse(Console.ReadLine());
//Console.Write("number2-");
//int number6 = int.Parse(Console.ReadLine());
//int sum = number5 + number6;
//Console.WriteLine($"cavab- {sum}");

// string----------------------------------------------------------------

//string name = "gurban";
//string surname = "gurbanzada";
//int age = 29;

//string str = $"my name is {name} {surname} , {age} years ";
//string str1= string.Format("may name is {0} {1} , {2} years", name, surname, age);
//Console.WriteLine(str);
//Console.WriteLine(str1);


// string methods
 
string msg = "Hello. My name is Gurban Gurbanzada";

 Console.WriteLine("length-"+msg.Length);
Console.WriteLine("lower case-"+msg.ToLower());
Console.WriteLine("upper case-" + msg.ToUpper());
Console.WriteLine("trim-" + msg.Trim());
Console.WriteLine("trimStart-" + msg.TrimStart());
Console.WriteLine("trimEnd-" + msg.TrimEnd());
Console.WriteLine("trimEnd-" + msg.TrimEnd());
Console.WriteLine("split-" + msg.Split()[2]);
Console.WriteLine("start-" + msg.StartsWith("Hello"));
Console.WriteLine("end-" + msg.EndsWith("Gurban"));
Console.WriteLine("Contains-" + msg.Contains("name"));
Console.WriteLine("indexof-" + msg.IndexOf("name"));



