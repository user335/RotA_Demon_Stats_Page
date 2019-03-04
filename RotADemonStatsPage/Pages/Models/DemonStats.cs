using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotADemonStatsPage.Pages.Models
{
    public class DemonStats
    {
        public DemonStats(String demonName)
        {
            this.demonName = demonName;
        }
        public string demonName { get; set; }
        public object maxHp { get; set; }
        public object grabRange { get; set; }
        public object preferredAttackRange { get; set; }
        public object moveSpeed { get; set; }
        public object acceleration { get; set; }
        public object deceleration { get; set; }
        public object aggroRadius { get; set; }
        public object patrolRange { get; set; }
        public object patrolRateMin { get; set; }
        public object patrolRateMax { get; set; }
        public object hungerReducedPerMeat { get; set; }
        public object baseFearsomeness { get; set; }
        public object fearsomenessWhenAttacking { get; set; }
        public object standingHeight { get; set; }
        public object sleepingHeight { get; set; }
        public object  canUseWeapons { get; set; }
        public object  lovesToChase { get; set; }
        public object startingHappiness { get; set; }
        public object fallbackThreshhold { get; set; }
        public object basicAttackDamage { get; set; }
        public object buildingAttackDamage { get; set; }
        public object aoeDamage { get; set; }
        public object  elementalAffinity { get; set; }
    }          
}
