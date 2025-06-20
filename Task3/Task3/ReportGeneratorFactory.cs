﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class ReportGeneratorFactory
    {
        public static ReportGenerator Create()
        {
            return new ReportGenerator(
                new DatabaseService(),
                new FileLogger()
            );
        }
    }
}
