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

namespace XComponent.TradeCapture.Common
{
    public interface IInternalAPI
    {
		void NewTransaction(Context context, string privateTopic = null);

		void ValidationError(Context context, string privateTopic = null);

		void InitMapping(Context context, string privateTopic = null);

		void Reject(Context context, string privateTopic = null);

		void UpdateAndRetry(Context context, string privateTopic = null);

		void TimeOut(Context context, string privateTopic = null);

		void Error(Context context, string privateTopic = null);

		void Accepted(Context context, string privateTopic = null);

		void GetInstrumentSnapshot(Context context, string privateTopic = null);

		void ReferentialNotification(Context context, string privateTopic = null);

		void UpdateReferential(Context context, string privateTopic = null);

		void NewTransaction(Context context, XComponent.TradeCapture.UserObject.Transaction transitionEvent, string privateTopic = null);

		void ValidationError(Context context, XComponent.TradeCapture.UserObject.Error transitionEvent, string privateTopic = null);

		void InitMapping(Context context, XComponent.TradeCapture.UserObject.Init transitionEvent, string privateTopic = null);

		void Reject(Context context, XComponent.TradeCapture.UserObject.Reject transitionEvent, string privateTopic = null);

		void UpdateAndRetry(Context context, XComponent.TradeCapture.UserObject.UpdateAndRetry transitionEvent, string privateTopic = null);

		void TimeOut(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void Error(Context context, XComponent.TradeCapture.UserObject.Error transitionEvent, string privateTopic = null);

		void Accepted(Context context, XComponent.TradeCapture.UserObject.Accept transitionEvent, string privateTopic = null);

		void GetInstrumentSnapshot(Context context, XComponent.Referential.UserObject.GetSnapshot transitionEvent, string privateTopic = null);

		void ReferentialNotification(Context context, XComponent.Referential.UserObject.InstrumentSnapshot transitionEvent, string privateTopic = null);

		void UpdateReferential(Context context, XComponent.Referential.UserObject.Instrument transitionEvent, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null);

		void SendEvent(XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null);

		void SendEvent(XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

		void SendEvent(XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null);

		void SendEvent(XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Transaction evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Error evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Init evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Reject evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.UpdateAndRetry evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.TradeCapture.UserObject.Accept evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.GetSnapshot evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.InstrumentSnapshot evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Referential.UserObject.Instrument evt, string privateTopic = null);

	}
}
