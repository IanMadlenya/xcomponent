﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;

namespace XComponent.SwaggerPetstore.Common.StateHashCodeCalculator.GetInventoryOperation
{
    public class RequestSentStateHashCodeCalculator : IStateHashCodeCalculator<XComponent.SwaggerPetstore.UserObject.GetInventoryOperation, Object>
    {
        public ISet<int> Calculate(XComponent.SwaggerPetstore.UserObject.GetInventoryOperation publicMember, Object internalMember)
        {
            var hashcodes = new HashSet<int>();

            hashcodes.Add(0);
            return hashcodes;
        }
    }
}
