using Aimtec;
using Spell = Aimtec.SDK.Spell;

namespace Stoic_Kayle_by_Cyla
{
    public static class     ManageSpells
    {
        public static       Spell Q;
        public static       Spell W;
        public static       Spell E;
        public static       Spell R;
        public static       Spell Recall;

        public static void SetupSpells()
        { 
            Q = new Spell(SpellSlot.Q, 650);
            W = new Spell(SpellSlot.W, 900);
            E = new Spell(SpellSlot.E, 650);
            R = new Spell(SpellSlot.R, 900);
            Recall = new Spell(SpellSlot.Recall);
        }
    }
}
