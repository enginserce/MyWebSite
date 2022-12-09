using System;

namespace MyProject.Models
{
    public static class Time
    {
        public static string Zaman(this DateTime date)
        {
            //Bugünden gelen tarihinin farkını alıyorum
            var timeSpan = DateTime.Now - date;
            //60 saniyeden küçükse 
            if (timeSpan <= TimeSpan.FromSeconds(60))
                return string.Format("{0} saniye önce", timeSpan.Seconds);
            //60 dakikadan küçükse
            else if (timeSpan <= TimeSpan.FromMinutes(60))
                return timeSpan.Minutes > 1 ? string.Format("{0} dakika önce", timeSpan.Minutes) : "yaklaşık bir dakika önce";
            //24 saatten küçükse
            else if (timeSpan <= TimeSpan.FromHours(24))
                return timeSpan.Hours > 1 ? String.Format("{0} saat önce", timeSpan.Hours) : "yaklaşık bir saat önce";
            //30 günden küçükse
            else if (timeSpan <= TimeSpan.FromDays(30))
                return timeSpan.Days > 1 ? String.Format("{0} gün önce", timeSpan.Days) : "dün";
            //365 günden küçükse
            else if (timeSpan <= TimeSpan.FromDays(365))
                return timeSpan.Days > 30 ? String.Format("{0} ay önce", timeSpan.Days / 30) : "yaklaşık bir ay önce";
            //Yıl 
            return timeSpan.Days > 365 ? String.Format("{0} yıl önce", timeSpan.Days / 365) : "yaklaşık bir yıl önce";
        }
    }
}
