using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using RotADemonStatsPage.Pages.Models;

namespace RotADemonStatsPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly string connectionString = @"Data Source=DESKTOP-LQ59KO4\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<DemonStats> demonStats;
        public void OnGet()
        {
            demonStats = new List<DemonStats>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [RotA Demon Stats].dbo.Sheet1$", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DemonStats demon = new DemonStats(reader.GetValue(0).ToString());
                            demon.maxHp                     = reader.GetValue(1);
                            demon.grabRange                 = reader.GetValue(2);
                            demon.preferredAttackRange      = reader.GetValue(3);
                            demon.moveSpeed                 = reader.GetValue(4);
                            demon.acceleration              = reader.GetValue(5);
                            demon.deceleration              = reader.GetValue(6);
                            demon.aggroRadius               = reader.GetValue(7);
                            demon.patrolRange               = reader.GetValue(8);
                            demon.patrolRateMin             = reader.GetValue(9);
                            demon.patrolRateMax             = reader.GetValue(10);
                            demon.hungerReducedPerMeat      = reader.GetValue(11);
                            demon.baseFearsomeness          = reader.GetValue(12);
                            demon.fearsomenessWhenAttacking = reader.GetValue(13);
                            demon.standingHeight            = reader.GetValue(14);
                            demon.sleepingHeight            = reader.GetValue(15);
                            demon.canUseWeapons             = reader.GetValue(16);
                            demon.lovesToChase              = reader.GetValue(17);
                            demon.startingHappiness         = reader.GetValue(18);
                            demon.fallbackThreshhold        = reader.GetValue(19);
                            demon.basicAttackDamage         = reader.GetValue(20);
                            demon.buildingAttackDamage      = reader.GetValue(21);
                            demon.aoeDamage                 = reader.GetValue(22);
                            demon.elementalAffinity         = reader.GetValue(23);

                            demonStats.Add(demon);
                        }
                    }
                }
            }
        }        
    }
}
