namespace LibrairieConversionNote
{
    public static class ConversionAlphabetiqueToNote
    {
        public static string transform(string note)
        {
            switch (note)
            {
                case "A":
                    return "LA";
                    break;
                case "B":
                    return "SI";
                    break;
                case "C":
                    return "DO";
                    break;
                case "D":
                    return "RÉ";
                    break;
                case "E":
                    return "MI";
                    break;
                case "F":
                    return "FA";
                    break;
                case "G":
                    return "SOL";
                    break;
                default:
                    return "Entrée invalide";
                    break;
            }
        }
    }

}