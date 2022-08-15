using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static timesheet_calculation.TimesheetCalculator;

namespace timesheet_calculation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*var result = Db.UserDailyTimesheetModels.ToList();
            var result1 = result[0];

            var uid = result[0].UserId;
            Console.WriteLine(uid);

            var allWeekDayDateTimeFormat = Calculator.AllDatesInMonth(2022, 5).Where(i => i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday);
            var allSaturdayDateTimeFormat = Calculator.AllDatesInMonth(2022, 5).Where(i => i.DayOfWeek == DayOfWeek.Saturday);

            List<int> allWeekDay = new List<int>();
            List<int> allSaturday = new List<int>();
            foreach (var item in allWeekDayDateTimeFormat)
            {
                allWeekDay.Add(item.Day);
            }

            foreach (var item in allSaturdayDateTimeFormat)
            {
                allSaturday.Add(item.Day);
            }
            if (false)
            {
                var evens = allSaturday.Where((item, index) => index % 2 == 0);
                allWeekDay.AddRange(evens);
                foreach (var item in allWeekDay)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                var odds = allSaturday.Where((item, index) => index % 2 != 0);
                allWeekDay.AddRange(odds);
                foreach (var item in allWeekDay)
                {
                    Console.WriteLine(item);
                }
            }*/

            ///////////////////////////////////////////////////////////////
            ///
            //var guid123 = Guid.Parse("122f4e8c-8cf7-4d9f-b980-6f7708087fba");
            //var userHistory = Db.UserDailyTimesheetModels.Where(x => x.UserId == guid123);
            //var checkIn = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckInTime).ToList();
            //var result = checkIn[0];
            //DateTime d1 = new DateTime(2022, 8, 12, 8, 30, 0);
            //var something = DateTime.Compare(result, d1);
            //Console.WriteLine(something);
            //var something1 = result.Subtract(d1);
            //Console.WriteLine(something1);
            //Console.WriteLine(result);

            //writesomething to database ............
            ///////////////////////////////////////////////////////////////
            ///
            //var checkIn = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckInTime).ToList();
            //var checkOut = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckOutTime).ToList();

            //DateTime d1 = new DateTime(2022, 8, 12, 12, 0, 0);
            //DateTime d2 = new DateTime(2022, 8, 12, 13, 30, 0);
            //var result1 = d1.Subtract(checkIn[0]);
            //var result1Hour = result1.Hours;
            //var result1HourConvertToSecond = result1Hour * 3600;

            //var result1Minute = result1.Minutes;
            //var result1MinuteConverToSecond = result1Minute * 60;
            //var result1Second = result1.Seconds;

            //var finalResult = result1HourConvertToSecond + result1MinuteConverToSecond + result1Second;
            //Console.Write(finalResult);
            //var result2 = checkOut[0].Subtract(d2);
            //var result2Hour = result2.Hours;
            //var result2Minute = result2.Minutes;
            //var result2Second = result2.Seconds;
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            //Console.WriteLine(result1e);

            // write to database ................

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //Console.WriteLine(result[0].ToString());
            /* CÔNG VIỆC CẦN LÀM
             * Cài đặt EF Core 5.0 vào solution này
             * Kết nối vào database PostgreSQL
             * Tạo một table timesheet như dưới đây
             * CREATE TABLE public."in_TimeSheet" (
                "Id" uuid NOT NULL,
                "CheckInTime" timestamp NULL,
                "CheckOutTime" timestamp NULL,
                "UserId" uuid NOT NULL,
                CONSTRAINT "PK_in_TimeSheet" PRIMARY KEY ("Id")
            );
            * Trong đó
            * - CheckinTime là thời gian một user check-in vào hệ thống (bắt đầu làm việc)
            * - CheckoutTime là thời gian một user checkout khỏi hệ thống (kết thúc làm việc)
            *
            *
            */
            /////////////////////////////////////////////////////////////////////////
            Task2DbContext Db = new Task2DbContext();
            var guid123 = Guid.Parse("e95e67df-ce56-44f8-addd-f197ebaf4e6c");
            TimesheetCalculator user1 = new TimesheetCalculator(true);

            // tinh' cac' ngay' phai lam viec
            var allWorkDay = user1.CalculateAllWorkDay(2022, 5).ToList();
            foreach (var item in allWorkDay)
            {
                Console.WriteLine(item);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            /*      var checkIn = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckInTime).ToList();
                  var result = checkIn[0];
                  DateTime d3 = new DateTime(2022, 5, 12, 8, 40, 0);
                  var something = DateTime.Compare((DateTime)result, d3);
                  Console.WriteLine(something);
                  if (something < 0)
                  {
                      var writeToDatbase = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).ToList();
                      writeToDatbase[0].IsLate = true;
                  }
                  else
                  {
                      var writeToDatbase = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).ToList();
                      writeToDatbase[0].IsLate = false;
                  }*/

            /*    var something1 = result.Subtract(d3);
                Console.WriteLine(something1);
                Console.WriteLine(result);*/

            /////////////////////////////////////////////////////////////////////////
            ///
            /*var checkIn = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckInTime).ToList();

            var checkOut = Db.UserDailyTimesheetModels.Where(x => x.Day == 12 && x.Month == 5 && x.Year == 2022 && x.UserId == guid123).Select(x => x.CheckOutTime).ToList();

            DateTime d1 = new DateTime(2022, 8, 12, 12, 0, 0);
            DateTime d2 = new DateTime(2022, 8, 12, 13, 30, 0);
            var result1 = d1.Subtract((DateTime)checkIn[0]);
            var result1Hour = result1.Hours;
            var result1HourConvertToSecond = result1Hour * 3600;

            var result1Minute = result1.Minutes;
            var result1MinuteConverToSecond = result1Minute * 60;
            var result1Second = result1.Seconds;

            var result1Final = result1HourConvertToSecond + result1MinuteConverToSecond + result1Second;

            DateTime checkOutUpdate = (DateTime)checkOut[0];

            var result2 = checkOutUpdate.Subtract(d2);
            var result2Hour = result2.Hours;
            var result2HourConvertToSecond = result1Hour * 3600;

            var result2Minute = result2.Minutes;
            var result2MinuteConverToSecond = result1Minute * 60;
            var result2Second = result2.Seconds;

            var result2Final = result2HourConvertToSecond + result2MinuteConverToSecond + result2Second;

            var finalResult = result1Final + result2Final;

            Console.WriteLine(finalResult);*/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ///
            ///
            ///
            ///

            var totalWorkDayPossible = allWorkDay.Count;

            var allWorkDayReal = Db.UserDailyTimesheetModels.Where(x => x.Month == 5 && x.Year == 2022 && x.UserId == guid123).ToList();

            // check totalWorkDayPossible va' allWorkDay.Count

            foreach (var item in allWorkDay)
            {
                var someVariable = Db.UserDailyTimesheetModels.Where(x => x.Month == 5 && x.Year == 2022 && x.UserId == guid123 && x.Day == item)/*.Select(i => i.Day == item)*/.ToList();
                if (someVariable.Count == 0)
                    continue;
                if (someVariable[0].CheckInTime == null)
                {
                    someVariable[0].Status = "absent";
                    Db.SaveChanges();
                }
                else if (someVariable[0].CheckOutTime == null)
                {
                    someVariable[0].Status = "Inprocess";
                    Db.SaveChanges();
                }
                /*  else if (finalResult < 28800)
                  {
                      someVariable[0].Status = "INCOMPLETE";
                      Db.SaveChanges();
                  }*/
                else // do something
                {
                    Console.WriteLine("VALID");
                }

                Console.WriteLine(someVariable[0].UserId);
                Console.ReadKey();
            }

            // ket hop voi month, year, boolsatruday se tinh het duoc workday
            // count workday
            // query tung ngay ket hop voi month, year ra 1 list count list do' neu' = count workday thi' ok
            // neu' it' hon thi' => ngay nghi?
        }
    }

    public class UserMonthlyTimesheetModel
    {
        public Guid UserId { get; set; }
        public int TotalWorkingHours { get; set; }
        public int TotalActualWorkingHours { get; set; }
        public List<UserDailyTimesheetModel> DailyTimesheets { get; set; }
    }

    public class TimesheetCalculator
    {
        private bool isFirstSaturdayWorking = false;

        public TimesheetCalculator(bool isFirstSaturdayWorking)
        {
            this.isFirstSaturdayWorking = isFirstSaturdayWorking;
        }

        /*
         * Method này dùng để tính toán thời gian làm việc của một user trong một tháng
         *
         * Với input truyền vào là userId, month và year. mục tiêu là tính ra thống kê timesheet trong tháng đó
         *
         * Các rule như sau:
         * 1/ Rule ngày làm việc và ngày nghỉ
         * - Ngày làm việc được xác định là từ thứ hai đến thứ sáu, và xen kẽ 2 ngày thứ bảy //
         * - Ví dụ tháng 5/2022 có 4 ngày thứ bảy vào các ngày 7, 14, 21, 28 thì //
         * - Nếu isFirstSaturdayWorking = true (ngày thứ 7 đầu tiên là ngày làm việc) thì ngày 21 làm việc.//
         * - Nếu isFirstSaturdayWorking = true (ngày thứ 7 đầu tiên là ngày nghỉ) thì ngày 14 và 28 làm việc.//
         *
         *
         * 2/ Tính muộn trong 1 ngày
         * - Nếu thời gian checkin < 8h30 thì là muộn
         * - Số giây muộn được tính bằng: thời gian Checkin - thời điểm 08h30
         * - Ghi số giây muộn vào field TotalLateInSeconds và IsLate
         *
         * 3/ Tính thời gian làm việc 1 ngày:
         * - Do giờ nghỉ trưa sẽ từ: 12h00 đến 1h30, thời gian làm việc tính như sau
         * - Buổi sáng tính từ lúc Checkin đến 12h00
         * - Buổi chiều tính từ lúc 1h30 đến lúc checkout
         * - Ghi thời gian làm việc vào field: TotalActualWorkingTimeInSeconds
         *
         * 4/ Điền trạng thái Ngày (field Status)
         * - Ngày nào là ngày làm việc, có checkin và checkout đầy đủ, không muộn, thời gian làm việc trên 8h thì trạng thái là VALID
         * - Ngày nào là ngày làm việc, có checkin và checkout đầy đủ, thời gian làm việc < 8h thì trạng thái là INCOMPLETE
         * - Ngày nào là ngày làm việc, có checkin mà không có checkout thì trạng thái là INPROCESS
         * - Ngày nào là ngày là việc, không có checkin thì trạng thái là ABSENT
         *
         *  field TotalWorkingHours = tổng số ngày làm việc * 8
         *  field TotalActualWorkingHours = tổng số giờ làm việc thực tế
         */

        public UserMonthlyTimesheetModel Calculate(Guid userId, int month, int year)
        {
            // TODO
            // Implement this function

            return null;
        }

        public static IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            List<DateTime> result = new List<DateTime>();

            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                result.Add(new DateTime(year, month, day));
            }
            return result;
        }

        public IEnumerable<int> CalculateAllWorkDay(int year, int month)
        {
            var allWeekDayDateTimeFormat = TimesheetCalculator.AllDatesInMonth(year, month).Where(i => i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday);
            var allSaturdayDateTimeFormat = TimesheetCalculator.AllDatesInMonth(year, month).Where(i => i.DayOfWeek == DayOfWeek.Saturday);

            List<int> allWeekDay = new List<int>();
            List<int> allSaturday = new List<int>();
            foreach (var item in allWeekDayDateTimeFormat)
            {
                allWeekDay.Add(item.Day);
            }

            foreach (var item in allSaturdayDateTimeFormat)
            {
                allSaturday.Add(item.Day);
            }
            if (isFirstSaturdayWorking)
            {
                var evens = allSaturday.Where((item, index) => index % 2 == 0);
                allWeekDay.AddRange(evens);
            }
            else
            {
                var odds = allSaturday.Where((item, index) => index % 2 != 0);
                allWeekDay.AddRange(odds);
            }
            return allWeekDay;
        }
    }
}