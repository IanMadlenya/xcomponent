﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using XComponent.Common.ApiContext;
using XComponent.Engine.Processing;
using XComponent.Engine.Processing.Domain;

namespace XComponent.Trade.Common
{
    public class InternalAPI : IInternalAPI
    {
		private IInternalCommunication _internalCommunicationLayer;
        
        public InternalAPI(IAgentManager agentManager)
        {
            _internalCommunicationLayer = new InternalCommunication(agentManager);
        }
        
        public void Init()
        {
            _internalCommunicationLayer.Init("DeploymentConfiguration.xml");
        }
        
        public void Init(string configFile)
        {
            _internalCommunicationLayer.Init(configFile);
        }

		public void Init(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Common.Event.DefaultEvent), privateTopic);
        }

		public void ProcessOrderCreation(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Order.UserObject.OrderCreation), privateTopic);
        }

		public void CreateTrade(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Trade.UserObject.Trade), privateTopic);
        }

		public void ExecuteTrade(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Trade.UserObject.TradeExecution), privateTopic);
        }

		public void ProcessOrderExecution(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Order.UserObject.OrderExecution), privateTopic);
        }

		public void Execute(Context context, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, default(XComponent.Trade.UserObject.TradeExecution), privateTopic);
        }

		public void Init(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void ProcessOrderCreation(Context context, XComponent.Order.UserObject.OrderCreation transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void CreateTrade(Context context, XComponent.Trade.UserObject.Trade transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void ExecuteTrade(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void ProcessOrderExecution(Context context, XComponent.Order.UserObject.OrderExecution transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void Execute(Context context, XComponent.Trade.UserObject.TradeExecution transitionEvent, string privateTopic = null)
        {
            _internalCommunicationLayer.Send(context, transitionEvent, privateTopic);
        }

		public void SendEvent(XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(evt, privateTopic);
        }

		public void SendEvent(XComponent.Trade.UserObject.Trade evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(evt, privateTopic);
        }

		public void SendEvent(XComponent.Trade.UserObject.TradeExecution evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(evt, privateTopic);
        }

		public void SendEvent(XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(evt, privateTopic);
        }

		public void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderCreation evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(stdEnum, evt, privateTopic);
        }

		public void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.Trade evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(stdEnum, evt, privateTopic);
        }

		public void SendEvent(StdEnum stdEnum, XComponent.Trade.UserObject.TradeExecution evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(stdEnum, evt, privateTopic);
        }

		public void SendEvent(StdEnum stdEnum, XComponent.Order.UserObject.OrderExecution evt, string privateTopic = null)
        {
            _internalCommunicationLayer.SendEvent(stdEnum, evt, privateTopic);
        }

    }
}
