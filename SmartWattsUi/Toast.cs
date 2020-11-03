using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace SmartWattsUi
{
    public static class Toast
    {
        public static bool ToastOn { get; set; }
        public static string ToastText { get; set; }
        public static string ToastColor { get; set; }

        public static event Action OnChange;


        public async static void PopToast(string msg = "", string color = "green", int duration = 1000 * 15)
        {
            ToastOn = true;
            ToastColor = color;
            ToastText = msg;
            await Task.Delay(duration);
            ToastOn = false;
            NotifyStateChanged();
        }

        private static void CloseToast(Object source, ElapsedEventArgs e)
        {
            ToastOn = false;
        }

        private static void NotifyStateChanged() => OnChange?.Invoke();

    }
}
