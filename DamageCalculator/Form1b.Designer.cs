namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weapon_type_label = new System.Windows.Forms.Label();
            this.weapon_class_combobox = new System.Windows.Forms.ComboBox();
            this.weapon_name_combobox = new System.Windows.Forms.ComboBox();
            this.weapon_label = new System.Windows.Forms.Label();
            this.attack_type_label = new System.Windows.Forms.Label();
            this.attack_type_combobox = new System.Windows.Forms.ComboBox();
            this.monster_combobox = new System.Windows.Forms.ComboBox();
            this.monster_label = new System.Windows.Forms.Label();
            this.hitzone_combobox = new System.Windows.Forms.ComboBox();
            this.hitzone_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.rage_combobox = new System.Windows.Forms.ComboBox();
            this.rage_label = new System.Windows.Forms.Label();
            this.final_attack_power_label = new System.Windows.Forms.Label();
            this.final_attack_power_value = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.rank_combobox = new System.Windows.Forms.ComboBox();
            this.rank_label = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.spirit_gauge_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.final_raw_power_value = new System.Windows.Forms.Label();
            this.final_elemental_power_value = new System.Windows.Forms.Label();
            this.final_raw_power_label = new System.Windows.Forms.Label();
            this.final_elemental_power_label = new System.Windows.Forms.Label();
            this.spirit_gauge_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // weapon_type_label
            // 
            this.weapon_type_label.AutoSize = true;
            this.weapon_type_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_type_label.Location = new System.Drawing.Point(12, 26);
            this.weapon_type_label.Name = "weapon_type_label";
            this.weapon_type_label.Size = new System.Drawing.Size(101, 20);
            this.weapon_type_label.TabIndex = 0;
            this.weapon_type_label.Text = "Weapon Type";
            // 
            // weapon_class_combobox
            // 
            this.weapon_class_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_class_combobox.FormattingEnabled = true;
            this.weapon_class_combobox.Location = new System.Drawing.Point(125, 26);
            this.weapon_class_combobox.Name = "weapon_class_combobox";
            this.weapon_class_combobox.Size = new System.Drawing.Size(212, 28);
            this.weapon_class_combobox.TabIndex = 1;
            this.weapon_class_combobox.SelectedIndexChanged += new System.EventHandler(this.weapon_class_combobox_SelectedIndexChanged);
            // 
            // weapon_name_combobox
            // 
            this.weapon_name_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_name_combobox.FormattingEnabled = true;
            this.weapon_name_combobox.Location = new System.Drawing.Point(125, 54);
            this.weapon_name_combobox.Name = "weapon_name_combobox";
            this.weapon_name_combobox.Size = new System.Drawing.Size(212, 28);
            this.weapon_name_combobox.TabIndex = 3;
            this.weapon_name_combobox.SelectedIndexChanged += new System.EventHandler(this.weapon_name_combobox_SelectedIndexChanged);
            // 
            // weapon_label
            // 
            this.weapon_label.AutoSize = true;
            this.weapon_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon_label.Location = new System.Drawing.Point(12, 57);
            this.weapon_label.Name = "weapon_label";
            this.weapon_label.Size = new System.Drawing.Size(65, 20);
            this.weapon_label.TabIndex = 4;
            this.weapon_label.Text = "Weapon";
            // 
            // attack_type_label
            // 
            this.attack_type_label.AutoSize = true;
            this.attack_type_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack_type_label.Location = new System.Drawing.Point(12, 85);
            this.attack_type_label.Name = "attack_type_label";
            this.attack_type_label.Size = new System.Drawing.Size(91, 20);
            this.attack_type_label.TabIndex = 5;
            this.attack_type_label.Text = "Attack Type";
            // 
            // attack_type_combobox
            // 
            this.attack_type_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attack_type_combobox.FormattingEnabled = true;
            this.attack_type_combobox.Location = new System.Drawing.Point(125, 82);
            this.attack_type_combobox.Name = "attack_type_combobox";
            this.attack_type_combobox.Size = new System.Drawing.Size(211, 28);
            this.attack_type_combobox.TabIndex = 6;
            this.attack_type_combobox.SelectedIndexChanged += new System.EventHandler(this.attack_type_combobox_SelectedIndexChanged);
            // 
            // monster_combobox
            // 
            this.monster_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monster_combobox.FormattingEnabled = true;
            this.monster_combobox.Location = new System.Drawing.Point(125, 112);
            this.monster_combobox.Name = "monster_combobox";
            this.monster_combobox.Size = new System.Drawing.Size(212, 28);
            this.monster_combobox.TabIndex = 7;
            this.monster_combobox.SelectedIndexChanged += new System.EventHandler(this.monster_combobox_SelectedIndexChanged);
            // 
            // monster_label
            // 
            this.monster_label.AutoSize = true;
            this.monster_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monster_label.Location = new System.Drawing.Point(12, 115);
            this.monster_label.Name = "monster_label";
            this.monster_label.Size = new System.Drawing.Size(64, 20);
            this.monster_label.TabIndex = 8;
            this.monster_label.Text = "Monster";
            // 
            // hitzone_combobox
            // 
            this.hitzone_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitzone_combobox.FormattingEnabled = true;
            this.hitzone_combobox.Location = new System.Drawing.Point(125, 144);
            this.hitzone_combobox.Name = "hitzone_combobox";
            this.hitzone_combobox.Size = new System.Drawing.Size(212, 28);
            this.hitzone_combobox.TabIndex = 9;
            this.hitzone_combobox.SelectedIndexChanged += new System.EventHandler(this.hitzonecombobox_SelectedIndexChanged);
            // 
            // hitzone_label
            // 
            this.hitzone_label.AutoSize = true;
            this.hitzone_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitzone_label.Location = new System.Drawing.Point(12, 147);
            this.hitzone_label.Name = "hitzone_label";
            this.hitzone_label.Size = new System.Drawing.Size(70, 20);
            this.hitzone_label.TabIndex = 10;
            this.hitzone_label.Text = "Hit Zone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weapon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "ATP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Element 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(853, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Affinity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(709, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "EATP 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(625, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Element 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(561, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "EATP 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(776, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Sharpness";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(776, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Shrpnss16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(853, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Aff17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(709, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "ETP218";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(625, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "Elmnt219";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(480, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "ETP120";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(561, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 20);
            this.label21.TabIndex = 24;
            this.label21.Text = "Elmnt121";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(434, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Atk22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(380, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 20);
            this.label23.TabIndex = 22;
            this.label23.Text = "Rar23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(380, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 20);
            this.label24.TabIndex = 21;
            this.label24.Text = "Wpn";
            // 
            // rage_combobox
            // 
            this.rage_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rage_combobox.FormattingEnabled = true;
            this.rage_combobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.rage_combobox.Location = new System.Drawing.Point(125, 175);
            this.rage_combobox.Name = "rage_combobox";
            this.rage_combobox.Size = new System.Drawing.Size(212, 28);
            this.rage_combobox.TabIndex = 30;
            this.rage_combobox.SelectedIndexChanged += new System.EventHandler(this.ragecombobox_SelectedIndexChanged);
            // 
            // rage_label
            // 
            this.rage_label.AutoSize = true;
            this.rage_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rage_label.Location = new System.Drawing.Point(12, 178);
            this.rage_label.Name = "rage_label";
            this.rage_label.Size = new System.Drawing.Size(41, 20);
            this.rage_label.TabIndex = 31;
            this.rage_label.Text = "Rage";
            // 
            // final_attack_power_label
            // 
            this.final_attack_power_label.AutoSize = true;
            this.final_attack_power_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_attack_power_label.Location = new System.Drawing.Point(15, 373);
            this.final_attack_power_label.Name = "final_attack_power_label";
            this.final_attack_power_label.Size = new System.Drawing.Size(136, 20);
            this.final_attack_power_label.TabIndex = 32;
            this.final_attack_power_label.Text = "Final Attack Power";
            // 
            // final_attack_power_value
            // 
            this.final_attack_power_value.AutoSize = true;
            this.final_attack_power_value.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_attack_power_value.Location = new System.Drawing.Point(136, 373);
            this.final_attack_power_value.Name = "final_attack_power_value";
            this.final_attack_power_value.Size = new System.Drawing.Size(58, 20);
            this.final_attack_power_value.TabIndex = 33;
            this.final_attack_power_value.Text = "Final26";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(378, 230);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 20);
            this.label27.TabIndex = 34;
            this.label27.Text = "Hitzone27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(380, 161);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 20);
            this.label28.TabIndex = 35;
            this.label28.Text = "Monster Data";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(378, 202);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 20);
            this.label29.TabIndex = 36;
            this.label29.Text = "Hitzone";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(442, 202);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 20);
            this.label30.TabIndex = 37;
            this.label30.Text = "EZone";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(442, 230);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 20);
            this.label31.TabIndex = 38;
            this.label31.Text = "EZone31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(512, 202);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 20);
            this.label32.TabIndex = 39;
            this.label32.Text = "EZone2";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(512, 230);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 20);
            this.label33.TabIndex = 40;
            this.label33.Text = "EZone33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(585, 202);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 20);
            this.label34.TabIndex = 41;
            this.label34.Text = "Sharp";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(642, 201);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(54, 20);
            this.label35.TabIndex = 42;
            this.label35.Text = "ESharp";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(585, 230);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 20);
            this.label36.TabIndex = 43;
            this.label36.Text = "Sharp36";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(642, 230);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 20);
            this.label37.TabIndex = 44;
            this.label37.Text = "ESharp37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(712, 198);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(136, 20);
            this.label38.TabIndex = 45;
            this.label38.Text = "Attack Type Power";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(713, 231);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(64, 20);
            this.label39.TabIndex = 46;
            this.label39.Text = "ATYP39";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(378, 265);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 20);
            this.label40.TabIndex = 47;
            this.label40.Text = "Critical";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(378, 291);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 20);
            this.label41.TabIndex = 48;
            this.label41.Text = "Critical41";
            // 
            // rank_combobox
            // 
            this.rank_combobox.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_combobox.FormattingEnabled = true;
            this.rank_combobox.Items.AddRange(new object[] {
            "G",
            "High",
            "Low"});
            this.rank_combobox.Location = new System.Drawing.Point(125, 203);
            this.rank_combobox.Name = "rank_combobox";
            this.rank_combobox.Size = new System.Drawing.Size(212, 28);
            this.rank_combobox.TabIndex = 49;
            this.rank_combobox.SelectedIndexChanged += new System.EventHandler(this.rankcombobox_SelectedIndexChanged);
            // 
            // rank_label
            // 
            this.rank_label.AutoSize = true;
            this.rank_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_label.Location = new System.Drawing.Point(12, 206);
            this.rank_label.Name = "rank_label";
            this.rank_label.Size = new System.Drawing.Size(90, 20);
            this.rank_label.TabIndex = 50;
            this.rank_label.Text = "What Rank?";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(444, 265);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(60, 20);
            this.label43.TabIndex = 51;
            this.label43.Text = "Defense";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(444, 291);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 20);
            this.label44.TabIndex = 52;
            this.label44.Text = "Defense44";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(518, 265);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 20);
            this.label45.TabIndex = 53;
            this.label45.Text = "Rage";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(518, 291);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(58, 20);
            this.label46.TabIndex = 54;
            this.label46.Text = "Rage46";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(572, 265);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(32, 20);
            this.label47.TabIndex = 55;
            this.label47.Text = "Var";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(575, 291);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(50, 20);
            this.label48.TabIndex = 56;
            this.label48.Text = "Var48";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(624, 265);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(63, 20);
            this.label49.TabIndex = 57;
            this.label49.Text = "ClassVar";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(624, 291);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(82, 20);
            this.label50.TabIndex = 58;
            this.label50.Text = "ClassVar50";
            // 
            // spirit_gauge_label
            // 
            this.spirit_gauge_label.AutoSize = true;
            this.spirit_gauge_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spirit_gauge_label.Location = new System.Drawing.Point(12, 256);
            this.spirit_gauge_label.Name = "spirit_gauge_label";
            this.spirit_gauge_label.Size = new System.Drawing.Size(164, 20);
            this.spirit_gauge_label.TabIndex = 60;
            this.spirit_gauge_label.Text = "Spirit Gauge? (LS Only)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // final_raw_power_value
            // 
            this.final_raw_power_value.AutoSize = true;
            this.final_raw_power_value.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_raw_power_value.Location = new System.Drawing.Point(136, 309);
            this.final_raw_power_value.Name = "final_raw_power_value";
            this.final_raw_power_value.Size = new System.Drawing.Size(56, 20);
            this.final_raw_power_value.TabIndex = 63;
            this.final_raw_power_value.Text = "label52";
            // 
            // final_elemental_power_value
            // 
            this.final_elemental_power_value.AutoSize = true;
            this.final_elemental_power_value.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_elemental_power_value.Location = new System.Drawing.Point(136, 341);
            this.final_elemental_power_value.Name = "final_elemental_power_value";
            this.final_elemental_power_value.Size = new System.Drawing.Size(55, 20);
            this.final_elemental_power_value.TabIndex = 64;
            this.final_elemental_power_value.Text = "label53";
            // 
            // final_raw_power_label
            // 
            this.final_raw_power_label.AutoSize = true;
            this.final_raw_power_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_raw_power_label.Location = new System.Drawing.Point(15, 308);
            this.final_raw_power_label.Name = "final_raw_power_label";
            this.final_raw_power_label.Size = new System.Drawing.Size(118, 20);
            this.final_raw_power_label.TabIndex = 65;
            this.final_raw_power_label.Text = "Final Raw Power";
            // 
            // final_elemental_power_label
            // 
            this.final_elemental_power_label.AutoSize = true;
            this.final_elemental_power_label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_elemental_power_label.Location = new System.Drawing.Point(15, 340);
            this.final_elemental_power_label.Name = "final_elemental_power_label";
            this.final_elemental_power_label.Size = new System.Drawing.Size(99, 20);
            this.final_elemental_power_label.TabIndex = 66;
            this.final_elemental_power_label.Text = "Final E Power";
            // 
            // spirit_gauge_checkbox
            // 
            this.spirit_gauge_checkbox.AutoSize = true;
            this.spirit_gauge_checkbox.Location = new System.Drawing.Point(183, 258);
            this.spirit_gauge_checkbox.Name = "spirit_gauge_checkbox";
            this.spirit_gauge_checkbox.Size = new System.Drawing.Size(15, 14);
            this.spirit_gauge_checkbox.TabIndex = 67;
            this.spirit_gauge_checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.spirit_gauge_checkbox);
            this.Controls.Add(this.final_elemental_power_label);
            this.Controls.Add(this.final_raw_power_label);
            this.Controls.Add(this.final_elemental_power_value);
            this.Controls.Add(this.final_raw_power_value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spirit_gauge_label);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.rank_label);
            this.Controls.Add(this.rank_combobox);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.final_attack_power_value);
            this.Controls.Add(this.final_attack_power_label);
            this.Controls.Add(this.rage_label);
            this.Controls.Add(this.rage_combobox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hitzone_label);
            this.Controls.Add(this.hitzone_combobox);
            this.Controls.Add(this.monster_label);
            this.Controls.Add(this.monster_combobox);
            this.Controls.Add(this.attack_type_combobox);
            this.Controls.Add(this.attack_type_label);
            this.Controls.Add(this.weapon_label);
            this.Controls.Add(this.weapon_name_combobox);
            this.Controls.Add(this.weapon_class_combobox);
            this.Controls.Add(this.weapon_type_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weapon_type_label;
        private System.Windows.Forms.ComboBox weapon_class_combobox;
        private System.Windows.Forms.ComboBox weapon_name_combobox;
        private System.Windows.Forms.Label weapon_label;
        private System.Windows.Forms.Label attack_type_label;
        private System.Windows.Forms.ComboBox attack_type_combobox;
        private System.Windows.Forms.ComboBox monster_combobox;
        private System.Windows.Forms.Label monster_label;
        private System.Windows.Forms.ComboBox hitzone_combobox;
        private System.Windows.Forms.Label hitzone_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox rage_combobox;
        private System.Windows.Forms.Label rage_label;
        private System.Windows.Forms.Label final_attack_power_label;
        private System.Windows.Forms.Label final_attack_power_value;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox rank_combobox;
        private System.Windows.Forms.Label rank_label;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label spirit_gauge_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label final_raw_power_value;
        private System.Windows.Forms.Label final_elemental_power_value;
        private System.Windows.Forms.Label final_raw_power_label;
        private System.Windows.Forms.Label final_elemental_power_label;
        private System.Windows.Forms.CheckBox spirit_gauge_checkbox;
    }
}

