namespace RotaAccessLayer
{
    public class Authentication
    {
        public bool AuthenticatePerson(int item)
        {
            if (item == 0)
            {
                return false;
            }
            else if (item > 5)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}