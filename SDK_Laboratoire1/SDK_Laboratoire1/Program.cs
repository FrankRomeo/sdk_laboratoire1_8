//Travail presenté par : Andres Torres Rodriguez
//                       Carlos Amat y León Peralta
//                       François Ouellette-Meloche

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
            string noteRetour = LibrairieConversionNote.ConversionAlphabetiqueToNote.transform(note.ToUpper());
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}
