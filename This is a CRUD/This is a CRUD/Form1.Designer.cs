namespace This_is_a_CRUD {
    partial class main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connection_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.conection_address = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.connection = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.database_input = new System.Windows.Forms.TextBox();
            this.server_input = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visualization = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parentes_view = new System.Windows.Forms.DataGridView();
            this.clientes_view = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.TabPage();
            this.drop = new System.Windows.Forms.TabPage();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rua = new System.Windows.Forms.TextBox();
            this.gf = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.connection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.visualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentes_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_view)).BeginInit();
            this.add.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connection_status,
            this.conection_address});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connection_status
            // 
            this.connection_status.Name = "connection_status";
            this.connection_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.connection_status.Size = new System.Drawing.Size(82, 17);
            this.connection_status.Text = "Desconectado";
            // 
            // conection_address
            // 
            this.conection_address.Name = "conection_address";
            this.conection_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.conection_address.Size = new System.Drawing.Size(73, 17);
            this.conection_address.Text = "User@Server";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.connection);
            this.tabControl1.Controls.Add(this.visualization);
            this.tabControl1.Controls.Add(this.add);
            this.tabControl1.Controls.Add(this.update);
            this.tabControl1.Controls.Add(this.drop);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 616);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // connection
            // 
            this.connection.AutoScroll = true;
            this.connection.Controls.Add(this.status);
            this.connection.Controls.Add(this.label4);
            this.connection.Controls.Add(this.groupBox1);
            this.connection.Controls.Add(this.groupBox2);
            this.connection.Controls.Add(this.connect);
            this.connection.Controls.Add(this.label1);
            this.connection.Location = new System.Drawing.Point(4, 22);
            this.connection.Name = "connection";
            this.connection.Padding = new System.Windows.Forms.Padding(3);
            this.connection.Size = new System.Drawing.Size(1073, 590);
            this.connection.TabIndex = 0;
            this.connection.Text = "Conexão";
            this.connection.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(127, 529);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(244, 47);
            this.status.TabIndex = 8;
            this.status.Text = "Desconectado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.password_input);
            this.groupBox1.Controls.Add(this.username_input);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais para login no servidor MySQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            // 
            // password_input
            // 
            this.password_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_input.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.password_input.Location = new System.Drawing.Point(6, 154);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(1043, 32);
            this.password_input.TabIndex = 4;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // username_input
            // 
            this.username_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_input.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.username_input.Location = new System.Drawing.Point(6, 72);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(1043, 32);
            this.username_input.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.database_input);
            this.groupBox2.Controls.Add(this.server_input);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar servidor MySQL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(1, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nome do banco de dados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "URL do servidor MySQL:";
            // 
            // database_input
            // 
            this.database_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.database_input.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.database_input.Location = new System.Drawing.Point(6, 163);
            this.database_input.Name = "database_input";
            this.database_input.Size = new System.Drawing.Size(1043, 32);
            this.database_input.TabIndex = 4;
            // 
            // server_input
            // 
            this.server_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.server_input.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.server_input.Location = new System.Drawing.Point(6, 74);
            this.server_input.Name = "server_input";
            this.server_input.Size = new System.Drawing.Size(1043, 32);
            this.server_input.TabIndex = 3;
            // 
            // connect
            // 
            this.connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(882, 513);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(177, 57);
            this.connect.TabIndex = 1;
            this.connect.Text = "Conectar";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectar-se ao banco de dados...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // visualization
            // 
            this.visualization.Controls.Add(this.label10);
            this.visualization.Controls.Add(this.refresh_btn);
            this.visualization.Controls.Add(this.label9);
            this.visualization.Controls.Add(this.label6);
            this.visualization.Controls.Add(this.parentes_view);
            this.visualization.Controls.Add(this.clientes_view);
            this.visualization.Location = new System.Drawing.Point(4, 22);
            this.visualization.Name = "visualization";
            this.visualization.Padding = new System.Windows.Forms.Padding(3);
            this.visualization.Size = new System.Drawing.Size(1073, 590);
            this.visualization.TabIndex = 1;
            this.visualization.Text = "Visualização";
            this.visualization.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Parentes:";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Enabled = false;
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(957, 53);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(108, 44);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "Atualizar";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Clientes:";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Ubuntu Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1067, 47);
            this.label6.TabIndex = 2;
            this.label6.Text = "Visualizar os dados...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parentes_view
            // 
            this.parentes_view.AllowUserToAddRows = false;
            this.parentes_view.AllowUserToDeleteRows = false;
            this.parentes_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parentes_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.parentes_view.BackgroundColor = System.Drawing.Color.White;
            this.parentes_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentes_view.Location = new System.Drawing.Point(10, 384);
            this.parentes_view.Name = "parentes_view";
            this.parentes_view.ReadOnly = true;
            this.parentes_view.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentes_view.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.parentes_view.Size = new System.Drawing.Size(1055, 200);
            this.parentes_view.TabIndex = 1;
            // 
            // clientes_view
            // 
            this.clientes_view.AllowUserToAddRows = false;
            this.clientes_view.AllowUserToDeleteRows = false;
            this.clientes_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientes_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clientes_view.BackgroundColor = System.Drawing.Color.White;
            this.clientes_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_view.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.clientes_view.Location = new System.Drawing.Point(10, 106);
            this.clientes_view.Name = "clientes_view";
            this.clientes_view.ReadOnly = true;
            this.clientes_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_view.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.clientes_view.Size = new System.Drawing.Size(1055, 241);
            this.clientes_view.TabIndex = 0;
            // 
            // add
            // 
            this.add.Controls.Add(this.clear);
            this.add.Controls.Add(this.save_btn);
            this.add.Controls.Add(this.groupBox4);
            this.add.Controls.Add(this.label7);
            this.add.Controls.Add(this.groupBox3);
            this.add.Location = new System.Drawing.Point(4, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(1073, 590);
            this.add.TabIndex = 5;
            this.add.Text = "Incluir";
            this.add.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(1073, 590);
            this.update.TabIndex = 2;
            this.update.Text = "Alteração";
            this.update.UseVisualStyleBackColor = true;
            // 
            // drop
            // 
            this.drop.Location = new System.Drawing.Point(4, 22);
            this.drop.Name = "drop";
            this.drop.Size = new System.Drawing.Size(1073, 590);
            this.drop.TabIndex = 3;
            this.drop.Text = "Excluir";
            this.drop.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(879, 451);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(186, 74);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Salvar";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sexo);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.rg);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cpf);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.full_name);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 297);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Pessoais";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Ubuntu Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1073, 60);
            this.label7.TabIndex = 4;
            this.label7.Text = "Incluir cliente:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nome completo:";
            // 
            // full_name
            // 
            this.full_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.full_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.full_name.Location = new System.Drawing.Point(20, 67);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(566, 32);
            this.full_name.TabIndex = 7;
            // 
            // cpf
            // 
            this.cpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpf.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cpf.Location = new System.Drawing.Point(20, 146);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(284, 32);
            this.cpf.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "CPF:";
            // 
            // rg
            // 
            this.rg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rg.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.rg.Location = new System.Drawing.Point(310, 146);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(276, 32);
            this.rg.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(281, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "RG:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(20, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 32);
            this.textBox1.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(293, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Telefone:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(328, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Sexo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic);
            this.groupBox4.Location = new System.Drawing.Point(7, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 186);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parentesco";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.gf);
            this.groupBox5.Controls.Add(this.bairro);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.rua);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cep);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox5.Location = new System.Drawing.Point(605, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(444, 261);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Endereço";
            // 
            // cep
            // 
            this.cep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cep.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cep.Location = new System.Drawing.Point(14, 69);
            this.cep.MaxLength = 16;
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(172, 32);
            this.cep.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(9, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "CEP:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(9, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 25);
            this.label17.TabIndex = 11;
            this.label17.Text = "Logradouro:";
            // 
            // rua
            // 
            this.rua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rua.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.rua.Location = new System.Drawing.Point(14, 145);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(285, 32);
            this.rua.TabIndex = 10;
            // 
            // gf
            // 
            this.gf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gf.AutoSize = true;
            this.gf.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.gf.Location = new System.Drawing.Point(9, 187);
            this.gf.Name = "gf";
            this.gf.Size = new System.Drawing.Size(63, 25);
            this.gf.TabIndex = 13;
            this.gf.Text = "Bairro";
            // 
            // bairro
            // 
            this.bairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bairro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.bairro.Location = new System.Drawing.Point(14, 220);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(213, 32);
            this.bairro.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(192, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 32);
            this.textBox2.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(187, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "Estado:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(228, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "Cidade";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(233, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 32);
            this.textBox3.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(303, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 25);
            this.label20.TabIndex = 19;
            this.label20.Text = "Número:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(308, 145);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 32);
            this.textBox4.TabIndex = 11;
            // 
            // sexo
            // 
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexo.Location = new System.Drawing.Point(333, 224);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(253, 33);
            this.sexo.TabIndex = 21;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(879, 538);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(186, 42);
            this.clear.TabIndex = 6;
            this.clear.Text = "Limpar todos os campos";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 638);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic CRUD :: by Luiz";
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.connection.ResumeLayout(false);
            this.connection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.visualization.ResumeLayout(false);
            this.visualization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentes_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_view)).EndInit();
            this.add.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connection_status;
        private System.Windows.Forms.ToolStripStatusLabel conection_address;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage connection;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.TabPage drop;
        private System.Windows.Forms.TabPage add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox database_input;
        private System.Windows.Forms.TextBox server_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage visualization;
        private System.Windows.Forms.DataGridView parentes_view;
        private System.Windows.Forms.DataGridView clientes_view;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label gf;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Button clear;
    }
}

