Partial Class dts_recetaMedica
    Partial Class RecetaDataTable

        Private Sub RecetaDataTable_RecetaRowChanging(ByVal sender As System.Object, ByVal e As RecetaRowChangeEvent) Handles Me.RecetaRowChanging

        End Sub

        Private Sub RecetaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cie_cod4Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
