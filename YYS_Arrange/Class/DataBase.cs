using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYS_Arrange.Class
{
    public struct HeroShowInfo
    {
        public int id;
        public int star;
        public int level;
        public double exp;
        public int count;
        public string name;
        public string rarity;
        public bool awake;
        public int born;
    }

    public class Currency
    {
        /// <summary>
        /// 体力
        /// </summary>
        public int action_point { get; set; }
        /// <summary>
        /// 现世符咒
        /// </summary>
        public int ar_amulet { get; set; }
        /// <summary>
        /// 樱饼
        /// </summary>
        public int auto_point { get; set; }
        /// <summary>
        /// 破碎的符咒
        /// </summary>
        public int broken_amulet { get; set; }
        /// <summary>
        /// 金币数量
        /// </summary>
        public int coin { get; set; }
        /// <summary>
        /// 功勋
        /// </summary>
        public int contrib { get; set; }
        /// <summary>
        /// 逢魔之魂
        /// </summary>
        public int demon_soul { get; set; }
        /// <summary>
        /// 痴念之券
        /// </summary>
        public int foolery_pass { get; set; }
        /// <summary>
        /// 金御札
        /// </summary>
        public int gold_ofuda { get; set; }
        /// <summary>
        /// 荣誉
        /// </summary>
        public int honor { get; set; }
        /// <summary>
        /// 勾玉
        /// </summary>
        public int jade { get; set; }
        /// <summary>
        /// 勋章
        /// </summary>
        public int medal { get; set; }
        /// <summary>
        /// 神秘的符咒
        /// </summary>
        public int mystery_amulet { get; set; }
        /// <summary>
        /// 御札
        /// </summary>
        public int ofuda { get; set; }
        /// <summary>
        /// 突破券
        /// </summary>
        public int realm_raid_pass { get; set; }
        /// <summary>
        /// 大蛇的逆鳞
        /// </summary>
        public int reverse_scale { get; set; }
        /// <summary>
        /// 魂玉
        /// </summary>
        public int s_jade { get; set; }
        /// <summary>
        /// 八岐大蛇鳞片
        /// </summary>
        public int scale { get; set; }
        /// <summary>
        /// 皮肤券
        /// </summary>
        public int skin_token { get; set; }
        /// <summary>
        /// SP皮肤券
        /// </summary>
        public int sp_skin_token { get; set; }
        /// <summary>
        /// 御灵境之钥
        /// </summary>
        public int totem_pass { get; set; }
    }

    public class Hero_book_shardsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int book_max_shards { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int books { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int hero_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int shards { get; set; }
    }

    public class Hero_equip_presetsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> items { get; set; }
        /// <summary>
        /// 超速狗
        /// </summary>
        public string name { get; set; }
    }

    public class AttrsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Base_attr
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Random_attr_ratesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Random_attrsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Hero_equipsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<AttrsItem> attrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Base_attr base_attr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int born { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int equip_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string garbage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @lock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int quality { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Random_attr_ratesItem> random_attr_rates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Random_attrsItem> random_attrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AttrsItem> single_attrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_id { get; set; }
    }

    public class Attack
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Crit_power
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Crit_rate
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Defense
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Max_hp
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Speed
    {
        /// <summary>
        /// 
        /// </summary>
        public double add_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double add_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double @base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class Attrs
    {
        /// <summary>
        /// 
        /// </summary>
        public Attack attack { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Crit_power crit_power { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Crit_rate crit_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Defense defense { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double effect_hit_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double effect_resist_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Max_hp max_hp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Speed speed { get; set; }
    }

    public class SkillsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
    }

    public class HeroesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Attrs attrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool awake { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int born { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> equips { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double exp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int hero_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @lock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nick_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rarity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SkillsItem> skills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int star { get; set; }
    }

    public class Player
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
        /// <summary>
        /// 云上的日子
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int server_id { get; set; }
    }

    public class Realm_cardsAttrs
    {
        /// <summary>
        /// 
        /// </summary>
        public int bonus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int exp { get; set; }
    }

    public class Realm_cardsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Realm_cardsAttrs attrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total_time { get; set; }
    }

    public class Progress
    {
        /// <summary>
        /// 
        /// </summary>
        public int max_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int value { get; set; }
    }

    public class Story_tasksItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Progress progress { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public Currency currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Hero_book_shardsItem> hero_book_shards { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Hero_equip_presetsItem> hero_equip_presets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Hero_equipsItem> hero_equips { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<HeroesItem> heroes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Player player { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Realm_cardsItem> realm_cards { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Story_tasksItem> story_tasks { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string version { get; set; }
    }
}
