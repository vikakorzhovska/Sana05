using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Airplane
    {
        protected string StartSity;
        protected string FinishSity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

        public Airplane()
        {
            StartSity = "";
            FinishSity = "";
            StartDate = new MyDate();
            FinishDate = new MyDate(); 
        }
        public Airplane(string startSity, string finishSity)
        {
            this.StartSity = startSity;
            this.FinishSity = finishSity;
        } 
        public Airplane(string startSity, string finishSity, MyDate startDate, MyDate finishDate)
        {
            this.StartSity = startSity;
            this.FinishSity = finishSity;
            this.StartDate = new MyDate (startDate);
            this.FinishDate = new MyDate (finishDate);
        }
        public Airplane(Airplane other)
        {
            this.StartSity = other.StartSity;
            this.FinishSity = other.FinishSity;
            this.StartDate = new MyDate (other.StartDate);
            this.FinishDate = new MyDate (other.FinishDate);
        }
        public string GetStartSity()
        {
            return StartSity;
        }
        public void SetStartSity(string startSity)
        {
            this.StartSity = startSity;
        }
        public string GetFinishSity()
        {
            return FinishSity;
        }
        public void SetFinishSity(string finishSity)
        {
            this.FinishSity = finishSity;
        }
        public MyDate GetStartDate()
        {
            return StartDate;
        }
        public void SetStartDate(MyDate startDate)
        {
            this.StartDate = new MyDate (startDate);
        }
        public MyDate GetFinishDate()
        {
            return FinishDate;
        }
        public void SetFinishDate(MyDate finishDate)
        {
            this.FinishDate = new MyDate (finishDate);
        }
        public int GetTotalTime()
        {
            int totalTime = (FinishDate.getYear() - StartDate.getYear()) * 365 * 24 * 60 +
                               (FinishDate.getMonth() - StartDate.getMonth()) * 30 * 24 * 60 +
                               (FinishDate.getDay() - StartDate.getDay()) * 24 * 60 +
                               (FinishDate.getHours() - StartDate.getHours()) * 60 +
                               (FinishDate.getMinutes() - StartDate.getMinutes());

            return totalTime;
        }
        public bool IsArrivingToday()
        {
            return StartDate.getYear() == FinishDate.getYear()
            && StartDate.getMonth() == FinishDate.getMonth()
            && StartDate.getDay() == FinishDate.getDay();
        }
    }
}
