﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHousePriceApp.Server.DataInsert
{
    public interface IInsertRepository
    {
        public void InsertHouse(Texa city);
    }
}
