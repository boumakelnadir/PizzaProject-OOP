namespace PizzaProject
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.gb_cust_type = new System.Windows.Forms.GroupBox();
            this.rb_thick_crust = new System.Windows.Forms.RadioButton();
            this.rb_thin_crust = new System.Windows.Forms.RadioButton();
            this.gb_toppings = new System.Windows.Forms.GroupBox();
            this.ckb_green_pappers = new System.Windows.Forms.CheckBox();
            this.ckb_olives = new System.Windows.Forms.CheckBox();
            this.ckb_onion = new System.Windows.Forms.CheckBox();
            this.ckb_tomatos = new System.Windows.Forms.CheckBox();
            this.ckb_mushrooms = new System.Windows.Forms.CheckBox();
            this.ckb_extra_chees = new System.Windows.Forms.CheckBox();
            this.gb_where_to_eat = new System.Windows.Forms.GroupBox();
            this.rb_eat_out = new System.Windows.Forms.RadioButton();
            this.rb_eat_in = new System.Windows.Forms.RadioButton();
            this.btn_order_pizza = new System.Windows.Forms.Button();
            this.btn_reset_form = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_order_summary_toppings = new System.Windows.Forms.Label();
            this.lb_total_price = new System.Windows.Forms.Label();
            this.lb_total_price_fixed = new System.Windows.Forms.Label();
            this.lb_where_to_eat = new System.Windows.Forms.Label();
            this.lb_where_to_eat_fixed = new System.Windows.Forms.Label();
            this.lb_order_summary_crust_type = new System.Windows.Forms.Label();
            this.lb_oreder_summary_crust_type_fixed = new System.Windows.Forms.Label();
            this.lb_order_summary_size_fixed = new System.Windows.Forms.Label();
            this.lb_oreder_summary_toppings_fixed = new System.Windows.Forms.Label();
            this.lb_order_summary_size = new System.Windows.Forms.Label();
            this.numericUpDown_pizza = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_size.SuspendLayout();
            this.gb_cust_type.SuspendLayout();
            this.gb_toppings.SuspendLayout();
            this.gb_where_to_eat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pizza)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TitleLabel.Location = new System.Drawing.Point(266, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(532, 84);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Make Your Pizza";
            // 
            // gb_size
            // 
            this.gb_size.Controls.Add(this.rb_large);
            this.gb_size.Controls.Add(this.rb_medium);
            this.gb_size.Controls.Add(this.rb_small);
            this.gb_size.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_size.Location = new System.Drawing.Point(47, 151);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(200, 158);
            this.gb_size.TabIndex = 1;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Size";
            // 
            // rb_large
            // 
            this.rb_large.AutoSize = true;
            this.rb_large.Location = new System.Drawing.Point(32, 117);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(62, 22);
            this.rb_large.TabIndex = 4;
            this.rb_large.TabStop = true;
            this.rb_large.Tag = "15";
            this.rb_large.Text = "Large";
            this.rb_large.UseVisualStyleBackColor = true;
            this.rb_large.CheckedChanged += new System.EventHandler(this.rb_large_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(32, 71);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(77, 22);
            this.rb_medium.TabIndex = 3;
            this.rb_medium.TabStop = true;
            this.rb_medium.Tag = "10";
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Checked = true;
            this.rb_small.Location = new System.Drawing.Point(32, 25);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(59, 22);
            this.rb_small.TabIndex = 2;
            this.rb_small.TabStop = true;
            this.rb_small.Tag = "5";
            this.rb_small.Text = "Small";
            this.rb_small.UseVisualStyleBackColor = true;
            this.rb_small.CheckedChanged += new System.EventHandler(this.rb_small_CheckedChanged);
            // 
            // gb_cust_type
            // 
            this.gb_cust_type.Controls.Add(this.rb_thick_crust);
            this.gb_cust_type.Controls.Add(this.rb_thin_crust);
            this.gb_cust_type.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cust_type.Location = new System.Drawing.Point(47, 360);
            this.gb_cust_type.Name = "gb_cust_type";
            this.gb_cust_type.Size = new System.Drawing.Size(200, 149);
            this.gb_cust_type.TabIndex = 2;
            this.gb_cust_type.TabStop = false;
            this.gb_cust_type.Text = "Crust Type";
            // 
            // rb_thick_crust
            // 
            this.rb_thick_crust.AutoSize = true;
            this.rb_thick_crust.Location = new System.Drawing.Point(32, 96);
            this.rb_thick_crust.Name = "rb_thick_crust";
            this.rb_thick_crust.Size = new System.Drawing.Size(99, 22);
            this.rb_thick_crust.TabIndex = 4;
            this.rb_thick_crust.TabStop = true;
            this.rb_thick_crust.Tag = "12";
            this.rb_thick_crust.Text = "Thick Crust";
            this.rb_thick_crust.UseVisualStyleBackColor = true;
            this.rb_thick_crust.CheckedChanged += new System.EventHandler(this.rb_thick_crust_CheckedChanged);
            // 
            // rb_thin_crust
            // 
            this.rb_thin_crust.AutoSize = true;
            this.rb_thin_crust.Checked = true;
            this.rb_thin_crust.Location = new System.Drawing.Point(32, 44);
            this.rb_thin_crust.Name = "rb_thin_crust";
            this.rb_thin_crust.Size = new System.Drawing.Size(93, 22);
            this.rb_thin_crust.TabIndex = 3;
            this.rb_thin_crust.TabStop = true;
            this.rb_thin_crust.Tag = "5";
            this.rb_thin_crust.Text = "Thin Crust";
            this.rb_thin_crust.UseVisualStyleBackColor = true;
            this.rb_thin_crust.CheckedChanged += new System.EventHandler(this.rb_thin_crust_CheckedChanged);
            // 
            // gb_toppings
            // 
            this.gb_toppings.Controls.Add(this.ckb_green_pappers);
            this.gb_toppings.Controls.Add(this.ckb_olives);
            this.gb_toppings.Controls.Add(this.ckb_onion);
            this.gb_toppings.Controls.Add(this.ckb_tomatos);
            this.gb_toppings.Controls.Add(this.ckb_mushrooms);
            this.gb_toppings.Controls.Add(this.ckb_extra_chees);
            this.gb_toppings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_toppings.Location = new System.Drawing.Point(343, 151);
            this.gb_toppings.Name = "gb_toppings";
            this.gb_toppings.Size = new System.Drawing.Size(348, 158);
            this.gb_toppings.TabIndex = 3;
            this.gb_toppings.TabStop = false;
            this.gb_toppings.Text = "Toppings";
            // 
            // ckb_green_pappers
            // 
            this.ckb_green_pappers.AutoSize = true;
            this.ckb_green_pappers.Location = new System.Drawing.Point(197, 117);
            this.ckb_green_pappers.Name = "ckb_green_pappers";
            this.ckb_green_pappers.Size = new System.Drawing.Size(123, 22);
            this.ckb_green_pappers.TabIndex = 5;
            this.ckb_green_pappers.Tag = "5";
            this.ckb_green_pappers.Text = "Green Pappers";
            this.ckb_green_pappers.UseVisualStyleBackColor = true;
            this.ckb_green_pappers.CheckedChanged += new System.EventHandler(this.ckb_green_pappers_CheckedChanged);
            // 
            // ckb_olives
            // 
            this.ckb_olives.AutoSize = true;
            this.ckb_olives.Location = new System.Drawing.Point(197, 76);
            this.ckb_olives.Name = "ckb_olives";
            this.ckb_olives.Size = new System.Drawing.Size(65, 22);
            this.ckb_olives.TabIndex = 4;
            this.ckb_olives.Tag = "5";
            this.ckb_olives.Text = "Olives";
            this.ckb_olives.UseVisualStyleBackColor = true;
            this.ckb_olives.CheckedChanged += new System.EventHandler(this.ckb_olives_CheckedChanged);
            // 
            // ckb_onion
            // 
            this.ckb_onion.AutoSize = true;
            this.ckb_onion.Location = new System.Drawing.Point(197, 35);
            this.ckb_onion.Name = "ckb_onion";
            this.ckb_onion.Size = new System.Drawing.Size(64, 22);
            this.ckb_onion.TabIndex = 3;
            this.ckb_onion.Tag = "5";
            this.ckb_onion.Text = "Onion";
            this.ckb_onion.UseVisualStyleBackColor = true;
            this.ckb_onion.CheckedChanged += new System.EventHandler(this.ckb_onion_CheckedChanged);
            // 
            // ckb_tomatos
            // 
            this.ckb_tomatos.AutoSize = true;
            this.ckb_tomatos.Location = new System.Drawing.Point(46, 117);
            this.ckb_tomatos.Name = "ckb_tomatos";
            this.ckb_tomatos.Size = new System.Drawing.Size(86, 22);
            this.ckb_tomatos.TabIndex = 2;
            this.ckb_tomatos.Tag = "5";
            this.ckb_tomatos.Text = "Tomatos";
            this.ckb_tomatos.UseVisualStyleBackColor = true;
            this.ckb_tomatos.CheckedChanged += new System.EventHandler(this.ckb_tomatos_CheckedChanged);
            // 
            // ckb_mushrooms
            // 
            this.ckb_mushrooms.AutoSize = true;
            this.ckb_mushrooms.Location = new System.Drawing.Point(46, 76);
            this.ckb_mushrooms.Name = "ckb_mushrooms";
            this.ckb_mushrooms.Size = new System.Drawing.Size(103, 22);
            this.ckb_mushrooms.TabIndex = 1;
            this.ckb_mushrooms.Tag = "5";
            this.ckb_mushrooms.Text = "Mushrooms";
            this.ckb_mushrooms.UseVisualStyleBackColor = true;
            this.ckb_mushrooms.CheckedChanged += new System.EventHandler(this.ckb_mushrooms_CheckedChanged);
            // 
            // ckb_extra_chees
            // 
            this.ckb_extra_chees.AutoSize = true;
            this.ckb_extra_chees.Location = new System.Drawing.Point(46, 35);
            this.ckb_extra_chees.Name = "ckb_extra_chees";
            this.ckb_extra_chees.Size = new System.Drawing.Size(106, 22);
            this.ckb_extra_chees.TabIndex = 0;
            this.ckb_extra_chees.Tag = "5";
            this.ckb_extra_chees.Text = "Extra Chees";
            this.ckb_extra_chees.UseVisualStyleBackColor = true;
            this.ckb_extra_chees.CheckedChanged += new System.EventHandler(this.ckb_extra_chees_CheckedChanged);
            // 
            // gb_where_to_eat
            // 
            this.gb_where_to_eat.Controls.Add(this.rb_eat_out);
            this.gb_where_to_eat.Controls.Add(this.rb_eat_in);
            this.gb_where_to_eat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_where_to_eat.Location = new System.Drawing.Point(366, 400);
            this.gb_where_to_eat.Name = "gb_where_to_eat";
            this.gb_where_to_eat.Size = new System.Drawing.Size(303, 69);
            this.gb_where_to_eat.TabIndex = 4;
            this.gb_where_to_eat.TabStop = false;
            this.gb_where_to_eat.Text = "Where To Eat";
            // 
            // rb_eat_out
            // 
            this.rb_eat_out.AutoSize = true;
            this.rb_eat_out.Location = new System.Drawing.Point(163, 35);
            this.rb_eat_out.Name = "rb_eat_out";
            this.rb_eat_out.Size = new System.Drawing.Size(76, 22);
            this.rb_eat_out.TabIndex = 1;
            this.rb_eat_out.TabStop = true;
            this.rb_eat_out.Tag = "7";
            this.rb_eat_out.Text = "Eat Out";
            this.rb_eat_out.UseVisualStyleBackColor = true;
            this.rb_eat_out.CheckedChanged += new System.EventHandler(this.rb_eat_out_CheckedChanged);
            // 
            // rb_eat_in
            // 
            this.rb_eat_in.AutoSize = true;
            this.rb_eat_in.Checked = true;
            this.rb_eat_in.Location = new System.Drawing.Point(24, 35);
            this.rb_eat_in.Name = "rb_eat_in";
            this.rb_eat_in.Size = new System.Drawing.Size(66, 22);
            this.rb_eat_in.TabIndex = 0;
            this.rb_eat_in.TabStop = true;
            this.rb_eat_in.Tag = "4";
            this.rb_eat_in.Text = "Eat In";
            this.rb_eat_in.UseVisualStyleBackColor = true;
            this.rb_eat_in.CheckedChanged += new System.EventHandler(this.rb_eat_in_CheckedChanged);
            // 
            // btn_order_pizza
            // 
            this.btn_order_pizza.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_pizza.Location = new System.Drawing.Point(343, 502);
            this.btn_order_pizza.Name = "btn_order_pizza";
            this.btn_order_pizza.Size = new System.Drawing.Size(154, 43);
            this.btn_order_pizza.TabIndex = 5;
            this.btn_order_pizza.Text = "Order Pizza";
            this.btn_order_pizza.UseVisualStyleBackColor = true;
            this.btn_order_pizza.Click += new System.EventHandler(this.btn_order_pizza_Click);
            // 
            // btn_reset_form
            // 
            this.btn_reset_form.Enabled = false;
            this.btn_reset_form.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_form.Location = new System.Drawing.Point(582, 502);
            this.btn_reset_form.Name = "btn_reset_form";
            this.btn_reset_form.Size = new System.Drawing.Size(154, 43);
            this.btn_reset_form.TabIndex = 6;
            this.btn_reset_form.Text = "Reset Form";
            this.btn_reset_form.UseVisualStyleBackColor = true;
            this.btn_reset_form.Click += new System.EventHandler(this.btn_reset_form_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_order_summary_toppings);
            this.groupBox2.Controls.Add(this.lb_total_price);
            this.groupBox2.Controls.Add(this.lb_total_price_fixed);
            this.groupBox2.Controls.Add(this.lb_where_to_eat);
            this.groupBox2.Controls.Add(this.lb_where_to_eat_fixed);
            this.groupBox2.Controls.Add(this.lb_order_summary_crust_type);
            this.groupBox2.Controls.Add(this.lb_oreder_summary_crust_type_fixed);
            this.groupBox2.Controls.Add(this.lb_order_summary_size_fixed);
            this.groupBox2.Controls.Add(this.lb_oreder_summary_toppings_fixed);
            this.groupBox2.Controls.Add(this.lb_order_summary_size);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(752, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 342);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lb_order_summary_toppings
            // 
            this.lb_order_summary_toppings.Location = new System.Drawing.Point(39, 95);
            this.lb_order_summary_toppings.Name = "lb_order_summary_toppings";
            this.lb_order_summary_toppings.Size = new System.Drawing.Size(297, 65);
            this.lb_order_summary_toppings.TabIndex = 10;
            this.lb_order_summary_toppings.Text = "No Toppings";
            // 
            // lb_total_price
            // 
            this.lb_total_price.AutoSize = true;
            this.lb_total_price.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_total_price.Location = new System.Drawing.Point(143, 257);
            this.lb_total_price.Name = "lb_total_price";
            this.lb_total_price.Size = new System.Drawing.Size(174, 82);
            this.lb_total_price.TabIndex = 9;
            this.lb_total_price.Text = "$15";
            // 
            // lb_total_price_fixed
            // 
            this.lb_total_price_fixed.AutoSize = true;
            this.lb_total_price_fixed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_price_fixed.Location = new System.Drawing.Point(35, 249);
            this.lb_total_price_fixed.Name = "lb_total_price_fixed";
            this.lb_total_price_fixed.Size = new System.Drawing.Size(102, 18);
            this.lb_total_price_fixed.TabIndex = 8;
            this.lb_total_price_fixed.Text = "Total Price : ";
            // 
            // lb_where_to_eat
            // 
            this.lb_where_to_eat.AutoSize = true;
            this.lb_where_to_eat.Location = new System.Drawing.Point(136, 218);
            this.lb_where_to_eat.Name = "lb_where_to_eat";
            this.lb_where_to_eat.Size = new System.Drawing.Size(53, 18);
            this.lb_where_to_eat.TabIndex = 7;
            this.lb_where_to_eat.Text = "Eat In.";
            // 
            // lb_where_to_eat_fixed
            // 
            this.lb_where_to_eat_fixed.AutoSize = true;
            this.lb_where_to_eat_fixed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_where_to_eat_fixed.Location = new System.Drawing.Point(35, 190);
            this.lb_where_to_eat_fixed.Name = "lb_where_to_eat_fixed";
            this.lb_where_to_eat_fixed.Size = new System.Drawing.Size(120, 18);
            this.lb_where_to_eat_fixed.TabIndex = 6;
            this.lb_where_to_eat_fixed.Text = "Where To Eat : ";
            // 
            // lb_order_summary_crust_type
            // 
            this.lb_order_summary_crust_type.AutoSize = true;
            this.lb_order_summary_crust_type.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summary_crust_type.Location = new System.Drawing.Point(136, 160);
            this.lb_order_summary_crust_type.Name = "lb_order_summary_crust_type";
            this.lb_order_summary_crust_type.Size = new System.Drawing.Size(75, 18);
            this.lb_order_summary_crust_type.TabIndex = 5;
            this.lb_order_summary_crust_type.Text = "Thin Crust";
            // 
            // lb_oreder_summary_crust_type_fixed
            // 
            this.lb_oreder_summary_crust_type_fixed.AutoSize = true;
            this.lb_oreder_summary_crust_type_fixed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oreder_summary_crust_type_fixed.Location = new System.Drawing.Point(39, 160);
            this.lb_oreder_summary_crust_type_fixed.Name = "lb_oreder_summary_crust_type_fixed";
            this.lb_oreder_summary_crust_type_fixed.Size = new System.Drawing.Size(101, 18);
            this.lb_oreder_summary_crust_type_fixed.TabIndex = 4;
            this.lb_oreder_summary_crust_type_fixed.Text = "Crust Type : ";
            // 
            // lb_order_summary_size_fixed
            // 
            this.lb_order_summary_size_fixed.AutoSize = true;
            this.lb_order_summary_size_fixed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summary_size_fixed.Location = new System.Drawing.Point(39, 39);
            this.lb_order_summary_size_fixed.Name = "lb_order_summary_size_fixed";
            this.lb_order_summary_size_fixed.Size = new System.Drawing.Size(53, 18);
            this.lb_order_summary_size_fixed.TabIndex = 2;
            this.lb_order_summary_size_fixed.Text = "Size : ";
            // 
            // lb_oreder_summary_toppings_fixed
            // 
            this.lb_oreder_summary_toppings_fixed.AutoSize = true;
            this.lb_oreder_summary_toppings_fixed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oreder_summary_toppings_fixed.Location = new System.Drawing.Point(39, 71);
            this.lb_oreder_summary_toppings_fixed.Name = "lb_oreder_summary_toppings_fixed";
            this.lb_oreder_summary_toppings_fixed.Size = new System.Drawing.Size(84, 18);
            this.lb_oreder_summary_toppings_fixed.TabIndex = 1;
            this.lb_oreder_summary_toppings_fixed.Text = "Toppings :";
            // 
            // lb_order_summary_size
            // 
            this.lb_order_summary_size.AutoSize = true;
            this.lb_order_summary_size.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summary_size.Location = new System.Drawing.Point(89, 39);
            this.lb_order_summary_size.Name = "lb_order_summary_size";
            this.lb_order_summary_size.Size = new System.Drawing.Size(46, 18);
            this.lb_order_summary_size.TabIndex = 0;
            this.lb_order_summary_size.Text = " Small";
            // 
            // numericUpDown_pizza
            // 
            this.numericUpDown_pizza.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_pizza.Location = new System.Drawing.Point(968, 505);
            this.numericUpDown_pizza.Name = "numericUpDown_pizza";
            this.numericUpDown_pizza.Size = new System.Drawing.Size(120, 40);
            this.numericUpDown_pizza.TabIndex = 8;
            this.numericUpDown_pizza.ValueChanged += new System.EventHandler(this.numericUpDown_pizza_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Pizza :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_pizza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_reset_form);
            this.Controls.Add(this.btn_order_pizza);
            this.Controls.Add(this.gb_where_to_eat);
            this.Controls.Add(this.gb_toppings);
            this.Controls.Add(this.gb_cust_type);
            this.Controls.Add(this.gb_size);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.gb_cust_type.ResumeLayout(false);
            this.gb_cust_type.PerformLayout();
            this.gb_toppings.ResumeLayout(false);
            this.gb_toppings.PerformLayout();
            this.gb_where_to_eat.ResumeLayout(false);
            this.gb_where_to_eat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.GroupBox gb_cust_type;
        private System.Windows.Forms.RadioButton rb_thin_crust;
        private System.Windows.Forms.RadioButton rb_thick_crust;
        private System.Windows.Forms.GroupBox gb_toppings;
        private System.Windows.Forms.CheckBox ckb_onion;
        private System.Windows.Forms.CheckBox ckb_tomatos;
        private System.Windows.Forms.CheckBox ckb_mushrooms;
        private System.Windows.Forms.CheckBox ckb_extra_chees;
        private System.Windows.Forms.CheckBox ckb_green_pappers;
        private System.Windows.Forms.CheckBox ckb_olives;
        private System.Windows.Forms.GroupBox gb_where_to_eat;
        private System.Windows.Forms.RadioButton rb_eat_out;
        private System.Windows.Forms.RadioButton rb_eat_in;
        private System.Windows.Forms.Button btn_order_pizza;
        private System.Windows.Forms.Button btn_reset_form;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.Label lb_order_summary_size;
        private System.Windows.Forms.Label lb_order_summary_size_fixed;
        private System.Windows.Forms.Label lb_oreder_summary_toppings_fixed;
        private System.Windows.Forms.Label lb_oreder_summary_crust_type_fixed;
        private System.Windows.Forms.Label lb_order_summary_crust_type;
        private System.Windows.Forms.Label lb_where_to_eat;
        private System.Windows.Forms.Label lb_where_to_eat_fixed;
        private System.Windows.Forms.Label lb_total_price;
        private System.Windows.Forms.Label lb_total_price_fixed;
        private System.Windows.Forms.Label lb_order_summary_toppings;
        private System.Windows.Forms.NumericUpDown numericUpDown_pizza;
        private System.Windows.Forms.Label label1;
    }
}

