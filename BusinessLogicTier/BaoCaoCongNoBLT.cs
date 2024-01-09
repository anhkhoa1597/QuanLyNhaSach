﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;

namespace CNPM
{
    class BaoCaoCongNoBLT
    {
        BaoCaoCongNoDAT objBaoCao = new BaoCaoCongNoDAT();

        public DataTable getTable(DateTime date)
        {
            DateTime from = new DateTime(date.Year, date.Month, 1);
            DateTime to = from.AddMonths(1);
            return objBaoCao.getBaoCaoTable(from, to);
        }
    }
}
