<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCompañia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(1, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 48)
        Me.Panel1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAtras)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 94)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'BtnAtras
        '
        Me.BtnAtras.BackgroundImage = Global.Proyecto_EVIPRIL.My.Resources.Resources._1489292297_arrow_back
        Me.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtras.FlatAppearance.BorderSize = 0
        Me.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtras.Location = New System.Drawing.Point(297, 21)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(58, 58)
        Me.BtnAtras.TabIndex = 2
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = Global.Proyecto_EVIPRIL.My.Resources.Resources._1489292326_BT_save
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(184, 21)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(58, 58)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnInicio
        '
        Me.BtnInicio.BackgroundImage = Global.Proyecto_EVIPRIL.My.Resources.Resources._1489292273_Streamline_18
        Me.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Location = New System.Drawing.Point(72, 21)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(58, 58)
        Me.BtnInicio.TabIndex = 0
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(745, 99)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.TxtTelefono.TabIndex = 21
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(287, 105)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(260, 20)
        Me.TxtCodigo.TabIndex = 20
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(287, 270)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(493, 72)
        Me.TxtDireccion.TabIndex = 19
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(287, 215)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(352, 20)
        Me.TxtNombre.TabIndex = 18
        '
        'TxtCompañia
        '
        Me.TxtCompañia.Location = New System.Drawing.Point(287, 157)
        Me.TxtCompañia.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCompañia.Name = "TxtCompañia"
        Me.TxtCompañia.Size = New System.Drawing.Size(352, 20)
        Me.TxtCompañia.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(645, 100)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre del Contacto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre de la Compañia:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(93, 105)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(114, 16)
        Me.Label.TabIndex = 12
        Me.Label.Text = "Codigo Cliente:"
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 465)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCompañia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCompañia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
End Class
