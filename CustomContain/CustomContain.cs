namespace CustomContain;

public static class CustomContain
{
    
    public static bool Contain(this string a, string b)
    {
        if (a == null || b == null)
        {
            return false;
        }

        a = a.ToLower();
        b = b.ToLower();

        
        for (int i = 0; i <= a.Length - b.Length; i++)
        {
            int j;
            
            for ( j = 0; j < b.Length; j++)
            {
                if (a[i + j] != b[j])
                {
                    break;
                }
            }

            if (j == b.Length)
            {
                return true;
            }
        }

        return false;
    }
}
    


