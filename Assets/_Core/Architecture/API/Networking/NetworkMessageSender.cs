using Architecture.API.Events;
using Architecture.API.Managers.Program;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UI.API.Edit;
using UnityEngine;
using static Architecture.API.Networking.NetworkJsonClasses;

namespace Architecture.API.Networking
{
    public static class NetworkMessageSender
    {
        private static string s_ServerURI = "https://homework.mocart.io/api/products";

        private static HttpRequestsTool s_RequestsTool = new HttpRequestsTool();

        
    }
}