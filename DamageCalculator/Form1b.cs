using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        float VAR, CLASSVAR, ATP, EATP1, EATP2, Affinity, TYPE, RawSharpness, ElementalSharpness, CRITICAL, RAGE, HITZONE, EZONE1, EZONE2, DEFENSE;
        float DIVIDER = 10;
        float FINALPOWER;
        float LANCEBLOW = 1;
        float LANCECUT = 1;
        
        string ELEMENT1, ELEMENT2, SharpColour, MONSTERNAMEVAR, WeaponClass;

        Weapon weapon = new Weapon();
        Monster monster = new Monster();

        public Form1()
        {
            InitializeComponent();
        }

        public int n;
        public string uniq;

        private void Form1_Load(object sender, EventArgs e)
        {
            load_weapon_classes_combobox();
            load_monster_combobox();
        }

        private String GetAppPath()
        {
            DirectoryInfo drty = new DirectoryInfo(System.Windows.Forms.Application.ExecutablePath);
            return (drty.Parent.FullName);
        }

        private DataTable load_from_database(string command_text)
        {
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = command_text;
            da.Fill(dt);
            con.Close();

            return dt;
        }

        private void load_weapon_classes_combobox()
        {
            DataTable dt = load_from_database("SELECT WeaponClass FROM ClassData");

            n = int.Parse(dt.Rows.Count.ToString());
            for (int i = 0; i < n; i++) // For loop, using i +1
            {
                if (!weapon_class_combobox.Items.Contains(dt.Rows[i][0].ToString())) // if the next item is not the same as the last one,
                {
                    weapon_class_combobox.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void weapon_class_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon.type = weapon_class_combobox.SelectedItem.ToString();
            weapon_name_combobox.Items.Clear();
            attack_type_combobox.Items.Clear();
            load_weapon_names_combobox();
        }

        private void load_weapon_names_combobox()
        { 
            
            DataTable dt = load_from_database("SELECT Weapon FROM WeaponData WHERE Class LIKE '" + weapon.type + "'");
            
            n = int.Parse(dt.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                weapon_name_combobox.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void weapon_name_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attack_type_combobox.Items.Clear();
            weapon.name = weapon_name_combobox.SelectedItem.ToString();
            get_weapon_data();
            load_attack_type_combobox();
        }

        private void load_attack_type_combobox()
        {
            DataTable dt = load_from_database("SELECT Attack FROM ClassData WHERE WeaponClass LIKE '" + weapon.type + "'");

            n = int.Parse(dt.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                attack_type_combobox.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void attack_type_combobox_SelectedIndexChanged(object sender, EventArgs e) // Load attack power and store with attack type
        {
            weapon.attack_type = attack_type_combobox.SelectedItem.ToString();
            
            DataTable dt = load_from_database("SELECT Power FROM ClassData WHERE Attack LIKE '" + weapon.attack_type + "' AND WeaponClass LIKE '" + weapon.type + "'");
            weapon.attack_power = float.Parse(dt.Rows[0][0].ToString());
        }

        private void get_weapon_data()
        {
            DataTable dt1 = load_from_database("select * from WeaponData where Class like '" + weapon_class_combobox.Text + "' and Weapon like '" + weapon_name_combobox.Text + "'");

            weapon.raw_attack = float.Parse(dt1.Rows[0][3].ToString());
            weapon.element_1 = dt1.Rows[0][4].ToString();
            weapon.elemental_attack_1 = float.Parse(dt1.Rows[0][5].ToString());
            weapon.element_2 = dt1.Rows[0][6].ToString();
            weapon.elemental_attack_2 = float.Parse(dt1.Rows[0][7].ToString());
            weapon.sharp_colour = dt1.Rows[0][10].ToString();
            weapon.affinity = float.Parse(dt1.Rows[0][11].ToString());

            get_sharpness_values();
            weapon.crit = critical_value();
        }

        private void get_sharpness_values()
        {
            Dictionary<string, float> RawSharp = new Dictionary<string, float>()
            {
                { "Purple", 1.5F},
                { "White", 1.3F},
                { "Blue", 1.25F},
                { "Green", 1.125F},
                { "Yellow", 1F},
                { "Orange", 0.75F},
                { "Red", 0.5F}
            };

            Dictionary<string, float> ElementalSharp = new Dictionary<string, float>()
            {
                { "Purple", 1.2F},
                { "White", 1.125F},
                { "Blue", 1.25F},
                { "Green", 1.125F},
                { "Yellow", 1F},
                { "Orange", 0.75F},
                { "Red", 0.5F}
            };

            weapon.raw_sharp_value = RawSharp[weapon.sharp_colour];
            weapon.elemental_sharp_value = ElementalSharp[weapon.sharp_colour];
        }

        private float critical_value()
        {
            if (Affinity >= 0)
            {
                return 1.25F;
            }
            else if (Affinity <= 0)
            {
                return 0.75F;
            }
            else
            {
                return 1;
            }
        }
        
        private void load_monster_combobox()
        {
            DataTable dt = load_from_database("SELECT Monsters FROM MonsterData ORDER BY Monsters");

            n = int.Parse(dt.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                if (!monster_combobox.Items.Contains(dt.Rows[i][0].ToString()))
                {
                    monster_combobox.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void monster_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hitzone_combobox.Items.Clear();
            monster.name = monster_combobox.SelectedItem.ToString();
        }

        private void load_hitzone_combobox()
        {  
            DataTable dt = load_from_database("SELECT Hitzone FROM MonsterData WHERE Monsters LIKE '" + monster.name + "'");
            
            n = int.Parse(dt.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                if (dt.Rows[i][0].ToString() == monster_combobox.SelectedItem.ToString())
                {
                    hitzone_combobox.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void ragecombobox_SelectedIndexChanged(object sender, EventArgs e) // LOAD AND STORE RAGE DATA
        {
            DataTable dt = load_from_database("select Monster, RageMulti from RageData order by Monster");

            if (rage_combobox.Text == "Yes")
            {
                n = int.Parse(dt.Rows.Count.ToString());

                for (int i = 0; i < n; i++)
                {
                    if (MONSTERNAMEVAR == dt.Rows[i][0].ToString())
                    {
                        RAGE = float.Parse(dt.Rows[i][1].ToString());
                        label46.Text = RAGE.ToString();
                    }
                }
            }
            else
            {
                RAGE = 1;
                label46.Text = RAGE.ToString();
            }

        }

        private void hitzonecombobox_SelectedIndexChanged(object sender, EventArgs e) // METHODS FOR HITZONES AND SHARPNESS
        {
            load_raw_hitzone();
            load_elemental_hitzone();
        }

        private void rankcombobox_SelectedIndexChanged(object sender, EventArgs e) // Calculating Defense
        {
            if (rank_combobox.Text == "G")
            {
                DEFENSE = 0.7F;
            }
            if (rank_combobox.Text == "High")
            {
                DEFENSE = 0.85F;
            }
            if (rank_combobox.Text == "Low")
            {
                DEFENSE = 1F;
            }
            label44.Text = DEFENSE.ToString();
        }

        private void load_raw_hitzone() // LOAD AND STORE RAW HITZONE VALUES
        {
            DataTable dt = load_from_database("select * from MonsterData order by Monsters");

            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if ((dt.Rows[i][0].ToString() == monster_combobox.SelectedItem.ToString()) &&  (dt.Rows[i][1].ToString() == hitzone_combobox.SelectedItem.ToString()))//if the next item is the same as the last one,
                {
                    //This section is the one I just added to choose between cut or blow impact for the different attack hitzones.

                    if ((WeaponClass == "SnS") || (WeaponClass == "GS") || (WeaponClass == "LS") || (WeaponClass == "DS") || (WeaponClass == "GL"))
                    {
                        HITZONE = float.Parse(dt.Rows[i][2].ToString()); //For Cut
                    }

                    if ((WeaponClass == "HH") || (WeaponClass == "Hammer")) //HH and Hammer
                    {
                        HITZONE = float.Parse(dt.Rows[i][3].ToString());
                    }

                    if ((WeaponClass == "Lance"))   //Lance
                        {
                        if (float.Parse(dt.Rows[i][2].ToString()) >= float.Parse(dt.Rows[i][3].ToString()))
                            {
                                HITZONE = float.Parse(dt.Rows[i][2].ToString());
                                LANCECUT = 1.5F;
                            }
                        else
                            {
                                HITZONE = float.Parse(dt.Rows[i][3].ToString());
                                LANCEBLOW = 1.5F;
                            }
                    
                        }
                    }
                }
        }

        private void load_elemental_hitzone() // LOAD AND STORE ELEMENTAL HITZONE VALUES
        {
            DataTable dt = load_from_database("select * from MonsterData order by Monsters");

            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if ((dt.Rows[i][0].ToString() == monster_combobox.SelectedItem.ToString())  &&  (dt.Rows[i][1].ToString() == hitzone_combobox.SelectedItem.ToString())) //if the next item is the same as the last one,
                {
                    //EZONE1
                    if (ELEMENT1 == "Fire")
                    {
                        EZONE1 = float.Parse(dt.Rows[i][4].ToString());
                        label31.Text = EZONE1.ToString();
                    }
                    if (ELEMENT1 == "Water")
                    {
                        EZONE1 = float.Parse(dt.Rows[i][5].ToString());
                        label31.Text = EZONE1.ToString();
                    }
                    if (ELEMENT1 == "Thunder")
                    {
                        EZONE1 = float.Parse(dt.Rows[i][6].ToString());
                        label31.Text = EZONE1.ToString();
                    }
                    if (ELEMENT1 == "Dragon")
                    {
                        EZONE1 = float.Parse(dt.Rows[i][7].ToString());
                        label31.Text = EZONE1.ToString();
                    }
                    if (ELEMENT1 == "Ice")
                    {
                        EZONE1 = float.Parse(dt.Rows[i][8].ToString());
                        label31.Text = EZONE1.ToString();
                    }
                    if ((ELEMENT1 == "Null") || (ELEMENT1 == "Sleep") || (ELEMENT1 == "Poison") || (ELEMENT1 == "Paralyze"))
                    {
                        EZONE1 = 1;
                        label31.Text = EZONE1.ToString();
                    }

                    //EZONE 2
                    if (ELEMENT2 == "Fire")
                    {
                        EZONE2 = float.Parse(dt.Rows[i][4].ToString());
                        label33.Text = EZONE2.ToString();
                    }
                    if (ELEMENT2 == "Water")
                    {
                        EZONE2 = float.Parse(dt.Rows[i][5].ToString());
                        label33.Text = EZONE2.ToString();
                    }
                    if (ELEMENT2 == "Thunder")
                    {
                        EZONE2 = float.Parse(dt.Rows[i][6].ToString());
                        label33.Text = EZONE2.ToString();
                    }
                    if (ELEMENT2 == "Dragon")
                    {
                        EZONE2 = float.Parse(dt.Rows[i][7].ToString());
                        label33.Text = EZONE2.ToString();
                    }
                    if (ELEMENT2 == "Ice")
                    {
                        EZONE2 = float.Parse(dt.Rows[i][8].ToString());
                        label33.Text = EZONE2.ToString();
                    }
                    if ((ELEMENT2 == "Null") || (ELEMENT2 == "Sleep") || (ELEMENT2 == "Poison") || (ELEMENT2 == "Paralyze"))
                    {
                        EZONE2 = 1;
                        label33.Text = EZONE2.ToString();
                    }
                }
            }
        }

        private void class_var() // LOADS CLASSVAR (VAR IN GUIDE)
        {
            if ((WeaponClass == "Lance") && (LANCEBLOW == 1.5) && ((attack_type_combobox.Text == "Normal Stab") || (attack_type_combobox.Text == "Upward Stab") || (attack_type_combobox.Text == "Unsheathe")))
            {
                CLASSVAR = 0.72F;
                label50.Text = CLASSVAR.ToString();
            }
            if (attack_type_combobox.Text == "Lvl 1 Charge")
            {
                CLASSVAR = 1.10F;
                label50.Text = CLASSVAR.ToString();
            }
            if (attack_type_combobox.Text == "Lvl 2 Charge")
            {
                CLASSVAR = 1.20F;
                label50.Text = CLASSVAR.ToString();
            }
            if (attack_type_combobox.Text == "Lvl 3 Charge")
            {
                CLASSVAR = 1.30F;
                label50.Text = CLASSVAR.ToString();
            }
            if ((WeaponClass == "LS") && (spirit_gauge_checkbox.Checked == true))
            {
                CLASSVAR = 1.12F;
                label50.Text = CLASSVAR.ToString();
            }
            if ((spirit_gauge_checkbox.Checked == false) && (WeaponClass == "LS"))
            {
                CLASSVAR = 1.05F;
                label50.Text = CLASSVAR.ToString();
            }

            else
            {
                label50.Text = CLASSVAR.ToString();
            }
            
        }
        
        private void CalculateFinalValue()
        {
            float FINALRAWPOWER, FINALEPOWER;
            
            FINALRAWPOWER = (((ATP) * (TYPE) * CRITICAL * (RawSharpness) * (HITZONE/100) * (DEFENSE) * (RAGE) * (CLASSVAR))/(VAR));
            FINALEPOWER = (((EATP1 * ElementalSharpness * (EZONE1 / 100) * DEFENSE * RAGE * CLASSVAR) / DIVIDER) + ((EATP2 * ElementalSharpness * (EZONE2 / 100) * DEFENSE * RAGE * CLASSVAR) / 10));
            final_raw_power_value.Text = FINALRAWPOWER.ToString();
            final_elemental_power_value.Text = FINALEPOWER.ToString();
            FINALPOWER = (FINALRAWPOWER + FINALEPOWER);
            final_attack_power_value.Text = FINALPOWER.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFinalValue();
        }
    }

    
    public class Weapon
    {
        public string name, type, attack_type, sharp_colour, element_1, element_2;
        public float type_var, attack_power, raw_attack, elemental_attack_1, elemental_attack_2, affinity, raw_sharp_value, elemental_sharp_value;

        public float crit;
    }


    public class Monster
    {
        public string name, hitzone;
    }
}