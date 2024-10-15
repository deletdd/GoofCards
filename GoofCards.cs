using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using GoofCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace GoofCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class GoofCards : BaseUnityPlugin
    {
        private const string ModId = "deletd.rounds.goofcards";
        private const string ModName = "Goof Cards";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "Goof";
        public static GoofCards instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<Nut>();
            CustomCard.BuildCard<NoNut>();
            instance = this;
        }
    }
}
