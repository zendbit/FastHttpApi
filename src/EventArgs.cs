﻿using BeetleX.Buffers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeetleX.FastHttpApi
{
    public delegate void EventHttpServerLog(IServer server, BeetleX.EventArgs.ServerLogEventArgs e);

    public struct EventHttpResponsedArgs
    {
        public EventHttpResponsedArgs(HttpRequest request, HttpResponse response, double time, int status, string statusMsg)
        {
            Request = request;
            Response = response;
            Time = time;
            Status = status;
            StatusMessage = statusMsg;
        }

        public HttpRequest Request { get; set; }

        public HttpResponse Response { get; set; }

        public double Time
        {
            get; set;
        }

        public int Status { get; set; }

        public string StatusMessage { get; set; }
    }

    public class WebSocketConnectArgs : System.EventArgs
    {
        public WebSocketConnectArgs(HttpRequest request)
        {
            Request = request;
            Cancel = false;

        }

        public HttpRequest Request { get; internal set; }

        public bool Cancel { get; set; }
    }

    public class EventControllerInstanceArgs : System.EventArgs
    {
        public Type Type { get; internal set; }

        public object Controller { get; set; }

        public IHttpContext Context { get; internal set; }


    }

    public class EventParameterBinding : System.EventArgs
    {
        public Type Type { get; internal set; }

        public object Parameter { get; set; }

        public IHttpContext Context { get; internal set; }

        public ActionHandler ActionHandler { get; internal set; }
    }

    public class EventActionExecutingArgs : System.EventArgs
    {


        public IHttpContext HttpContext { get; internal set; }

        public bool Cancel { get; set; }
    }


    public class EventHttpRequestArgs : System.EventArgs
    {
        public HttpRequest Request { get; internal set; }

        public HttpResponse Response { get; internal set; }

        public bool Cancel { get; set; }
    }

    public class EventHttpServerStartedArgs : System.EventArgs
    {
        public HttpApiServer HttpApiServer { get; internal set; }
    }

    public class EventOptionsReloadArgs : System.EventArgs
    {
        public HttpApiServer HttpApiServer { get; internal set; }

        public HttpOptions HttpOptions { get; internal set; }
    }

    public class EventActionRegistingArgs
    {
        public bool Cancel { get; set; } = false;

        public ActionHandler Handler { get; internal set; }

        public string Url { get; set; }
    }

}
