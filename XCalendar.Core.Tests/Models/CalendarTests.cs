using System;
using XCalendar.Core.Models;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace XCalendar.Core.Tests.Models
{
    public class CalendarTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(34646)]
        public void SettingRowsChangesRowCount(int Rows)
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                AutoRows = false
            };

            Calendar.Rows = Rows;

            Assert.Equal(Rows, Calendar.Rows);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-34646)]
        [InlineData(int.MinValue)]
        public void SettingRowsBelow1ThrowsException(int Rows)
        {
            Assert.ThrowsAny<Exception>(() =>
            {
                var Calendar = new Calendar<CalendarDay>()
                {
                    AutoRows = false
                };

                Calendar.Rows = Rows;
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForMonday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Monday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 26),
                new DateTime(2022, 12, 27),
                new DateTime(2022, 12, 28),
                new DateTime(2022, 12, 29),
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForTuesday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Tuesday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 27),
                new DateTime(2022, 12, 28),
                new DateTime(2022, 12, 29),
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForWednesday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Wednesday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 28),
                new DateTime(2022, 12, 29),
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6),
                new DateTime(2023, 2, 7)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForThursday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Thursday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 29),
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6),
                new DateTime(2023, 2, 7),
                new DateTime(2023, 2, 8)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForFriday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Friday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6),
                new DateTime(2023, 2, 7),
                new DateTime(2023, 2, 8),
                new DateTime(2023, 2, 9)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForSaturday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Saturday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2022, 12, 31),
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6),
                new DateTime(2023, 2, 7),
                new DateTime(2023, 2, 8),
                new DateTime(2023, 2, 9),
                new DateTime(2023, 2, 10)
            });
        }
        [Fact]
        public void FirstDayOfWeekWorksForSunday()
        {
            var Calendar = new Calendar<CalendarDay>()
            {
                NavigatedDate = new DateTime(2023, 1, 1),
                StartOfWeek = DayOfWeek.Sunday
            };

            Calendar.Days.Select(x => x.DateTime).Should().Equal(new List<DateTime>()
            {
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2),
                new DateTime(2023, 1, 3),
                new DateTime(2023, 1, 4),
                new DateTime(2023, 1, 5),
                new DateTime(2023, 1, 6),
                new DateTime(2023, 1, 7),
                new DateTime(2023, 1, 8),
                new DateTime(2023, 1, 9),
                new DateTime(2023, 1, 10),
                new DateTime(2023, 1, 11),
                new DateTime(2023, 1, 12),
                new DateTime(2023, 1, 13),
                new DateTime(2023, 1, 14),
                new DateTime(2023, 1, 15),
                new DateTime(2023, 1, 16),
                new DateTime(2023, 1, 17),
                new DateTime(2023, 1, 18),
                new DateTime(2023, 1, 19),
                new DateTime(2023, 1, 20),
                new DateTime(2023, 1, 21),
                new DateTime(2023, 1, 22),
                new DateTime(2023, 1, 23),
                new DateTime(2023, 1, 24),
                new DateTime(2023, 1, 25),
                new DateTime(2023, 1, 26),
                new DateTime(2023, 1, 27),
                new DateTime(2023, 1, 28),
                new DateTime(2023, 1, 29),
                new DateTime(2023, 1, 30),
                new DateTime(2023, 1, 31),
                new DateTime(2023, 2, 1),
                new DateTime(2023, 2, 2),
                new DateTime(2023, 2, 3),
                new DateTime(2023, 2, 4),
                new DateTime(2023, 2, 5),
                new DateTime(2023, 2, 6),
                new DateTime(2023, 2, 7),
                new DateTime(2023, 2, 8),
                new DateTime(2023, 2, 9),
                new DateTime(2023, 2, 10),
                new DateTime(2023, 2, 11)
            });
        }
    }
}
