<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        TBregistro = New TextBox()
        BTcrear = New Button()
        BTborrar = New Button()
        BTbuscar = New Button()
        BTactualizar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CBregistro = New CheckBox()
        CBXmodelo = New ComboBox()
        CBXcolor = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 32)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(357, 387)
        DataGridView1.StandardTab = True
        DataGridView1.TabIndex = 0
        DataGridView1.TabStop = False
        ' 
        ' TBregistro
        ' 
        TBregistro.Location = New Point(408, 65)
        TBregistro.Name = "TBregistro"
        TBregistro.Size = New Size(119, 23)
        TBregistro.TabIndex = 1
        ' 
        ' BTcrear
        ' 
        BTcrear.AutoSize = True
        BTcrear.Location = New Point(420, 220)
        BTcrear.Name = "BTcrear"
        BTcrear.Size = New Size(124, 86)
        BTcrear.TabIndex = 4
        BTcrear.Text = "Insertar"
        BTcrear.UseVisualStyleBackColor = True
        ' 
        ' BTborrar
        ' 
        BTborrar.AutoSize = True
        BTborrar.Location = New Point(420, 312)
        BTborrar.Name = "BTborrar"
        BTborrar.Size = New Size(124, 86)
        BTborrar.TabIndex = 5
        BTborrar.Text = "Borrar"
        BTborrar.UseVisualStyleBackColor = True
        ' 
        ' BTbuscar
        ' 
        BTbuscar.AutoSize = True
        BTbuscar.Location = New Point(550, 312)
        BTbuscar.Name = "BTbuscar"
        BTbuscar.Size = New Size(124, 86)
        BTbuscar.TabIndex = 6
        BTbuscar.Text = "Buscar"
        BTbuscar.UseVisualStyleBackColor = True
        ' 
        ' BTactualizar
        ' 
        BTactualizar.AutoSize = True
        BTactualizar.Location = New Point(550, 220)
        BTactualizar.Name = "BTactualizar"
        BTactualizar.Size = New Size(124, 86)
        BTactualizar.TabIndex = 7
        BTactualizar.Text = "Actualizar"
        BTactualizar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(442, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 8
        Label1.Text = "Registro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(442, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 9
        Label2.Text = "Modelo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(442, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 10
        Label3.Text = "Color"
        ' 
        ' CBregistro
        ' 
        CBregistro.AutoSize = True
        CBregistro.Checked = True
        CBregistro.CheckState = CheckState.Checked
        CBregistro.Location = New Point(533, 65)
        CBregistro.Name = "CBregistro"
        CBregistro.Size = New Size(94, 19)
        CBregistro.TabIndex = 13
        CBregistro.TabStop = False
        CBregistro.Text = "Auto Conteo"
        CBregistro.UseVisualStyleBackColor = True
        ' 
        ' CBXmodelo
        ' 
        CBXmodelo.FormattingEnabled = True
        CBXmodelo.Items.AddRange(New Object() {"P. Petalo", "P. Menta", "P. Negro", "P. Uva", "P. Olivo", "P. Chocolate", "P. Tan", "P. Lila", "P. Fucsia", "P. Lavanda", "P. Celeste", "P. Granate", "P. Rojo", "P. Blush Perlizado", "P. Inox Perlizado", "P. Blue Perlizado", "P. Rosa Perlizado", "P. Perla", "P. Oro Rosado", "P. Met. Plata", "P. Met. Lingote", "P. Met. Fucsia", "P. Met. Turquesa", "P. Met. Rojo", "P. Met. Cuarzo"})
        CBXmodelo.Location = New Point(408, 107)
        CBXmodelo.Name = "CBXmodelo"
        CBXmodelo.Size = New Size(121, 23)
        CBXmodelo.TabIndex = 14
        ' 
        ' CBXcolor
        ' 
        CBXcolor.FormattingEnabled = True
        CBXcolor.Items.AddRange(New Object() {"Monedero", "Slim", "Petit", "Petit Plus", "Clasic", "Clasic Plus", "Neceser"})
        CBXcolor.Location = New Point(408, 150)
        CBXcolor.Name = "CBXcolor"
        CBXcolor.Size = New Size(121, 23)
        CBXcolor.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        AutoSize = True
        ClientSize = New Size(704, 450)
        Controls.Add(CBXcolor)
        Controls.Add(CBXmodelo)
        Controls.Add(CBregistro)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BTactualizar)
        Controls.Add(BTbuscar)
        Controls.Add(BTborrar)
        Controls.Add(BTcrear)
        Controls.Add(TBregistro)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBregistro As TextBox
    Friend WithEvents BTcrear As Button
    Friend WithEvents BTborrar As Button
    Friend WithEvents BTbuscar As Button
    Friend WithEvents BTactualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBregistro As CheckBox
    Friend WithEvents CBXmodelo As ComboBox
    Friend WithEvents CBXcolor As ComboBox

End Class
