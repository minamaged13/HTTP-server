﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Call CreateRedirectionRulesFile() function to create the rules of redirection 
            CreateRedirectionRulesFile();

            // 1) Make server object on port 1000
            Server server = new Server(1000, "C:\\Users\\MarwanEzzat\\source\\repos\\HTTPServer\\HTTPServer\\bin\\Debug\\redirectionRules.txt");

            // 2) Start Server
            server.StartServer();
        }

        static void CreateRedirectionRulesFile()
        {
            //Create file named redirectionRules.txt
            StreamWriter sw = new StreamWriter("redirectionRules.txt");
            //Write the rules of redirection to the file
            sw.WriteLine("aboutus0.html,aboutus2.html");
            sw.Close();
            // each line in the file specify a redirection rule
            // example: "aboutus.html,aboutus2.html"
            // means that when making request to aboustus.html,, it redirects me to aboutus2
        }

    }
}
