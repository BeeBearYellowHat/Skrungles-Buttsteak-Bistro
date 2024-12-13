using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._RMC14.CCVar;

[CVarDefs]
public sealed class RMCCVars : CVars
{
    public static readonly CVarDef<bool> RMCGunPrediction =
        CVarDef.Create("rmc.gun_prediction", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<bool> RMCGunPredictionPreventCollision =
        CVarDef.Create("rmc.gun_prediction_prevent_collision", false, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<bool> RMCGunPredictionLogHits =
        CVarDef.Create("rmc.gun_prediction_log_hits", false, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> RMCGunPredictionCoordinateDeviation =
        CVarDef.Create("rmc.gun_prediction_coordinate_deviation", 0.75f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> RMCGunPredictionLowestCoordinateDeviation =
        CVarDef.Create("rmc.gun_prediction_lowest_coordinate_deviation", 0.5f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> RMCGunPredictionAabbEnlargement =
        CVarDef.Create("rmc.gun_prediction_aabb_enlargement", 0.3f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<bool> RMCJobSlotScaling =
        CVarDef.Create("rmc.job_slot_scaling", true, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> RMCEmoteCooldownSeconds =
        CVarDef.Create("rmc.emote_cooldown_seconds", 20f, CVar.SERVER | CVar.REPLICATED);

    public static readonly CVarDef<float> RMCPowerUpdateEverySeconds =
        CVarDef.Create("rmc.power_update_every_seconds", 1f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCPowerLoadMultiplier =
        CVarDef.Create("rmc.power_load_multiplier", 0.01f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCMarinesPerSurvivor =
        CVarDef.Create("rmc.marines_per_survivor", 20, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCSurvivorsMinimum =
        CVarDef.Create("rmc.survivors_minimum", 2, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCSurvivorsMaximum =
        CVarDef.Create("rmc.survivors_maximum", 6, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCSpawnerMaxCorpses =
        CVarDef.Create("rmc.spawner_max_corpses", 25, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCHiveSpreadEarlyMinutes =
        CVarDef.Create("rmc.hive_spread_early_minutes", 40, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCNewPlayerTimeTotalHours =
        CVarDef.Create("rmc.new_player_time_total_hours", 25, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCNewPlayerTimeJobHours =
        CVarDef.Create("rmc.new_player_time_job_hours", 10, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCLateJoinsPerBurrowedLarvaEarlyThresholdMinutes =
        CVarDef.Create("rmc.late_joins_per_burrowed_larva_early_threshold_minutes", 15f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCLateJoinsPerBurrowedLarvaEarly =
        CVarDef.Create("rmc.late_joins_per_burrowed_larva_early", 5.5f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCLateJoinsPerBurrowedLarva =
        CVarDef.Create("rmc.late_joins_per_burrowed_larva", 4f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeBronzeMedalTimeHours =
        CVarDef.Create("rmc.playtime_bronze_medal_time_hours", 10, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeSilverMedalTimeHours =
        CVarDef.Create("rmc.playtime_silver_medal_time_hours", 25, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeGoldMedalTimeHours =
        CVarDef.Create("rmc.playtime_gold_medal_time_hours", 70, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimePlatinumMedalTimeHours =
        CVarDef.Create("rmc.playtime_platinum_medal_time_hours", 175, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeXenoPrefixThreeTimeHours =
        CVarDef.Create("rmc.playtime_xeno_prefix_three_time_hours", 124, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeXenoPostfixTimeHours =
        CVarDef.Create("rmc.playtime_xeno_postfix_time_hours", 24, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCPlaytimeXenoPostfixTwoTimeHours =
        CVarDef.Create("rmc.playtime_xeno_postfix_two_time_hours", 300, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> RMCDisconnectedXenoGhostRoleTimeSeconds =
        CVarDef.Create("rmc.disconnected_xeno_ghost_role_time_seconds", 300, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCMarineScalingNormal =
        CVarDef.Create("rmc.marine_scaling_normal", 50f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCMarineScalingBonus =
        CVarDef.Create("rmc.marine_scaling_bonus", 0f, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<float> RMCMentorHelpRateLimitPeriod =
        CVarDef.Create("rmc.mentor_help_rate_limit_period", 2f, CVar.SERVERONLY);

    public static readonly CVarDef<int> RMCMentorHelpRateLimitCount =
        CVarDef.Create("rmc.mentor_help_rate_limit_count", 10, CVar.SERVERONLY);

    public static readonly CVarDef<string> RMCMentorHelpSound =
        CVarDef.Create("rmc.mentor_help_sound", "/Audio/_RMC14/Effects/Admin/mhelp.ogg", CVar.ARCHIVE | CVar.CLIENTONLY);
}
