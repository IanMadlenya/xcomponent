﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;

namespace XComponent.SwaggerPetstore.Common.StateHashCodeCalculator.UpdatePetWithFormOperation
{
    public class SuccessResponseReceivedStateHashCodeCalculator : IStateHashCodeCalculator<XComponent.SwaggerPetstore.UserObject.UpdatePetWithFormOperation, Object>
    {
        public ISet<int> Calculate(XComponent.SwaggerPetstore.UserObject.UpdatePetWithFormOperation publicMember, Object internalMember)
        {
            var hashcodes = new HashSet<int>();
            return hashcodes;
        }
    }
}
