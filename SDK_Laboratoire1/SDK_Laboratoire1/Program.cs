using LibrairieConversationNote;

while (true)
{
    Console.Write("Type de conversion à faire : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //On demande en boucle la conversion 
        while (true)
        {
            Console.Write("Conversion à faire : ");
            var note = Console.ReadLine();
            string noteRetour = LibrairieConversationNote.ConversionAlphabetiqueToNote.transform(note.ToUpper());
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}
