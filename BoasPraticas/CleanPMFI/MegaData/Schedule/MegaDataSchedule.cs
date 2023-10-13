using System;
using System.Threading;
namespace MegaData.Schedule
{
    public class MegaDataSchedule
    {
        private Timer _timer;
        private readonly string cronExpression = "0 12 * * *"; // Expressão cron para 12:00 (horário de 24 horas)
        public void Start()
        {


            // Calcule o próximo horário de execução com base na expressão cron
            DateTime now = DateTime.Now;
            DateTime nextRunTime = NCrontab.CrontabSchedule.Parse(cronExpression).GetNextOccurrence(now);

            // Calcule o tempo restante até o próximo horário de execução
            TimeSpan delay = nextRunTime - now;

            //_timer = new Timer(DoWork, null, delay, TimeSpan.FromHours(24)); // Executa a cada 24 horas
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(1)); // Executa a cada 1 minutos

        }
        public MegaDataSchedule() { }

        private void DoWork(object state)
        {



            // Coloque sua lógica de tarefa aqui

            // Agende a próxima execução
            DateTime now = DateTime.Now;
            DateTime nextRunTime = NCrontab.CrontabSchedule.Parse(cronExpression).GetNextOccurrence(now);
            TimeSpan delay = nextRunTime - now;
            _timer.Change(delay, TimeSpan.FromHours(24));
            
            
            Console.WriteLine("dddddddddddddddd");         // Coloque sua lógica de tarefa aqui;


        }
    }
}
