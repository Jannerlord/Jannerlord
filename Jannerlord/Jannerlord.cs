﻿using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace Jannerlord
{
    public class JannerlordSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Message",
                new TextObject("Message"),
                9990,
                () => { InformationManager.DisplayMessage(new InformationMessage("Hello World!")); },
                false));
        }
    }
}