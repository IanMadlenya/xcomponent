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

namespace XComponent.HelloWorld.Common
{
    public interface IInternalAPI
    {
		void SayHello(Context context, string privateTopic = null);

		void SayHello(Context context, XComponent.HelloWorld.UserObject.SayHello transitionEvent, string privateTopic = null);

		void SendEvent(XComponent.HelloWorld.UserObject.SayHello evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.HelloWorld.UserObject.SayHello evt, string privateTopic = null);

	}
}
