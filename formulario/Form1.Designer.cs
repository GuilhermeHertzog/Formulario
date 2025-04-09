namespace formulario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultimaLigacaoLabel;
            System.Windows.Forms.Label contatoIdLabel1;
            this.BoxLogo = new System.Windows.Forms.PictureBox();
            this.databaseDataSet = new formulario.DatabaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new formulario.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new formulario.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.contatoIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DataContatoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nomeLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultimaLigacaoLabel = new System.Windows.Forms.Label();
            contatoIdLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            resources.ApplyResources(nomeLabel, "nomeLabel");
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.ForeColor = System.Drawing.Color.Black;
            nomeLabel.Name = "nomeLabel";
            // 
            // empresaLabel
            // 
            resources.ApplyResources(empresaLabel, "empresaLabel");
            empresaLabel.BackColor = System.Drawing.Color.Transparent;
            empresaLabel.ForeColor = System.Drawing.Color.Black;
            empresaLabel.Name = "empresaLabel";
            // 
            // telefoneLabel
            // 
            resources.ApplyResources(telefoneLabel, "telefoneLabel");
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.ForeColor = System.Drawing.Color.Black;
            telefoneLabel.Name = "telefoneLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.Name = "emailLabel";
            // 
            // clienteLabel
            // 
            resources.ApplyResources(clienteLabel, "clienteLabel");
            clienteLabel.BackColor = System.Drawing.Color.Transparent;
            clienteLabel.ForeColor = System.Drawing.Color.Black;
            clienteLabel.Name = "clienteLabel";
            // 
            // ultimaLigacaoLabel
            // 
            resources.ApplyResources(ultimaLigacaoLabel, "ultimaLigacaoLabel");
            ultimaLigacaoLabel.BackColor = System.Drawing.Color.Transparent;
            ultimaLigacaoLabel.ForeColor = System.Drawing.Color.Black;
            ultimaLigacaoLabel.Name = "ultimaLigacaoLabel";
            // 
            // BoxLogo
            // 
            resources.ApplyResources(this.BoxLogo, "BoxLogo");
            this.BoxLogo.Name = "BoxLogo";
            this.BoxLogo.TabStop = false;
            this.BoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = formulario.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            resources.ApplyResources(this.tableBindingNavigator, "tableBindingNavigator");
            this.tableBindingNavigator.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tableBindingNavigatorSaveItem, "tableBindingNavigatorSaveItem");
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nome", true));
            resources.ApplyResources(this.nomeTextBox, "nomeTextBox");
            this.nomeTextBox.Name = "nomeTextBox";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Empresa", true));
            resources.ApplyResources(this.empresaTextBox, "empresaTextBox");
            this.empresaTextBox.Name = "empresaTextBox";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Telefone", true));
            resources.ApplyResources(this.telefoneTextBox, "telefoneTextBox");
            this.telefoneTextBox.Name = "telefoneTextBox";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email", true));
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Cliente", true));
            resources.ApplyResources(this.clienteCheckBox, "clienteCheckBox");
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.labelTitulo, "labelTitulo");
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // contatoIdLabel1
            // 
            resources.ApplyResources(contatoIdLabel1, "contatoIdLabel1");
            contatoIdLabel1.Name = "contatoIdLabel1";
            // 
            // contatoIdMaskedTextBox
            // 
            this.contatoIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ContatoId", true));
            resources.ApplyResources(this.contatoIdMaskedTextBox, "contatoIdMaskedTextBox");
            this.contatoIdMaskedTextBox.Name = "contatoIdMaskedTextBox";
            this.contatoIdMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.contatoIdMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.contatoIdMaskedTextBox_MaskInputRejected);
            // 
            // DataContatoMaskedTextBox
            // 
            this.DataContatoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "UltimaLigacao", true));
            resources.ApplyResources(this.DataContatoMaskedTextBox, "DataContatoMaskedTextBox");
            this.DataContatoMaskedTextBox.Name = "DataContatoMaskedTextBox";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DataContatoMaskedTextBox);
            this.Controls.Add(contatoIdLabel1);
            this.Controls.Add(this.contatoIdMaskedTextBox);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(ultimaLigacaoLabel);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.BoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FormTela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxLogo;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.MaskedTextBox contatoIdMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox DataContatoMaskedTextBox;
    }
}

