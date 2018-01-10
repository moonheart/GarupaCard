using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarupaCard.Models
{

    public class Entry2
    {
        public int lbBonus { get; set; }
        public int quantity { get; set; }
        public int resourceId { get; set; }
        public string resourceType { get; set; }
    }
    public class Costs
    {
        public IList<Entry2> entries { get; set; }
    }
    public class Entry3
    {
        public int lbBonus { get; set; }
        public int quantity { get; set; }
        public string resourceType { get; set; }
    }
    public class Rewards
    {
        public IList<Entry3> entries { get; set; }
    }
    public class Entry
    {
        public int appendTechnique { get; set; }
        public int appendPerformance { get; set; }
        public int appendVisual { get; set; }
        public string title { get; set; }
        public int releaseLevel { get; set; }
        public int cardId { get; set; }
        public Costs costs { get; set; }
        public int episodeId { get; set; }
        public string episodeType { get; set; }
        public string scenarioId { get; set; }
        public Rewards rewards { get; set; }
    }
    public class Episodes
    {
        public IList<Entry> entries { get; set; }
    }
    public class Entry4
    {
        public int lbBonus { get; set; }
        public int quantity { get; set; }
        public int resourceId { get; set; }
        public string resourceType { get; set; }
    }
    public class Costs2
    {
        public IList<Entry4> entries { get; set; }
    }
    public class Training
    {
        public int trainingLevelLimit { get; set; }
        public int trainingVisual { get; set; }
        public int trainingPerformance { get; set; }
        public Costs2 costs { get; set; }
        public int trainingTechnic { get; set; }
        public int cardId { get; set; }
        public int trainingCostumeId { get; set; }
    }
    public class SkillDetail
    {
        public string simpleDescription { get; set; }
        public int skillId { get; set; }
        public int skillLevel { get; set; }
        public double duration { get; set; }
        public string description { get; set; }
    }
    public class ActivateEffect
    {
        public int seq { get; set; }
        public string activateEffectType { get; set; }
        public int activateEffectValue { get; set; }
        public string activateEffectValueType { get; set; }
        public int skillId { get; set; }
        public int skillLevel { get; set; }
        public string valueDescription { get; set; }
        public string activateCondition { get; set; }
        public int? activateConditionLife { get; set; }
    }
    public class Skill
    {
        public int skillId { get; set; }
        public string skillName { get; set; }
        public int cardId { get; set; }
        public IList<SkillDetail> skillDetail { get; set; }
        public IList<ActivateEffect> activateEffect { get; set; }
        public IList<object> onceEffect { get; set; }
    }
    public class Card
    {
        public Episodes episodes { get; set; }
        /// <summary>
        /// 卡名称
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 稀有度
        /// </summary>
        public int rarity { get; set; }
        /// <summary>
        /// 技能ID
        /// </summary>
        public int skillId { get; set; }
        /// <summary>
        /// 等级上限
        /// </summary>
        public int levelLimit { get; set; }
        /// <summary>
        /// 卡片ID
        /// </summary>
        public int cardId { get; set; }
        /// <summary>
        /// 属性（颜色）
        /// </summary>
        public string attr { get; set; }
        /// <summary>
        /// Live2D资源
        /// </summary>
        public string live2dRes { get; set; }
        public int characterId { get; set; }
        public string gachaText { get; set; }
        public Training training { get; set; }
        public string cardRes { get; set; }
        public int maxLevel { get; set; }
        public int maxPerformance { get; set; }
        public int maxTechnique { get; set; }
        public int maxVisual { get; set; }
        public int totalMaxParam { get; set; }
        public Skill skill { get; set; }
    }
    public class Root
    {
        public int totalCount { get; set; }
        public IList<Card> data { get; set; }
    }
}
