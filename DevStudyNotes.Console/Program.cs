// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Digite o seu nome:");
// var nome = Console.ReadLine();

// Console.WriteLine("Hello, " + nome + "!");
// Console.WriteLine($"Hello, {nome}!");

// string nome = "LuisDev";
// int numberInt = 1;
// float numberFloat = 4.64f;
// double numberDouble = 3.5;
// decimal numberDecimal = 5.33m;
// char isStudentChar = 'y';
// bool isStudentBool = true;

// // Estruturas de Controle de Fluxo

// Console.WriteLine("Digite o score do time A:");
// var teamAScore = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o score do time B:");
// var teamBScore = int.Parse(Console.ReadLine());

// var scoreDifference = teamAScore - teamBScore;
// // Se a diferença der positiva, acima de zero, quer dizer que o A fez mais gols
// // Se a diferença for zero, houve empate
// // Se a diferença for negativa, o B fez mais gols

// Console.WriteLine("Utilizando if-else");

// if (scoreDifference > 0) {
//     Console.WriteLine("Time A ganhou.");
// } else if (scoreDifference == 0) {
//     Console.WriteLine("Empate.");
// } else {
//     Console.WriteLine("Time B ganhou.");
// }

// Console.WriteLine("Utilizando switch-case");

// switch (scoreDifference) {
//     case > 0:
//         Console.WriteLine("Time A ganhou.");
//         break;
//     case 0:
//         Console.WriteLine("Empate.");
//         break;
//     default:
//         Console.WriteLine("Time B ganhou.");
//         break;
// }

// string[] matchesResults = new string[3] { "A 3x1 B", "A 2x0 C", "A 1x1 D" };

// Console.WriteLine("Utilizando o While");

// var count = 0;

// while(count < matchesResults.Length) {
//     Console.WriteLine(matchesResults[count]);

//     count++;
// }

// Console.WriteLine("Utilizando o for");

// for (var i = 0; i < matchesResults.Length; i++) {
//     Console.WriteLine(matchesResults[i]);
// }

// Console.WriteLine("Utilizando o foreach");

// foreach (var result in matchesResults) {
//     Console.WriteLine(result);
// }

// Console.WriteLine("Utilizando o do-while");

// count = 0;

// do {
//     Console.WriteLine(matchesResults[count]);

//     count++;
// } while (count < matchesResults.Length);

// var phrase = "ASP.NET Core é um framework web com versão atual .NET 7";

// Console.WriteLine("Maiúscula: " + phrase.ToUpper());
// Console.WriteLine($"Minúscula: {phrase.ToLower()}");

// var substring = phrase.Substring(3, 4);
// var contains = phrase.Contains("ASP.NET");
// var startsWith = phrase.StartsWith("ASP");
// var endsWith = phrase.EndsWith(".NET 7");
// var indexOf = phrase.IndexOf(".NET");
// var lastIndexOf = phrase.LastIndexOf(".NET");

// Console.WriteLine($"Substring: {substring}");
// Console.WriteLine($"Contains: {contains}");
// Console.WriteLine($"StartsWith: {startsWith}");
// Console.WriteLine($"EndsWith: {endsWith}");
// Console.WriteLine($"IndexOf: {indexOf}");
// Console.WriteLine($"LastIndexOf: {lastIndexOf}");

// int[] grades = new int[10] { 7, 5, 1, 6, 1, 8, 2, 9, 9, 10 };
// List<int> gradesList = new List<int> { 7, 5, 1, 6, 1, 8, 2, 9, 9, 10 };
// var gradesArrayAsList = grades.ToList();
// var gradesListAsArray = gradesList.ToArray();

// var single = grades.Single(g => g == 5);
// var first = grades.First(g => g == 1);
// var where = grades.Where(g => g >= 6);
// var any = grades.Any(g => g == 0);
// var orderedGrades = grades.OrderBy(g => g);
// var sum = grades.Sum();
// var min = grades.Min();
// var max = grades.Max();
// var avg = grades.Average();
// var count = grades.Count();

// Herança 
// Promover Reusabilidade de dados e comportamentos
// Classe que herda de outra é a classe filha, e a classe herdada é a classe mãe

// Polimorfismo
// Permite que classes que herdem da mesma, elas tenham implementações diferentes
// de um comportamento herdado

var publicStudyNote = new PublicStudyNote("Nota AZ-204", "Notas de estudo", "Azure");
var privateStudyNote = new PrivateStudyNote("Nota AZ-900", "Notas de estudo", "Azure", new List<string> { "luis@mail.com", "dev@mail.com" });

publicStudyNote.AddLike();
publicStudyNote.AddDislike();

var notes = new List<StudyNote> { publicStudyNote, privateStudyNote };

foreach (var note in notes) {
    note.PrintFullDescription();
}

abstract class StudyNote {
    protected StudyNote(string title, string description, string category)
    {
        Title = title;
        Description = description;
        Category = category;
    }

    public string Title { get; protected set;}
    public string Description { get; protected set; }
    public string Category { get; protected set; }

    public abstract void PrintFullDescription();
}

class PublicStudyNote : StudyNote
{
    public PublicStudyNote(string title, string description, string category) : base(title, description, category)
    {
    }

    public int Likes { get; private set; }
    public int Dislikes { get; private set; }

    public void AddLike() {
        Likes++;
    }

    public void AddDislike() {
        Dislikes++;
    }
    public override void PrintFullDescription()
    {
        Console.WriteLine($"{Title}, {Description}, {Category}, {Likes} Likes, {Dislikes} Dislikes.");
    }
}

class PrivateStudyNote : StudyNote
{
    public PrivateStudyNote(string title, string description, string category, List<string> sharedWith) : base(title, description, category)
    {
        SharedWith = sharedWith ?? new List<string>();
    }

    public List<string> SharedWith { get; private set; }

    public void ShareWith(string email) {
        SharedWith.Add(email);
    }

    public override void PrintFullDescription()
    {
        Console.WriteLine($"{Title}, {Description}, {Category}, SharedWith: {string.Join(' ', SharedWith)}");
    }
}
