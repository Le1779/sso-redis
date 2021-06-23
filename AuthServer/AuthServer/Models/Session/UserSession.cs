﻿namespace AuthServer.Models.Session
{
    using System.Runtime.CompilerServices;
    using System.Web;

    public class UserSession
    {
        private UserSession() {}

        public static string Account 
        {
            get
            {
                return Get<string>();
            }
            set
            {
                Set(value);
            }
        }

        public static string Password 
        {
            get
            {
                return Get<string>();
            }
            set
            {
                Set(value);
            }
        }

        static void Set<T>(T value, [CallerMemberName] string key = "")
        {
            HttpContext.Current.Session[key] = value;
        }

        static T Get<T>([CallerMemberName] string key = "")
        {
            return (T)HttpContext.Current.Session[key];
        }
    }
}