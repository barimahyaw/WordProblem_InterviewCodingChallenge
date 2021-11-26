namespace WordProblem_InterviewCoding
{
    public class K_th_Character_of_Decrypted_String
    {
        public static char EncodedChar(string str, int k)
        {
            string expand = "", temp = "";
            int freq = 0;

            for(int i = 0; i < str.Length;)
            {
                temp = "";
                freq = 0;

                while (i < str.Length && str[i] >= 'a' && str[i] <= 'z')
                {
                    temp += str[i];
                    i++;
                }

                while(i<str.Length && str[i] >='1' && str[i] <= '9')
                {
                    freq = freq * 10 + str[i] - '0';
                    i++;
                }

                for(int j=1; j <= freq; i++)
                {
                    expand += temp;
                }
            }
            if (freq == 0)
            {
                expand += temp;
            }

            return expand[k - 1];
        }
    }
}
