﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MG.DataGens;
using TP_MG.Repositories;
using TP_MG.View;
using TP_MG.Model;
using TP_MG.Services;

namespace TP_MG
{
    class Program
    {
        static void Main(string[] args)
        {
            DataRepository data;
            //            data = new DataRepository(new SmallDataGenerator());
            //            DataService dataService = new DataService(data);
            //           dataService.printLog();
            data = new DataRepository(new BigRandomDataGenerator(100));
            DataService dataService = new DataService(data);
            dataService.printAllData();
            Console.ReadKey();
        }
    }
}
