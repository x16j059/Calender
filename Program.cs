using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace カレンダー
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            Console.Write("{0}年{1}月\n",dateNow.Year,dateNow.Month);
            //現在の年月の1日を取得する
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1"));
            dateNow.year, dateNow.Month));
            DisplayCalendar(dateFirst);//カレンダーの表示
            Console.ReadLine;
            Console.ReadLine();           
        }
        //一か月分のカレンダーを画面に表示する
        //パラメータ
        //  dateFirst : 表示したい年月の1日を表すDateFirst
        static void DisplayCalendar(DateTime DateFirst)
        {
            int week;
            int month = DateFirst.Month;

            //曜日タイトルの表示
            Console.Write("--------------\n");
            Console.Write("日 月 火 水 木 金 土 日\n");

            //1日の開始位置まで空白を表示する
            for (week = 0; week < (int)DateFirst.DayOfWeek; week++)
                Console.Write("  ");
         
        

            //月の終わりの日まで1週刊ごとに日にちを表示する
            while (month == DateFirst.Month)
            {
                for (; week < 7 && month == DateFirst.Month; week++)
                    Console.Write("{0,2}", DateFirst.Day);
                DateFirst = DateFirst.AddDays(1);  //空白にする
            }
            Console.Write("\n");
            week = 0;
        }
    }
}
