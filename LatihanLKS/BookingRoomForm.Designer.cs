namespace LatihanLKS
{
    partial class BookingRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkRoom_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.booking_room_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.booking_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guest_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guest_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.room_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.long_stay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.facility = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.minutes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.room_map_panel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkRoom_panel.SuspendLayout();
            this.booking_room_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semerbak Bunga Hotel : Booking Room Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkRoom_panel
            // 
            this.checkRoom_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkRoom_panel.Controls.Add(this.check_button);
            this.checkRoom_panel.Controls.Add(this.dateTimePicker1);
            this.checkRoom_panel.Controls.Add(this.label4);
            this.checkRoom_panel.Controls.Add(this.textBox1);
            this.checkRoom_panel.Controls.Add(this.label3);
            this.checkRoom_panel.Controls.Add(this.label2);
            this.checkRoom_panel.Location = new System.Drawing.Point(22, 49);
            this.checkRoom_panel.Name = "checkRoom_panel";
            this.checkRoom_panel.Size = new System.Drawing.Size(395, 135);
            this.checkRoom_panel.TabIndex = 3;
            this.checkRoom_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check Room Availability";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Check-in Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(304, 97);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(75, 23);
            this.check_button.TabIndex = 5;
            this.check_button.Text = "Check";
            this.check_button.UseVisualStyleBackColor = true;
            // 
            // booking_room_panel
            // 
            this.booking_room_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booking_room_panel.Controls.Add(this.dataGridView1);
            this.booking_room_panel.Controls.Add(this.add_btn);
            this.booking_room_panel.Controls.Add(this.dateTimePicker2);
            this.booking_room_panel.Controls.Add(this.label14);
            this.booking_room_panel.Controls.Add(this.minutes);
            this.booking_room_panel.Controls.Add(this.linkLabel2);
            this.booking_room_panel.Controls.Add(this.linkLabel1);
            this.booking_room_panel.Controls.Add(this.qty);
            this.booking_room_panel.Controls.Add(this.label13);
            this.booking_room_panel.Controls.Add(this.facility);
            this.booking_room_panel.Controls.Add(this.label12);
            this.booking_room_panel.Controls.Add(this.long_stay);
            this.booking_room_panel.Controls.Add(this.label11);
            this.booking_room_panel.Controls.Add(this.hour);
            this.booking_room_panel.Controls.Add(this.label10);
            this.booking_room_panel.Controls.Add(this.room_number);
            this.booking_room_panel.Controls.Add(this.label9);
            this.booking_room_panel.Controls.Add(this.guest_name);
            this.booking_room_panel.Controls.Add(this.label8);
            this.booking_room_panel.Controls.Add(this.guest_id);
            this.booking_room_panel.Controls.Add(this.label7);
            this.booking_room_panel.Controls.Add(this.booking_type);
            this.booking_room_panel.Controls.Add(this.label6);
            this.booking_room_panel.Controls.Add(this.label5);
            this.booking_room_panel.Location = new System.Drawing.Point(22, 190);
            this.booking_room_panel.Name = "booking_room_panel";
            this.booking_room_panel.Size = new System.Drawing.Size(482, 447);
            this.booking_room_panel.TabIndex = 4;
            this.booking_room_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Booking Room ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // booking_type
            // 
            this.booking_type.Location = new System.Drawing.Point(147, 34);
            this.booking_type.Name = "booking_type";
            this.booking_type.Size = new System.Drawing.Size(229, 23);
            this.booking_type.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Booking Type";
            // 
            // guest_id
            // 
            this.guest_id.Location = new System.Drawing.Point(147, 63);
            this.guest_id.Name = "guest_id";
            this.guest_id.Size = new System.Drawing.Size(120, 23);
            this.guest_id.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Guest ID";
            // 
            // guest_name
            // 
            this.guest_name.Location = new System.Drawing.Point(147, 92);
            this.guest_name.Name = "guest_name";
            this.guest_name.Size = new System.Drawing.Size(279, 23);
            this.guest_name.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Guest Name - Email";
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(147, 121);
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(120, 23);
            this.room_number.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Room Number";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(318, 150);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(45, 23);
            this.hour.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Check-In Date - Hour";
            // 
            // long_stay
            // 
            this.long_stay.Location = new System.Drawing.Point(147, 179);
            this.long_stay.Name = "long_stay";
            this.long_stay.Size = new System.Drawing.Size(72, 23);
            this.long_stay.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Long Style";
            // 
            // facility
            // 
            this.facility.Location = new System.Drawing.Point(147, 208);
            this.facility.Name = "facility";
            this.facility.Size = new System.Drawing.Size(165, 23);
            this.facility.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Additional Facility";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(147, 237);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(72, 23);
            this.qty.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Qty";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(273, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Guest";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(368, 68);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 15);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Refresh";
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(385, 150);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(45, 23);
            this.minutes.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = ":";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(165, 23);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(237, 237);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 27;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(474, 176);
            this.dataGridView1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.room_map_panel);
            this.panel2.Location = new System.Drawing.Point(510, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 459);
            this.panel2.TabIndex = 5;
            // 
            // room_map_panel
            // 
            this.room_map_panel.AutoSize = true;
            this.room_map_panel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.room_map_panel.Location = new System.Drawing.Point(3, 1);
            this.room_map_panel.Name = "room_map_panel";
            this.room_map_panel.Size = new System.Drawing.Size(81, 19);
            this.room_map_panel.TabIndex = 29;
            this.room_map_panel.Text = "Room Map";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 23);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Floor";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(55, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "00";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(55, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "00";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(197, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "00";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(9, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Note";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(136, 401);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Available";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(136, 430);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Occupied";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(270, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "In Repair";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(527, 523);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 15);
            this.label20.TabIndex = 6;
            this.label20.Text = "Room Price";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(684, 523);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 7;
            this.label21.Text = "Rp";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(708, 515);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(708, 541);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 23);
            this.textBox4.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(684, 549);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 15);
            this.label22.TabIndex = 10;
            this.label22.Text = "Rp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(527, 549);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 15);
            this.label23.TabIndex = 9;
            this.label23.Text = "Total Additional Facility";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(708, 567);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 23);
            this.textBox5.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(684, 575);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 15);
            this.label24.TabIndex = 13;
            this.label24.Text = "Rp";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(527, 575);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 15);
            this.label25.TabIndex = 12;
            this.label25.Text = "Tax";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(708, 593);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 23);
            this.textBox6.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(684, 601);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 15);
            this.label26.TabIndex = 16;
            this.label26.Text = "Rp";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(527, 601);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 15);
            this.label27.TabIndex = 15;
            this.label27.Text = "Total Price";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(768, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BookingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 657);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.booking_room_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkRoom_panel);
            this.Name = "BookingRoomForm";
            this.Text = "BookingRoomForm";
            this.Load += new System.EventHandler(this.BookingRoomForm_Load);
            this.checkRoom_panel.ResumeLayout(false);
            this.checkRoom_panel.PerformLayout();
            this.booking_room_panel.ResumeLayout(false);
            this.booking_room_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel checkRoom_panel;
        private Button check_button;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel booking_room_panel;
        private Label label5;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private TextBox qty;
        private Label label13;
        private TextBox facility;
        private Label label12;
        private TextBox long_stay;
        private Label label11;
        private TextBox hour;
        private Label label10;
        private TextBox room_number;
        private Label label9;
        private TextBox guest_name;
        private Label label8;
        private TextBox guest_id;
        private Label label7;
        private TextBox booking_type;
        private Label label6;
        private Button add_btn;
        private DateTimePicker dateTimePicker2;
        private Label label14;
        private TextBox minutes;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label room_map_panel;
        private TextBox textBox2;
        private Label label15;
        private Label label17;
        private Label label16;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label19;
        private Label label18;
        private Label label20;
        private Label label21;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label22;
        private Label label23;
        private TextBox textBox5;
        private Label label24;
        private Label label25;
        private TextBox textBox6;
        private Label label26;
        private Label label27;
        private Button button4;
    }
}