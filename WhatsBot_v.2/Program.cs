﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium;
using System.Diagnostics;
using System.IO;


namespace WhatsBot_v._2
{
    class Program
    {
        public static bool on = true;
        static void Main(string[] args)
        {
            string exeName = "Whatsapp.exe";
            string exePath = Path.Combine(Directory.GetCurrentDirectory(), exeName);
            Process.Start(exePath);

            Console.WriteLine("Hello, started..");
            funktionen fkt = new funktionen();
                  

            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "https://web.whatsapp.com/";
            Thread.Sleep(8000);
            fkt.send(@"🤖*WhatsBot aktivated*🤖", driver);
                     
            
           
            while (true)
            {
                if (on)
                {
                    Thread.Sleep(500);

                    fkt.scanner(driver);
                }
                
                
            }
            

           
        }
    }
}
