namespace e_shift.utility;

public class PasswordUtility
{
    public static string HashPassword(string password)
    {
        try
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        catch (Exception)
        {
            throw new InvalidDataException("Error in hashing password");
        }
    }
        
    public static bool ReadHashPassword(string password, string hash)
    {
        try
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
        catch (Exception)
        {
            throw new InvalidDataException("Error in hashing password");
        }
    }
}