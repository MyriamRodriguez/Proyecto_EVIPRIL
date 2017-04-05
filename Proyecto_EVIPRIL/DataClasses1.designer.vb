﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SeguridadLeon")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertEmpleado(instance As Empleado)
    End Sub
  Partial Private Sub UpdateEmpleado(instance As Empleado)
    End Sub
  Partial Private Sub DeleteEmpleado(instance As Empleado)
    End Sub
  Partial Private Sub InsertEstadoCivil(instance As EstadoCivil)
    End Sub
  Partial Private Sub UpdateEstadoCivil(instance As EstadoCivil)
    End Sub
  Partial Private Sub DeleteEstadoCivil(instance As EstadoCivil)
    End Sub
  Partial Private Sub InsertProfesion(instance As Profesion)
    End Sub
  Partial Private Sub UpdateProfesion(instance As Profesion)
    End Sub
  Partial Private Sub DeleteProfesion(instance As Profesion)
    End Sub
  Partial Private Sub InsertClientes(instance As Clientes)
    End Sub
  Partial Private Sub UpdateClientes(instance As Clientes)
    End Sub
  Partial Private Sub DeleteClientes(instance As Clientes)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Proyecto_EVIPRIL.My.MySettings.Default.SeguridadLeonConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Empleado() As System.Data.Linq.Table(Of Empleado)
		Get
			Return Me.GetTable(Of Empleado)
		End Get
	End Property
	
	Public ReadOnly Property EstadoCivil() As System.Data.Linq.Table(Of EstadoCivil)
		Get
			Return Me.GetTable(Of EstadoCivil)
		End Get
	End Property
	
	Public ReadOnly Property Profesion() As System.Data.Linq.Table(Of Profesion)
		Get
			Return Me.GetTable(Of Profesion)
		End Get
	End Property
	
	Public ReadOnly Property Clientes() As System.Data.Linq.Table(Of Clientes)
		Get
			Return Me.GetTable(Of Clientes)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Empleado")>  _
Partial Public Class Empleado
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _NumIdentidad As String
	
	Private _Nombres As String
	
	Private _Apellidos As String
	
	Private _Direccion As String
	
	Private _Telefono As String
	
	Private _FechaNac As Date
	
	Private _NumCuenta As Integer
	
	Private _IdProfesion As Integer
	
	Private _IdEstadoCivil As Integer
	
	Private _EstadoCivil As EntityRef(Of EstadoCivil)
	
	Private _Profesion As EntityRef(Of Profesion)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnNumIdentidadChanging(value As String)
    End Sub
    Partial Private Sub OnNumIdentidadChanged()
    End Sub
    Partial Private Sub OnNombresChanging(value As String)
    End Sub
    Partial Private Sub OnNombresChanged()
    End Sub
    Partial Private Sub OnApellidosChanging(value As String)
    End Sub
    Partial Private Sub OnApellidosChanged()
    End Sub
    Partial Private Sub OnDireccionChanging(value As String)
    End Sub
    Partial Private Sub OnDireccionChanged()
    End Sub
    Partial Private Sub OnTelefonoChanging(value As String)
    End Sub
    Partial Private Sub OnTelefonoChanged()
    End Sub
    Partial Private Sub OnFechaNacChanging(value As Date)
    End Sub
    Partial Private Sub OnFechaNacChanged()
    End Sub
    Partial Private Sub OnNumCuentaChanging(value As Integer)
    End Sub
    Partial Private Sub OnNumCuentaChanged()
    End Sub
    Partial Private Sub OnIdProfesionChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdProfesionChanged()
    End Sub
    Partial Private Sub OnIdEstadoCivilChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdEstadoCivilChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._EstadoCivil = CType(Nothing, EntityRef(Of EstadoCivil))
		Me._Profesion = CType(Nothing, EntityRef(Of Profesion))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NumIdentidad", DbType:="Char(13) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property NumIdentidad() As String
		Get
			Return Me._NumIdentidad
		End Get
		Set
			If (String.Equals(Me._NumIdentidad, value) = false) Then
				Me.OnNumIdentidadChanging(value)
				Me.SendPropertyChanging
				Me._NumIdentidad = value
				Me.SendPropertyChanged("NumIdentidad")
				Me.OnNumIdentidadChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Nombres", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Nombres() As String
		Get
			Return Me._Nombres
		End Get
		Set
			If (String.Equals(Me._Nombres, value) = false) Then
				Me.OnNombresChanging(value)
				Me.SendPropertyChanging
				Me._Nombres = value
				Me.SendPropertyChanged("Nombres")
				Me.OnNombresChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Apellidos", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Apellidos() As String
		Get
			Return Me._Apellidos
		End Get
		Set
			If (String.Equals(Me._Apellidos, value) = false) Then
				Me.OnApellidosChanging(value)
				Me.SendPropertyChanging
				Me._Apellidos = value
				Me.SendPropertyChanged("Apellidos")
				Me.OnApellidosChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Direccion", DbType:="NVarChar(300) NOT NULL", CanBeNull:=false)>  _
	Public Property Direccion() As String
		Get
			Return Me._Direccion
		End Get
		Set
			If (String.Equals(Me._Direccion, value) = false) Then
				Me.OnDireccionChanging(value)
				Me.SendPropertyChanging
				Me._Direccion = value
				Me.SendPropertyChanged("Direccion")
				Me.OnDireccionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Telefono", DbType:="Char(9)")>  _
	Public Property Telefono() As String
		Get
			Return Me._Telefono
		End Get
		Set
			If (String.Equals(Me._Telefono, value) = false) Then
				Me.OnTelefonoChanging(value)
				Me.SendPropertyChanging
				Me._Telefono = value
				Me.SendPropertyChanged("Telefono")
				Me.OnTelefonoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FechaNac", DbType:="Date NOT NULL")>  _
	Public Property FechaNac() As Date
		Get
			Return Me._FechaNac
		End Get
		Set
			If ((Me._FechaNac = value)  _
						= false) Then
				Me.OnFechaNacChanging(value)
				Me.SendPropertyChanging
				Me._FechaNac = value
				Me.SendPropertyChanged("FechaNac")
				Me.OnFechaNacChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NumCuenta", DbType:="Int NOT NULL")>  _
	Public Property NumCuenta() As Integer
		Get
			Return Me._NumCuenta
		End Get
		Set
			If ((Me._NumCuenta = value)  _
						= false) Then
				Me.OnNumCuentaChanging(value)
				Me.SendPropertyChanging
				Me._NumCuenta = value
				Me.SendPropertyChanged("NumCuenta")
				Me.OnNumCuentaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdProfesion", DbType:="Int NOT NULL")>  _
	Public Property IdProfesion() As Integer
		Get
			Return Me._IdProfesion
		End Get
		Set
			If ((Me._IdProfesion = value)  _
						= false) Then
				If Me._Profesion.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnIdProfesionChanging(value)
				Me.SendPropertyChanging
				Me._IdProfesion = value
				Me.SendPropertyChanged("IdProfesion")
				Me.OnIdProfesionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdEstadoCivil", DbType:="Int NOT NULL")>  _
	Public Property IdEstadoCivil() As Integer
		Get
			Return Me._IdEstadoCivil
		End Get
		Set
			If ((Me._IdEstadoCivil = value)  _
						= false) Then
				If Me._EstadoCivil.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnIdEstadoCivilChanging(value)
				Me.SendPropertyChanging
				Me._IdEstadoCivil = value
				Me.SendPropertyChanged("IdEstadoCivil")
				Me.OnIdEstadoCivilChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="EstadoCivil_Empleado", Storage:="_EstadoCivil", ThisKey:="IdEstadoCivil", OtherKey:="IdEstadoCivil", IsForeignKey:=true)>  _
	Public Property EstadoCivil() As EstadoCivil
		Get
			Return Me._EstadoCivil.Entity
		End Get
		Set
			Dim previousValue As EstadoCivil = Me._EstadoCivil.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._EstadoCivil.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._EstadoCivil.Entity = Nothing
					previousValue.Empleado.Remove(Me)
				End If
				Me._EstadoCivil.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Empleado.Add(Me)
					Me._IdEstadoCivil = value.IdEstadoCivil
				Else
					Me._IdEstadoCivil = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("EstadoCivil")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Profesion_Empleado", Storage:="_Profesion", ThisKey:="IdProfesion", OtherKey:="IdProfesion", IsForeignKey:=true)>  _
	Public Property Profesion() As Profesion
		Get
			Return Me._Profesion.Entity
		End Get
		Set
			Dim previousValue As Profesion = Me._Profesion.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Profesion.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Profesion.Entity = Nothing
					previousValue.Empleado.Remove(Me)
				End If
				Me._Profesion.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Empleado.Add(Me)
					Me._IdProfesion = value.IdProfesion
				Else
					Me._IdProfesion = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Profesion")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.EstadoCivil")>  _
Partial Public Class EstadoCivil
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IdEstadoCivil As Integer
	
	Private _EstadoCivil As String
	
	Private _Empleado As EntitySet(Of Empleado)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdEstadoCivilChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdEstadoCivilChanged()
    End Sub
    Partial Private Sub OnEstadoCivilChanging(value As String)
    End Sub
    Partial Private Sub OnEstadoCivilChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Empleado = New EntitySet(Of Empleado)(AddressOf Me.attach_Empleado, AddressOf Me.detach_Empleado)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdEstadoCivil", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IdEstadoCivil() As Integer
		Get
			Return Me._IdEstadoCivil
		End Get
		Set
			If ((Me._IdEstadoCivil = value)  _
						= false) Then
				Me.OnIdEstadoCivilChanging(value)
				Me.SendPropertyChanging
				Me._IdEstadoCivil = value
				Me.SendPropertyChanged("IdEstadoCivil")
				Me.OnIdEstadoCivilChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EstadoCivil", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property EstadoCivil() As String
		Get
			Return Me._EstadoCivil
		End Get
		Set
			If (String.Equals(Me._EstadoCivil, value) = false) Then
				Me.OnEstadoCivilChanging(value)
				Me.SendPropertyChanging
				Me._EstadoCivil = value
				Me.SendPropertyChanged("EstadoCivil")
				Me.OnEstadoCivilChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="EstadoCivil_Empleado", Storage:="_Empleado", ThisKey:="IdEstadoCivil", OtherKey:="IdEstadoCivil")>  _
	Public Property Empleado() As EntitySet(Of Empleado)
		Get
			Return Me._Empleado
		End Get
		Set
			Me._Empleado.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Empleado(ByVal entity As Empleado)
		Me.SendPropertyChanging
		entity.EstadoCivil = Me
	End Sub
	
	Private Sub detach_Empleado(ByVal entity As Empleado)
		Me.SendPropertyChanging
		entity.EstadoCivil = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Profesion")>  _
Partial Public Class Profesion
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IdProfesion As Integer
	
	Private _Profesion As String
	
	Private _Empleado As EntitySet(Of Empleado)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdProfesionChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdProfesionChanged()
    End Sub
    Partial Private Sub OnProfesionChanging(value As String)
    End Sub
    Partial Private Sub OnProfesionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Empleado = New EntitySet(Of Empleado)(AddressOf Me.attach_Empleado, AddressOf Me.detach_Empleado)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdProfesion", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IdProfesion() As Integer
		Get
			Return Me._IdProfesion
		End Get
		Set
			If ((Me._IdProfesion = value)  _
						= false) Then
				Me.OnIdProfesionChanging(value)
				Me.SendPropertyChanging
				Me._IdProfesion = value
				Me.SendPropertyChanged("IdProfesion")
				Me.OnIdProfesionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Profesion", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Profesion() As String
		Get
			Return Me._Profesion
		End Get
		Set
			If (String.Equals(Me._Profesion, value) = false) Then
				Me.OnProfesionChanging(value)
				Me.SendPropertyChanging
				Me._Profesion = value
				Me.SendPropertyChanged("Profesion")
				Me.OnProfesionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Profesion_Empleado", Storage:="_Empleado", ThisKey:="IdProfesion", OtherKey:="IdProfesion")>  _
	Public Property Empleado() As EntitySet(Of Empleado)
		Get
			Return Me._Empleado
		End Get
		Set
			Me._Empleado.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Empleado(ByVal entity As Empleado)
		Me.SendPropertyChanging
		entity.Profesion = Me
	End Sub
	
	Private Sub detach_Empleado(ByVal entity As Empleado)
		Me.SendPropertyChanging
		entity.Profesion = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Clientes")>  _
Partial Public Class Clientes
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IdCliente As Integer
	
	Private _NombreCompañia As String
	
	Private _NombreContacto As String
	
	Private _Direccion As String
	
	Private _Telefono As String
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdClienteChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdClienteChanged()
    End Sub
    Partial Private Sub OnNombreCompañiaChanging(value As String)
    End Sub
    Partial Private Sub OnNombreCompañiaChanged()
    End Sub
    Partial Private Sub OnNombreContactoChanging(value As String)
    End Sub
    Partial Private Sub OnNombreContactoChanged()
    End Sub
    Partial Private Sub OnDireccionChanging(value As String)
    End Sub
    Partial Private Sub OnDireccionChanged()
    End Sub
    Partial Private Sub OnTelefonoChanging(value As String)
    End Sub
    Partial Private Sub OnTelefonoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdCliente", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IdCliente() As Integer
		Get
			Return Me._IdCliente
		End Get
		Set
			If ((Me._IdCliente = value)  _
						= false) Then
				Me.OnIdClienteChanging(value)
				Me.SendPropertyChanging
				Me._IdCliente = value
				Me.SendPropertyChanged("IdCliente")
				Me.OnIdClienteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NombreCompañia", DbType:="NVarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property NombreCompañia() As String
		Get
			Return Me._NombreCompañia
		End Get
		Set
			If (String.Equals(Me._NombreCompañia, value) = false) Then
				Me.OnNombreCompañiaChanging(value)
				Me.SendPropertyChanging
				Me._NombreCompañia = value
				Me.SendPropertyChanged("NombreCompañia")
				Me.OnNombreCompañiaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NombreContacto", DbType:="NVarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property NombreContacto() As String
		Get
			Return Me._NombreContacto
		End Get
		Set
			If (String.Equals(Me._NombreContacto, value) = false) Then
				Me.OnNombreContactoChanging(value)
				Me.SendPropertyChanging
				Me._NombreContacto = value
				Me.SendPropertyChanged("NombreContacto")
				Me.OnNombreContactoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Direccion", DbType:="NVarChar(300) NOT NULL", CanBeNull:=false)>  _
	Public Property Direccion() As String
		Get
			Return Me._Direccion
		End Get
		Set
			If (String.Equals(Me._Direccion, value) = false) Then
				Me.OnDireccionChanging(value)
				Me.SendPropertyChanging
				Me._Direccion = value
				Me.SendPropertyChanged("Direccion")
				Me.OnDireccionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Telefono", DbType:="Char(9)")>  _
	Public Property Telefono() As String
		Get
			Return Me._Telefono
		End Get
		Set
			If (String.Equals(Me._Telefono, value) = false) Then
				Me.OnTelefonoChanging(value)
				Me.SendPropertyChanging
				Me._Telefono = value
				Me.SendPropertyChanged("Telefono")
				Me.OnTelefonoChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
