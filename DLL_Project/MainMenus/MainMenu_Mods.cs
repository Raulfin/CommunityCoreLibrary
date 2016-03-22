﻿using RimWorld;
using Verse;
using UnityEngine;

namespace CommunityCoreLibrary
{

    public class                            MainMenu_Mods : IMainMenu
    {

        public bool                         RenderNow( bool anyWorldFiles, bool anyMapFiles )
        {
            return ( Game.Mode == GameMode.Entry );
        }

        public void                         ClickAcion()
        {
            Find.WindowStack.Add( (Window) new Page_ModsConfig() );
        }

    }

}