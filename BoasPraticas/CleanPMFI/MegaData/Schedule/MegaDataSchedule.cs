using Application.Interfaces;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Infrastructure.Context;
using MegaData.Controllers;
using System;
using System.Threading;
namespace MegaData.Schedule
{
    public class MegaDataSchedule
    {
        private readonly MegaData_NFSEController _controller;

        public MegaDataSchedule(MegaData_NFSEController controller)
        {
            _controller = controller;
        }

        private Timer _timer;
        private readonly string cronExpression = "0 12 * * *"; // Expressão cron para 12:00 (horário de 24 horas)
        public void Start()
        {


            // Calcule o próximo horário de execução com base na expressão cron
           //// DateTime now = DateTime.Now;
           //// DateTime nextRunTime = NCrontab.CrontabSchedule.Parse(cronExpression).GetNextOccurrence(now);

            // Calcule o tempo restante até o próximo horário de execução
           //// TimeSpan delay = nextRunTime - now;

            //_timer = new Timer(DoWork, null, delay, TimeSpan.FromHours(24)); // Executa a cada 24 horas
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(1)); // Executa a cada 1 minutos

        }
            

        private void DoWork(object state)
        {
            // Coloque sua lógica de tarefa aqui
           // MegaData_NFSEController megaData_NFSEController = (MegaData_NFSEController)state;
            MegaData_NFSE megaData_NFSE = new MegaData_NFSE() { 
                DataInicioPeriodo = DateTime.Now.AddMonths(-2),
                DataFinalPeriodo = DateTime.Now.AddMonths(-1)
            };
            //megaData_NFSEController.Create(megaData_NFSE);

            // Agende a próxima execução
            //// DateTime now = DateTime.Now;
            //// DateTime nextRunTime = NCrontab.CrontabSchedule.Parse(cronExpression).GetNextOccurrence(now);
            //// TimeSpan delay = nextRunTime - now;
            /////_timer.Change(delay, TimeSpan.FromHours(24));
           // _timer.Change(1,  TimeSpan.FromMinutes(1));


            Console.WriteLine("dddddddddddddddd");         // Coloque sua lógica de tarefa aqui;


        }
    }
}
