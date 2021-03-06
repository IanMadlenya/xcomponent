﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;

namespace XComponent.Order.Common.StateHashCodeCalculator.OrderProcessor
{
    public class EntryPointStateHashCodeCalculator : IStateHashCodeCalculator<Object, Object>
    {
        public ISet<int> Calculate(Object publicMember, Object internalMember)
        {
            var hashcodes = new HashSet<int>();

            hashcodes.Add(0);
            return hashcodes;
        }
    }
}
