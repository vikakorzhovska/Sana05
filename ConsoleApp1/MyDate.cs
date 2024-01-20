using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyDate
    {
        protected int year;
        protected int month;
        protected int day;
        protected int hours;
        protected int minutes;

        public MyDate()
        {
            year = 1000;
            month = 10;
            day = 10;
            hours = 10;
            minutes = 10;
        }
        public MyDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hours = hours;
            this.minutes = minutes;
        }
        public MyDate(MyDate other)
        {
            this.year = other.year;
            this.month = other.month;
            this.day = other.day;
            this.hours = other.hours;
            this.minutes = other.minutes;
        }
        public int getYear()
        {
            return year;
        }
        public int getMonth()
        {
            return month;
        }
        public int getDay()
        {
            return day;
        }
        public int getHours()
        {
            return hours;
        }
        public int getMinutes()
        {
            return minutes;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public void setMonth(int month)
        {
            if (month > 0 && month <= 12)
                this.month = month;
            else
                throw new Exception("Немає такого місяця");
        }
        public void setDay(int day)
        {
            if (day > 0 && day <= 31)
                this.day = day;
            else
                throw new Exception("Немає такого дня");
        }
        public void setHours(int hours)
        {
            if (hours >= 0 && hours <= 23)
                this.hours = hours;
            else
                throw new Exception("Не правильно введене значення");
        }
        public void setMinutes(int minutes)
        {
            if (minutes >= 0 && minutes <= 59)
                this.minutes = minutes;
            else
                throw new Exception("Не правильно введене значення");
        }
    }
}
