﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContratoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContratoCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TxtNguardias = New System.Windows.Forms.TextBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtFechaFinal = New System.Windows.Forms.TextBox()
        Me.TxtFechaInico = New System.Windows.Forms.TextBox()
        Me.TxtContrato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 70)
        Me.Panel1.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 31)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contrato Cliente"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 397)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 70)
        Me.Panel2.TabIndex = 53
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(331, 303)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(274, 55)
        Me.TextBox6.TabIndex = 65
        '
        'TxtNguardias
        '
        Me.TxtNguardias.Location = New System.Drawing.Point(331, 261)
        Me.TxtNguardias.Name = "TxtNguardias"
        Me.TxtNguardias.Size = New System.Drawing.Size(132, 20)
        Me.TxtNguardias.TabIndex = 64
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(331, 224)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(132, 20)
        Me.TxtIdCliente.TabIndex = 63
        '
        'TxtFechaFinal
        '
        Me.TxtFechaFinal.Location = New System.Drawing.Point(331, 183)
        Me.TxtFechaFinal.Name = "TxtFechaFinal"
        Me.TxtFechaFinal.Size = New System.Drawing.Size(132, 20)
        Me.TxtFechaFinal.TabIndex = 62
        '
        'TxtFechaInico
        '
        Me.TxtFechaInico.Location = New System.Drawing.Point(331, 143)
        Me.TxtFechaInico.Name = "TxtFechaInico"
        Me.TxtFechaInico.Size = New System.Drawing.Size(132, 20)
        Me.TxtFechaInico.TabIndex = 61
        '
        'TxtContrato
        '
        Me.TxtContrato.Location = New System.Drawing.Point(331, 100)
        Me.TxtContrato.Name = "TxtContrato"
        Me.TxtContrato.Size = New System.Drawing.Size(132, 20)
        Me.TxtContrato.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "N'  de Guardias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "IdCliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Fecha de Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "IdContrato"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(145, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(354, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(559, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmContratoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 468)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TxtNguardias)
        Me.Controls.Add(Me.TxtIdCliente)
        Me.Controls.Add(Me.TxtFechaFinal)
        Me.Controls.Add(Me.TxtFechaInico)
        Me.Controls.Add(Me.TxtContrato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmContratoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContratoCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TxtNguardias As TextBox
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents TxtFechaFinal As TextBox
    Friend WithEvents TxtFechaInico As TextBox
    Friend WithEvents TxtContrato As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class