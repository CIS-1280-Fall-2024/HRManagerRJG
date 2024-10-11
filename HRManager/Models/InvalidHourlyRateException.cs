namespace HRManager.Models
{
    public class InvalidHourlyRateException:Exception
    {
        public InvalidHourlyRateException():base("Invalide hourly rate! It must be a postitive number.")
        {            
        }
    }
}
