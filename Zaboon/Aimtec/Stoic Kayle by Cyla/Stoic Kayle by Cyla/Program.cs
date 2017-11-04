using Aimtec;
using Aimtec.SDK.Events;


namespace Stoic_Kayle_by_Cyla
{
    class Program
    {
        public static Obj_AI_Hero Player = ObjectManager.GetLocalPlayer();
        static void Main(string[] args)
        {
            GameEvents.GameStart += GameEvents_GameStart;
        }

        private static void GameEvents_GameStart()
        {
            if (ObjectManager.GetLocalPlayer().ChampionName != "Kayle")
                return;

            var Kayle = new Kayle();
        }
    }
}
