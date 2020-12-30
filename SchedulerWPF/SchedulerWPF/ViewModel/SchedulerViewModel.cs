using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection AppointmentCollection { get; set; } = new ScheduleAppointmentCollection();
        public SchedulerViewModel()
        {
            ScheduleAppointment appointment1 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 10, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 10, 11, 0, 0),
                Subject = "Development Meeting",
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#889e81"))
            };

            ScheduleAppointment appointment2 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 15, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 15, 11, 0, 0),
                Subject = "Board Meeting",
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#889e81"))
            };

            ScheduleAppointment appointment3 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 15, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 15, 11, 0, 0),
                Subject = "Consulting",
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#889e81"))
            };

            ScheduleAppointment appointment4 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 6, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 2, 11, 0, 0),
                Subject = "Project Plan Meeting",
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#889e81"))
            };

            ScheduleAppointment appointment5 = new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 31, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 23, 11, 0, 0),
                Subject = "Customer Meeting",
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#889e81"))
            };

            AppointmentCollection.Add(appointment1);
            AppointmentCollection.Add(appointment2);
            AppointmentCollection.Add(appointment3);
            AppointmentCollection.Add(appointment4);
            AppointmentCollection.Add(appointment5);
        }
    }
}
      