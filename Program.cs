{
//Her laves en liste af data -  List<string> laver her en liste af tekststregne, en samling af flere værdier 
    List<string> parts = ["Hydraulic pump", "PLC module", "Servo motor"];

//Her er skrevet det fra opgaven, som bliver beskrevet i problemet. - const string bliver brugt som en slags konstant.     
    const string AssistantGreeting = "Hej, Welcome to the spare parts inventory";
    const string AssistantQuestion = "Which part do you need?";
    const string AssistantReplyPositive = "I've got {0} here for you - Buy";
    const string AssistantReplyNegative = "I am afraid we cont have any {0} in the inventory system.";
    const string AssistantReplyNumberOfParts = "We have {0} parts";

//Her samles alle spørgsmålene ovenfor i en liste.     
    List<string> userQuestions =
    [
        "Do you acutally have any parts?",
        "Is there anything in stock at all?"
    ];

//Program 

//Udskrivning af den tekst som er defineret ovenfor 
    Console.WriteLine(AssistantGreeting);
    bool partAvailable = false;     //Her laves en bool variable - Her udskrives false, idet jeg endnu ikke har fundet part på lager. 
    while (!partAvailable)          //While bruges tl at danne et loop - Loopet/løkken kører indtil brugeren skriver navnet på en af de parts der er på lager. 
    {
        //Her skrives spørgsmålet, som er defineret ovenfor ud - der bliver læst det brugeren skriver ind og varaiblen bliver glemt. Yderligere tjekkes det som brugeren skrev om det matcher parts. 
        Console.Write(AssistantQuestion + " ");
        var line = Console.ReadLine();
        if (parts.Contains(line))
        {
            Console.WriteLine(String.Format(AssistantReplyPositive, line));
            partAvailable = true;
        }
        else if (userQuestions.Contains(line))
        {
            Console.WriteLine($"""
                               {String.Format(AssistantReplyNumberOfParts, parts.Count)}
                               {string.Join("\n", parts)}
                               """);
        }
        else
            Console.WriteLine(String.Format(AssistantReplyNegative, line));
    }
}    