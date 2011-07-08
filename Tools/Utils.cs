﻿// Utils
// Part of Forex Strategy Trader
// Website http://forexsb.com/
// Copyright (c) 2009 - 2011 Miroslav Popov - All rights reserved!
// This code or any part of it cannot be used in other applications without a permission.

using System;

namespace Forex_Strategy_Trader
{
    public enum MarketInfo
    {
        MODE_LOW               = 1,
        MODE_HIGH              = 2,
        MODE_TIME              = 5,
        MODE_BID               = 9,
        MODE_ASK               = 10,
        MODE_POINT             = 11,
        MODE_DIGITS            = 12,
        MODE_SPREAD            = 13,
        MODE_STOPLEVEL         = 14,
        MODE_LOTSIZE           = 15,
        MODE_TICKVALUE         = 16,
        MODE_TICKSIZE          = 17,
        MODE_SWAPLONG          = 18,
        MODE_SWAPSHORT         = 19,
        MODE_STARTING          = 20,
        MODE_EXPIRATION        = 21,
        MODE_TRADEALLOWED      = 22,
        MODE_MINLOT            = 23,
        MODE_LOTSTEP           = 24,
        MODE_MAXLOT            = 25,
        MODE_SWAPTYPE          = 26,
        MODE_PROFITCALCMODE    = 27,
        MODE_MARGINCALCMODE    = 28,
        MODE_MARGININIT        = 29,
        MODE_MARGINMAINTENANCE = 30,
        MODE_MARGINHEDGED      = 31,
        MODE_MARGINREQUIRED    = 32,
        MODE_FREEZELEVEL       = 33
    };


    public static class Utils
    {

        public static TimeSpan PeriodTimeSpan(MT4Bridge.PeriodType period)
        {
            if ((int)period < 60)
                return TimeSpan.FromMinutes((int)period);
            else if ((int)period < 1440)
                return TimeSpan.FromHours((int)period);
            else if ((int)period == 1440)
                return TimeSpan.FromDays(1);
            else if ((int)period == 10080)
                return TimeSpan.FromDays(7);
            else
                return TimeSpan.FromDays(30);
        }
    }
}
