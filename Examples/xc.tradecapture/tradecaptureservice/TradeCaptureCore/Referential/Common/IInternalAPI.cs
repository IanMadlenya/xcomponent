﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

namespace XComponent.Referential.Common
{
    public interface IInternalAPI
    {
		void Start(Context context, string privateTopic = null);

		void AddInstrument(Context context, string privateTopic = null);

		void GetInstrumentSnapshot(Context context, string privateTopic = null);

		void Start(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void AddInstrument(Context context, XComponent.Referential.UserObject.Instrument transitionEvent, string privateTopic = null);

		void GetInstrumentSnapshot(Context context, XComponent.Referential.UserObject.GetSnapshot transitionEvent, string privateTopic = null);

		void SendEvent(XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

		void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

	}
}
