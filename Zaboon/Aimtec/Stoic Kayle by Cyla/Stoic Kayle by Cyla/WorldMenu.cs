using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Menu;

namespace Stoic_Kayle_by_Cyla
{
    public static class     WorldMenu
    {
        public static       Orbwalker Orbwalker = new Orbwalker();
        public static       Menu Menu = new Menu("Stoic Kayle by Cyla", "Stoic Kayle by Cyla", true);
        public static       Menu Combo;
        public static       Menu harass;
        public static       Menu laneclear;
        public static       Menu miscs;
        public static void    Setup()
        {
            Orbwalker.Attach(Menu);

            {
                Combo = new Menu("combo", "Combo")
                {
                    new MenuBool("useQ", "Q"),
                    new MenuBool("useW", "W"),
                    new MenuSlider("lifeW", "Life %", 50),
                    new MenuBool("useE", "E"),
                    new MenuBool("useR", "R"),
                    new MenuSlider("lifeR", "Life %", 50)
                };
                Menu.Add(Combo);
            }

            {
                harass = new Menu("harass", "Harass")
                {
                    new MenuBool("useQ", "Q"),
                    new MenuBool("useE", "E"),
                    new MenuSlider("mana", "Mana %", 50)
                };
                Menu.Add(harass);
            }

            {
                laneclear = new Menu("laneclear", "LaneClear")
                {
                    new MenuBool("useQ", "Q"),
                    new MenuBool("useE", "E"),
                    new MenuSlider("mana", "Mana %", 50)
                };
                Menu.Add(laneclear);
            }

            {
                miscs = new Menu("misc", "Misc")
                {
                    new MenuBool("autoW", "Auto W"),
                    new MenuSlider("lifeW", "Life %", 25),
                    new MenuBool("autoR", "Auto R"),
                    new MenuSlider("lifeR", "Life %", 10)
                };
                Menu.Add(miscs);
            }

            {
                Menu.Attach();
            }
        }

    }
}
