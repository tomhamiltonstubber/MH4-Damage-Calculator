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
        float ATP,TYPE,CRITICAL,SHARP,HITZONE,DEFENSE,RAGE,VAR,CLASSVAR;
        float EATP1,EATP2,ESHARP,EZONE;
        float DIVIDER = 10;
        float FINALPOWER;

        string WCLASS,ELEMENT1, ELEMENT2, SHARPC;
        
        public Form1()
        {
            InitializeComponent();
        }

        public int n;
        public string uniq;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcombo1();
            loadcombo4();
        }
        private String GetAppPath()
        {
            DirectoryInfo drty = new DirectoryInfo(System.Windows.Forms.Application.ExecutablePath);
            return (drty.Parent.FullName);
        }

        private void loadcombo1()
        {
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = "select WeaponClass from ClassData";
            da.Fill(dt);

            uniq = dt.Rows[0][0].ToString(); //Defines Uniq as the first grid ref as a string
            comboBox1.Items.Add(uniq); //Adding Uniq to combolist
            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if (dt.Rows[i][0].ToString()==uniq) //if the next item is the same as the last one,
                {
                    //nothing
                }
                else
                {
                    comboBox1.Items.Add(dt.Rows[i][0].ToString()); //else add the item (add the reference as a string)
                    WCLASS = comboBox1.SelectedItem.ToString();
                }
                uniq = dt.Rows[i][0].ToString(); //redefine uniq as the current item.
            }

            con.Close(); 
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            loadcombo1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = "select Class,Weapon from WeaponData";
            da.Fill(dt);

            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if (dt.Rows[i][0].ToString() == comboBox1.SelectedItem.ToString()) //if the next item is the same as the last one,
                {
                    comboBox2.Items.Add(dt.Rows[i][1].ToString()); //If item at grid ref i,0 = combobox1, then add grid ref i,1.
                }
                else
                {
                    //nufink
                }

            }

            con.Close(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = "select WeaponClass,Attack from ClassData";
            da.Fill(dt);

            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if (dt.Rows[i][0].ToString() == comboBox1.SelectedItem.ToString()) //if the next item is the same as the last one,
                {
                    comboBox3.Items.Add(dt.Rows[i][1].ToString()); //If item at grid ref i,0 = combobox1, then add grid ref i,1.
                }
                else
                {
                    //nufink
                }

            }

            con.Close();


            OleDbConnection con1 = new OleDbConnection("");
            OleDbDataAdapter da1 = new OleDbDataAdapter("", con);
            DataTable dt1 = new DataTable();
            con1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con1.Open();
            da1.SelectCommand.CommandText = "select * from WeaponData where Class like '"+comboBox1.Text+"' and Weapon like '"+comboBox2.Text+"'";
            da1.Fill(dt1);

            label24.Text = dt1.Rows[0][1].ToString(); //WEAPON
            label23.Text = dt1.Rows[0][2].ToString(); //RARITY
            label22.Text = dt1.Rows[0][3].ToString(); //ATP
            label21.Text = dt1.Rows[0][4].ToString(); //ELEMENT 1
            label20.Text = dt1.Rows[0][5].ToString(); //EATP1
            label19.Text = dt1.Rows[0][6].ToString(); //ELEMENT 2
            label18.Text = dt1.Rows[0][7].ToString(); //EATP2
            label16.Text = dt1.Rows[0][10].ToString(); //SHARPC
            label17.Text = dt1.Rows[0][11].ToString(); //AFFINITY
            
            ATP = float.Parse(dt1.Rows[0][3].ToString());
            ELEMENT1 = dt1.Rows[0][4].ToString();
            ELEMENT2 = dt1.Rows[0][6].ToString();
            EATP1 = float.Parse(dt1.Rows[0][5].ToString());
            EATP2 = float.Parse(dt1.Rows[0][7].ToString());
            SHARPC = dt1.Rows[0][10].ToString();
            
            con1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void loadcombo4()
        {
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = "select Monsters from MonsterData order by Monsters";
            da.Fill(dt);

            uniq = dt.Rows[0][0].ToString(); //Defines Uniq as the first grid ref as a string
            comboBox4.Items.Add(uniq); //Adding Uniq to combolist
            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if (dt.Rows[i][0].ToString() == uniq) //if the next item is the same as the last one,
                {
                    //nothing
                }
                else
                {
                    comboBox4.Items.Add(dt.Rows[i][0].ToString()); //else add the item (add the reference as a string)
                }
                uniq = dt.Rows[i][0].ToString(); //redefine uniq as the current item.
            }

            con.Close(); 
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            OleDbConnection con = new OleDbConnection("");
            OleDbDataAdapter da = new OleDbDataAdapter("", con);
            DataTable dt = new DataTable();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GetAppPath() + "\\DamageCalculator.mdb";
            con.Open();
            da.SelectCommand.CommandText = "select Monsters,Hitzone from MonsterData order by Monsters";
            da.Fill(dt);

            n = int.Parse(dt.Rows.Count.ToString()); //transforms string into int(rows-count-tostring) need to transform count into string before int
            for (int i = 0; i < n; i++) //For loop, using i +1
            {
                if (dt.Rows[i][0].ToString() == comboBox4.SelectedItem.ToString()) //if the next item is the same as the last one,
                {
                    comboBox5.Items.Add(dt.Rows[i][1].ToString()); //If item at grid ref i,0 = combobox1, then add grid ref i,1.
                    if ((WCLASS == "SnS") || (WCLASS == "GS") || (WCLASS == "LS") || (WCLASS == "DS") || (WCLASS == "GL"))
                    {
                        HITZONE = float.Parse(dt.Rows[i][2].ToString()); //For Cut
                    }

                    else
                    {
                        if ((WCLASS == "Lance"))   //Lance
                        {
                            if (float.Parse(dt.Rows[i][2].ToString()) >= float.Parse(dt.Rows[i][3].ToString()))
                            {
                                HITZONE = float.Parse(dt.Rows[i][2].ToString());
                            }
                            else
                            {
                                HITZONE = float.Parse(dt.Rows[i][3].ToString());
                            }
                            if ((WCLASS == "HH") || (WCLASS == "Hammer")) //HH and Hammer
                            {
                                HITZONE = float.Parse(dt.Rows[i][3].ToString());
                            }


                        }
                    }
                }
            }
            con.Close(); 
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

    }
}
