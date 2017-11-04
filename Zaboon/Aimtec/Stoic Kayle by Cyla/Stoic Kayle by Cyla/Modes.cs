using System.Drawing;
using Aimtec;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Events;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.TargetSelector;
using Aimtec.SDK.Extensions;
using Aimtec.SDK.Damage;
using Aimtec.SDK.Prediction.Skillshots;
using System.Linq;
using System;


namespace Stoic_Kayle_by_Cyla
{
    public class                    Modes
    {
        public static Obj_AI_Hero   Player = ObjectManager.GetLocalPlayer();

        public void     Combo()
        {

            bool useQ = WorldMenu.Combo["useQ"].As<MenuBool>().Enabled;
            bool useW = WorldMenu.Combo["useW"].As<MenuBool>().Enabled;
            bool useE = WorldMenu.Combo["useE"].As<MenuBool>().Enabled;
            bool useR = WorldMenu.Combo["useR"].As<MenuBool>().Enabled;
            var percentHealW = WorldMenu.Combo["lifeW"].As<MenuSlider>().Value;
            var percentHealR = WorldMenu.Combo["lifeR"].As<MenuSlider>().Value;
            var target = TargetSelector.GetTarget(ManageSpells.Q.Range);

            if (!target.IsValidTarget())
            {
                return;
            }

            if (useQ && ManageSpells.Q.Ready)
            {
                if (target.IsValidTarget())
                    ManageSpells.Q.Cast(target);
            }

            if (useW && ManageSpells.W.Ready && Player.HealthPercent() <= percentHealW)
            {
                ManageSpells.W.Cast(Player);
            }

            if (useE && ManageSpells.E.Ready)
            {
                if (target.IsValidTarget())
                    ManageSpells.E.Cast(Player);
            }

            if (useR && ManageSpells.R.Ready && Player.HealthPercent() <= percentHealR)
            {
                ManageSpells.R.Cast(Player);
            }
        }

        public void     Harass()
        {
            bool useQ = WorldMenu.harass["useQ"].As<MenuBool>().Enabled;
            bool useE = WorldMenu.harass["useE"].As<MenuBool>().Enabled;
            var Mana  = WorldMenu.harass["mana"].As<MenuSlider>().Value;
            var target = TargetSelector.GetTarget(ManageSpells.Q.Range);

            if (useQ && ManageSpells.Q.Ready && Player.ManaPercent() >= Mana)
            {
                if (target.IsValidTarget())
                    ManageSpells.Q.Cast(target);

            }
            if (useE && ManageSpells.E.Ready && Player.ManaPercent() >= Mana)
            {
                if (target.IsValidTarget())
                    ManageSpells.E.Cast(Player);
            }
        }
        public void     LaneClear()
        {
            bool useE = WorldMenu.laneclear["useE"].As<MenuBool>().Enabled;
            var Mana = WorldMenu.laneclear["mana"].As<MenuSlider>().Value;

            if (useE && ManageSpells.E.Ready && Player.ManaPercent() >= Mana)
            {
                    ManageSpells.E.Cast(Player);
            }
        }
    }
}
