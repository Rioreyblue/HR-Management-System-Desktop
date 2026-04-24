Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace NxNDataGridViewMultiColumnCombo

    Public Class DataGridViewMultiColumnComboColumn
        Inherits DataGridViewComboBoxColumn
        Private _ColumnWidthDefault As Integer = 75
        Private _ColumnWidthString As String = ""
        Private _IntegralHeight As Boolean = True
        Private _drv As DataRowView

        Private _ColumnNum As Integer
        Private _ColumnWidth As String
        Private _SetTextFormat As StringFormat =
                New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near}

        Public Property ColumnWidths() As String
            Get
                Return _ColumnWidthString
            End Get

            Set(value As String)
                _ColumnWidthString = value
            End Set
        End Property

        Public Property drview As DataRowView
            Get
                Return _drv
            End Get
            Set(ByVal value As DataRowView)
                _drv = value
            End Set
        End Property

        Public Property ColumnNum As Integer
            Get
                Return _ColumnNum
            End Get
            Set(ByVal value As Integer)
                _ColumnNum = value
            End Set
        End Property

        Public Property IntegralHeight As Boolean
            Get
                Return _IntegralHeight
            End Get
            Set(ByVal value As Boolean)
                _IntegralHeight = value
            End Set
        End Property

        Public Property SetTextFormat As StringFormat
            Get
                Return _SetTextFormat
            End Get
            Set(ByVal value As StringFormat)
                _SetTextFormat = value
            End Set
        End Property

        Public Sub New()
            Me.CellTemplate = New DataGridViewMultiColumnComboCell()
        End Sub

    End Class

    Public Class DataGridViewMultiColumnComboCell
        Inherits DataGridViewComboBoxCell

        Public Overrides ReadOnly Property EditType() As Type
            Get
                Return GetType(DataGridViewMultiColumnComboEditingControl)
            End Get
        End Property

        Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
            Try
                MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
                Dim ctrl As DataGridViewMultiColumnComboEditingControl = TryCast(DataGridView.EditingControl, DataGridViewMultiColumnComboEditingControl)
                ctrl.ownerCell = Me
            Catch ex As Exception
            End Try
        End Sub

    End Class

    Public Class DataGridViewMultiColumnComboEditingControl

        Inherits DataGridViewComboBoxEditingControl

        'Const fixedAlignColumnSize As Integer = 100

        Const lineWidth As Integer = 1
        Public ownerCell As DataGridViewMultiColumnComboCell = Nothing
        'Private a As Boolean = IntegralHeight
        Public Sub New()
            MyBase.New()
            Me.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.DropDownStyle = ComboBoxStyle.DropDownList
            Me.MaxDropDownItems = 8
            Me.IntegralHeight = False
            'Me.IntegralHeight = a
        End Sub

        Protected Overrides Sub OnDrawItem(e As System.Windows.Forms.DrawItemEventArgs)

            'Try

            Dim fixedAlignColumnSize As Integer

            Dim rec As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
            Dim column As DataGridViewMultiColumnComboColumn = TryCast(ownerCell.OwningColumn, DataGridViewMultiColumnComboColumn)
            Dim valuesTbl As DataTable = TryCast(column.DataSource, DataTable)
            Dim joinByField As String = column.ValueMember

            Dim NormalText As New SolidBrush(System.Drawing.SystemColors.ControlText)

            Dim delimiterChars As Char() = {","c, ";"c, ":"c, "|"c}
            Dim STRcolWidths As String() = column.ColumnWidths.Split(delimiterChars)

            Dim temp_col_num As Integer

            Dim temp_col_offset As Integer = 0 'Integer.TryParse(STRcolWidths(temp_col_num), temp_col_offset)
            Dim _drv As DataRowView = column.drview

            If e.Index > -1 Then
                Dim currentRow As DataRowView = TryCast(Items(e.Index), DataRowView)
                If currentRow IsNot Nothing Then
                    Dim row As DataRow = currentRow.Row

                    Dim currentText As String = GetItemText(Items(e.Index))

                    Dim normalBack As New SolidBrush(Color.White)
                    e.Graphics.FillRectangle(normalBack, rec)


                    If DroppedDown AndAlso Not (Margin.Top = rec.Top) Then

                        Dim currentOffset As Integer = rec.Left

                        Dim HightlightedBack As New SolidBrush(System.Drawing.SystemColors.Highlight)
                        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                            e.Graphics.FillRectangle(HightlightedBack, rec)
                        End If

                        Dim addBorder As Boolean = False

                        Dim valueItem As Object
                        _drv = CType(Me.Items(e.Index), DataRowView)

                        For Each dataRowItem As Object In row.ItemArray

                            fixedAlignColumnSize = CInt(STRcolWidths(temp_col_num))

                            valueItem = dataRowItem
                            Dim value As String = dataRowItem.ToString()

                            If addBorder Then
                                Dim gridBrush As New SolidBrush(Color.Gray)

                                Dim linesNum As Long = lineWidth
                                While linesNum > 0
                                    linesNum -= 1
                                    Dim first As New Point(rec.Left + currentOffset, rec.Top)
                                    Dim last As New Point(rec.Left + currentOffset, rec.Bottom)
                                    e.Graphics.DrawLine(New Pen(gridBrush), first, last)
                                    currentOffset += 1
                                End While
                            Else
                                addBorder = True
                            End If

                            Dim extent As SizeF = e.Graphics.MeasureString(value, e.Font)
                            Dim width As Decimal = CDec(extent.Width)

                            Dim textRec As New Rectangle(currentOffset, rec.Y, CInt(Decimal.Ceiling(width)), rec.Height)


                            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                                Dim HightlightedText As New SolidBrush(System.Drawing.SystemColors.HighlightText)

                                e.Graphics.FillRectangle(HightlightedBack, currentOffset, rec.Y, fixedAlignColumnSize, extent.Height) 'fixedAlignColumnSize

                                e.Graphics.DrawString(value, e.Font, HightlightedText, textRec)
                            Else
                                e.Graphics.FillRectangle(normalBack, currentOffset, rec.Y, fixedAlignColumnSize, extent.Height) 'fixedAlignColumnSize
                                e.Graphics.DrawString(value, e.Font, NormalText, textRec)
                            End If

                            currentOffset += fixedAlignColumnSize
                            'currentOffset += temp_col_offset
                            temp_col_num += 1
                        Next
                    Else

                        e.Graphics.DrawString(currentText, e.Font, NormalText, rec)

                    End If

                End If
            End If

            MyBase.OnDrawItem(e)

            'Catch ex As Exception
            'End Try



            '==============================================

            'Dim column As DataGridViewMultiColumnComboColumn = TryCast(ownerCell.OwningColumn, DataGridViewMultiColumnComboColumn)

            'Dim delimiterChars As Char() = {","c, ";"c, ":"c, "|"c}
            'Dim STRcolWidths As String() = column.ColumnWidths.Split(delimiterChars)
            'Dim _drv As DataRowView = column.drview

            ''Try

            'e.DrawBackground()

            '_drv = CType(Me.Items(e.Index), DataRowView)
            'Dim LineColor As Color = Color.DarkGray
            'Dim _format As StringFormat = _
            'New StringFormat() With {.Alignment = StringAlignment.Near, _
            '                                .LineAlignment = StringAlignment.Near}
            'Dim _ColWidth As String() = column.ColumnWidths.Split(delimiterChars)
            ''Dim _format = SetTextFormat
            'Dim _ColumnNum As Integer = column.ColumnNum
            'Dim _Column1(_ColumnNum) As String
            'Dim _XStart As Integer = 0

            'Dim r1(_ColumnNum) As Rectangle

            'For _i As Integer = 0 To _ColumnNum Step 1

            '    _Column1(_i) = _drv(_i).ToString()

            '    r1(_i) = New Rectangle
            '    r1(_i) = e.Bounds
            '    r1(_i).X = _XStart
            '    r1(_i).Width = CInt(_ColWidth(_i))

            '    Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            '        e.Graphics.DrawString(" " & _Column1(_i), e.Font, sb, r1(_i), _format)
            '    End Using

            '    If CInt(r1(_i).Width) > 0 Then
            '        If _ColumnNum > 0 Then
            '            If _i <> _ColumnNum Then
            '                Using p As Pen = New Pen(LineColor, 1)
            '                    e.Graphics.DrawLine(p, r1(_i).Right, 0, r1(_i).Right, r1(_i).Bottom)
            '                End Using
            '            End If
            '        End If
            '    End If

            '    _XStart += r1(_i).Width
            'Next
            ''Catch ex As Exception
            ''    MsgBox(ex.Message)
            ''    Exit Sub
            ''End Try

        End Sub

    End Class

End Namespace

