namespace Quidjibo.Models
{
    public class Cron
    {
        public string Expression { get; set; }

        public Cron(string expression)
        {
            Expression = expression;
        }
    }
}