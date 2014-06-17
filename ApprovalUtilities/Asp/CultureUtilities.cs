﻿using System.Globalization;
using System.Threading;

namespace ApprovalUtilities.Asp
{
    public class CultureUtilities
    {
        public static void ForceCulture(string culture="en-US")
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        }
    }
}