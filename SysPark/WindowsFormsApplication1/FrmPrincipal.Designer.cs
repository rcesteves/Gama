namespace WindowsFormsApplication1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convênioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cmdCaixa = new System.Windows.Forms.ToolStripDropDownButton();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.faturamentoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalistasPorPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cmdCaixa,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(756, 103);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.mensalistaToolStripMenuItem,
            this.planoToolStripMenuItem,
            this.convênioToolStripMenuItem,
            this.preçosToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 90);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.empresaToolStripMenuItem.Text = "Estacionamento";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // mensalistaToolStripMenuItem
            // 
            this.mensalistaToolStripMenuItem.Name = "mensalistaToolStripMenuItem";
            this.mensalistaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mensalistaToolStripMenuItem.Text = "Mensalista";
            this.mensalistaToolStripMenuItem.Click += new System.EventHandler(this.mensalistaToolStripMenuItem_Click);
            // 
            // planoToolStripMenuItem
            // 
            this.planoToolStripMenuItem.Name = "planoToolStripMenuItem";
            this.planoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.planoToolStripMenuItem.Text = "Plano";
            this.planoToolStripMenuItem.Click += new System.EventHandler(this.planoToolStripMenuItem_Click);
            // 
            // convênioToolStripMenuItem
            // 
            this.convênioToolStripMenuItem.Name = "convênioToolStripMenuItem";
            this.convênioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.convênioToolStripMenuItem.Text = "Convênio";
            this.convênioToolStripMenuItem.Click += new System.EventHandler(this.convênioToolStripMenuItem_Click);
            // 
            // preçosToolStripMenuItem
            // 
            this.preçosToolStripMenuItem.Name = "preçosToolStripMenuItem";
            this.preçosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.preçosToolStripMenuItem.Text = "Preços";
            this.preçosToolStripMenuItem.Click += new System.EventHandler(this.preçosToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículoToolStripMenuItem1,
            this.marcaToolStripMenuItem,
            this.tipoToolStripMenuItem});
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // veículoToolStripMenuItem1
            // 
            this.veículoToolStripMenuItem1.Name = "veículoToolStripMenuItem1";
            this.veículoToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.veículoToolStripMenuItem1.Text = "Veículo";
            this.veículoToolStripMenuItem1.Click += new System.EventHandler(this.veículoToolStripMenuItem1_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.tipoToolStripMenuItem.Text = "Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(100, 90);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cmdCaixa
            // 
            this.cmdCaixa.AutoSize = false;
            this.cmdCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturamentoToolStripMenuItem,
            this.faturamentoToolStripMenuItem1});
            this.cmdCaixa.Image = ((System.Drawing.Image)(resources.GetObject("cmdCaixa.Image")));
            this.cmdCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCaixa.Name = "cmdCaixa";
            this.cmdCaixa.Size = new System.Drawing.Size(100, 100);
            this.cmdCaixa.Text = "toolStripButton3";
            this.cmdCaixa.Click += new System.EventHandler(this.toolStripButton3_Click);
            this.cmdCaixa.DoubleClick += new System.EventHandler(this.toolStripButton3_DoubleClick);
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.faturamentoToolStripMenuItem.Text = "Caixa";
            this.faturamentoToolStripMenuItem.Click += new System.EventHandler(this.faturamentoToolStripMenuItem_Click);
            // 
            // faturamentoToolStripMenuItem1
            // 
            this.faturamentoToolStripMenuItem1.Name = "faturamentoToolStripMenuItem1";
            this.faturamentoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.faturamentoToolStripMenuItem1.Text = "Faturamento";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturamentoToolStripMenuItem2,
            this.fluxoToolStripMenuItem,
            this.mensalistasPorPlanoToolStripMenuItem});
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(90, 100);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // faturamentoToolStripMenuItem2
            // 
            this.faturamentoToolStripMenuItem2.Name = "faturamentoToolStripMenuItem2";
            this.faturamentoToolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.faturamentoToolStripMenuItem2.Text = "Faturamento";
            // 
            // fluxoToolStripMenuItem
            // 
            this.fluxoToolStripMenuItem.Name = "fluxoToolStripMenuItem";
            this.fluxoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fluxoToolStripMenuItem.Text = "Fluxo- Entrada e Saída";
            // 
            // mensalistasPorPlanoToolStripMenuItem
            // 
            this.mensalistasPorPlanoToolStripMenuItem.Name = "mensalistasPorPlanoToolStripMenuItem";
            this.mensalistasPorPlanoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mensalistasPorPlanoToolStripMenuItem.Text = "Mensalistas por Plano";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 544);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convênioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton cmdCaixa;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fluxoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensalistasPorPlanoToolStripMenuItem;
    }
}