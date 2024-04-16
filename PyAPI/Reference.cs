using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PyAPI.API;
using PyAPI.API.Buttons.Settings;
using UnityEngine.UI;
using Zorro.UI;
using Zorro.Settings;
using MelonLoader;

namespace PyAPI
{
    public class Reference
    {
        
        public static void Init()
        {
            new PyTab("TestName", "TestText", () =>
            {
                MelonLogger.Msg("Button made");
                
            });
        }
    }
}
