using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TasksManager.Helpers
{
    internal class ShowMessage
    {
        static List<String> ListMessage = new List<string>();
        public  static void AddMessage(string message)
        {
            ListMessage.Add(message);
        }

        public static List<String> GetMessages()
        {
            List<String> returnedList = new List<string>();
            foreach (var item in ListMessage)
            {
                returnedList.Add(item);
            }
            ListMessage.Clear();
            return returnedList;

        }
        public static string GetMassageAsString()
        {
            String msg = "";
            foreach (var item in GetMessages())
            {
                msg = item + "\n";
            }
            return msg;

        }

        public static void ShowMessageIdExist()
        {
           
        }


    }
}