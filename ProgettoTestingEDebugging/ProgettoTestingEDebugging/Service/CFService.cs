namespace ProgettoTestingEDebugging.Service
{
    public class CFService
    {
        public bool SeVocale(char c)
        {
            char[] vocali = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < vocali.Length; i++)
            {
                if (c == vocali[i])
                {
                    return true;
                }
            }

            return false;
        }
        public bool SeConsonante(char c)
        {
            char[] consonante = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < consonante.Length; i++)
            {
                if (c == consonante[i])
                {
                    return true;
                }
            }

            return false;
        }
      
        public string CodNome(string s)
        {
            string vocali = "";
            string consonanti = "";
            foreach (char c in s)
            {
                if (SeVocale(c))
                {
                    vocali += c;
                }
                else if (char.IsLetter(c))
                {
                    consonanti += c;
                }
            }
            char[] consonantiArray = consonanti.ToCharArray();
            char[] vocaliArray = vocali.ToCharArray();
            string risultato = "";
            if (consonantiArray.Length >= 4)
            {
                risultato += consonantiArray[0];
                risultato += consonantiArray[2];
                risultato += consonantiArray[3];
            }
            else
            {
                for (int i = 0; i < consonantiArray.Length && risultato.Length < 3; i++)
                    risultato += consonantiArray[i];
            }
            for (int i = 0; i < vocaliArray.Length && risultato.Length < 3; i++)
                risultato += vocaliArray[i];
            while (risultato.Length < 3)
                risultato += "X";

            return risultato;
        }

    }

}
