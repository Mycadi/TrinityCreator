﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCreator;

namespace TrinityCreator.CreatureTemplates
{
    class EscorteeTemplate : TemplateBase
    {
        public EscorteeTemplate() : base() { }

        public override void LoadTemplate()
        {
            MinLevel = 80;
            MaxLevel = 80;
            Faction = 250;                                  // Escort faction
            SetBmspValues(NpcFlags, new int[] { 1, 2 });    // Gossip, Questgiver
            SetBmspValues(FlagsExtra, new int[] { 2 });     // Civilian
            SetBmspValues(TypeFlags, new int[] { 4096 });   // Aid players
            SetIKVPValue(Page.creatureTypeCb, 7);           // Humanoid
        }
    }
}