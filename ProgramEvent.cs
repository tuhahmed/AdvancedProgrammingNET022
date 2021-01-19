using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    public class ProgramEvent
    {
        public static void Main(string[] args)
        {
            Button btn = new Button();

            ClickListner ck = new ClickListner();

            ck.Clicked += btn.Clicked;

            ck.createNotification("RadioButton");

            Console.ReadLine();
        }


        public class Button
        {
            public void Clicked(object sender, ClickInfo e)
            {
                Console.WriteLine("The clicked button is:  " + e.Info);
            }

        }


        public class ClickListner
        {
            public event ClickEvent Clicked;
            public void createNotification(string msg)
            {
                if (Clicked != null)
                {
                    Clicked(this, new ClickInfo(msg));
                }
            }
        }

        public delegate void ClickEvent(object sender, ClickInfo e);

        public class ClickInfo : EventArgs
        {
            public string Info { get; set; }
            public ClickInfo(string info)
            {
                Info = info;
            }
        }

    }
}

