
Public Class linea_produccion
    Inherits sql

    Private _value As VariantType
    Private _tiempo_muerto_actual As Integer
    Private _tiempo_muerto_acumulado As Integer
    Private _empleados As Integer
    Private _nombre As String
    Private _hora_ultimo_registro As String
    Private _modelo_ultimo_registro As String
    Private _serie_ultimo_registro As String
    Private _meta_del_dia As Integer
    Private _meta_actual As Integer
    Private _maquinas_completadas As Integer
    Private _daily_rate As Integer
    Private _produccion_actual As Integer


    Property tiempo_muerto_acumulado
        Set(ByVal value)
            _tiempo_muerto_acumulado = value
        End Set
        Get
            Return _tiempo_muerto_acumulado

        End Get
    End Property
    Property tiempo_muerto_actual
        Set(ByVal value)
            _tiempo_muerto_actual = value
        End Set
        Get
            Return _tiempo_muerto_actual

        End Get
    End Property
    Property empleados
        Set(ByVal value)
            _empleados = value
        End Set
        Get
            Return _empleados

        End Get
    End Property
    Property nombre
        Set(ByVal value)
            _nombre = value
        End Set
        Get
            Return _nombre

        End Get
    End Property
    Property hora_ultimo_registo
        Set(ByVal value)
            _hora_ultimo_registro = value
        End Set
        Get
            Return _hora_ultimo_registro

        End Get
    End Property
    Property modelo_ultimo_registo
        Set(ByVal value)
            _modelo_ultimo_registro = value
        End Set
        Get
            Return _modelo_ultimo_registro

        End Get
    End Property
    Property serie_ultimo_registo
        Set(ByVal value)
            _serie_ultimo_registro = value
        End Set
        Get
            Return _serie_ultimo_registro
        End Get
    End Property
    Property meta_del_dia
        Set(ByVal value)
            _meta_del_dia = value
        End Set
        Get
            Return _meta_del_dia
        End Get
    End Property
    Property meta_actual
        Set(ByVal value)
            _meta_actual = value
        End Set
        Get
            Return _meta_actual
        End Get
    End Property
    Property maquinas_completadas
        Set(ByVal value)
            _maquinas_completadas = value
        End Set
        Get
            Return _maquinas_completadas
        End Get
    End Property
    Property daily_rate
        Set(ByVal value)
            _daily_rate = value
        End Set
        Get
            Return _daily_rate
        End Get
    End Property
    Property produccion_actual
        Set(ByVal value)
            _produccion_actual = value
        End Set
        Get
            Return _produccion_actual
        End Get
    End Property
    
End Class

