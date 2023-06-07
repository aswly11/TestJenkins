namespace TestJenkins
{
    public class TestWorker : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
           
            Timer timer = new Timer(testTimer, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

            return  Task.CompletedTask;
        }

        private void testTimer(object? state)
        {
            Console.WriteLine("Ahmed Test"+DateTime.Now.ToString());
        }

     
    }
}
