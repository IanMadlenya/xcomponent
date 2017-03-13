﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;

namespace XComponent.SlackProxy.Common
{
    public interface IInternalCommunication
    {
        void Init(string configFile);

        void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void Send(Context context, XComponent.SlackProxy.UserObject.SendMessage evt, string privateTopic = null);

        void Send(Context context, XComponent.SlackProxy.UserObject.Success evt, string privateTopic = null);

        void Send(Context context, XComponent.SlackProxy.UserObject.Error evt, string privateTopic = null);

        void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(XComponent.SlackProxy.UserObject.SendMessage evt, string privateTopic = null);

        void SendEvent(XComponent.SlackProxy.UserObject.Success evt, string privateTopic = null);

        void SendEvent(XComponent.SlackProxy.UserObject.Error evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.SlackProxy.UserObject.SendMessage evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.SlackProxy.UserObject.Success evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.SlackProxy.UserObject.Error evt, string privateTopic = null);

    }
}
