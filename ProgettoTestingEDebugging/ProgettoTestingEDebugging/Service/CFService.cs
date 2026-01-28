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

    }

}
