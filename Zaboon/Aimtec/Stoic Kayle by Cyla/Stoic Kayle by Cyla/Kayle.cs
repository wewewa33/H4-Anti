using System;
using Aimtec;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Extensions;


namespace Stoic_Kayle_by_Cyla
{
    class Kayle
    {
        public static Obj_AI_Hero Player = ObjectManager.GetLocalPlayer();

        private void OnUpdate()
        {
            var Modes = new Modes();
            var percentHealW = WorldMenu.miscs["lifeW"].As<MenuSlider>().Value;
            var percentHealR = WorldMenu.miscs["lifeR"].As<MenuSlider>().Value;
            if (Player.IsDead || MenuGUI.IsChatOpen())
            {
                return;
            }
            switch (Orbwalker.Implementation.Mode)
            {
                case OrbwalkingMode.Combo:
                    Modes.Combo();
                    break;
                case OrbwalkingMode.Mixed:
                    Modes.Harass();
                    break;
                case OrbwalkingMode.Laneclear:
                    Modes.LaneClear();
                    break;

            }

            if (WorldMenu.miscs["autoW"].As<MenuBool>().Enabled && ManageSpells.W.Ready && Player.HealthPercent() <= percentHealW && !(Player.IsRecalling()))
            {
                ManageSpells.W.Cast(Player);
            }

            if (WorldMenu.miscs["autoR"].As<MenuBool>().Enabled && ManageSpells.R.Ready && Player.HealthPercent() <= percentHealR && !(Player.IsRecalling()))
            {
                ManageSpells.R.Cast(Player);
            }

        }

        public Kayle()
        {
            WorldMenu.Setup();
            ManageSpells.SetupSpells();
            Game.OnUpdate += OnUpdate;
            Console.WriteLine("Made by Zaboon/Cyla");
        }

    }
}
