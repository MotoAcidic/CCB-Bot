using DiscordSupportBot.Models.BaseModels;
using DiscordSupportBot.Modules;
using Newtonsoft.Json;

namespace DiscordSupportBot.Models.Explorer
{
    public class ExplorerStats
    {
        public const double blocksPerDay = 1440;

        public const int currentReward = 145;

        public const int firstHalveStart = 86401;
        public const double firstHalveReward = 72.5;

        public const int secondHalveStart = 108000;
        public const double secondHalveReward = 36.25;

        public const int thirdHalveStart = 129600;
        public const double thirdHalveReward = 18.125;

        public const int fourthHalveStart = 151201;
        public const double fourthHalveReward = 9.0625;

        public const double MasternodeReward = 0.70;
        public const double StakingReward = 0.30;
        public const double DevelopmentFee = 0.0;


        public float Difficulty { get; set; }
        public int MasternodeCount { get; set; }
        public int Block { get; set; }
        public double Supply { get; set; }

    }
    public enum StatsDataType
    {
        Difficulty,
        MasternodeCount,
        Block,
        Supply
    }

}