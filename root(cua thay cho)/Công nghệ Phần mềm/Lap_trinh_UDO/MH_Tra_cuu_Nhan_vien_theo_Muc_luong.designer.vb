﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tra_cuu_Nhan_vien_theo_Muc_luong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Th_Muc_luong = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(359, 19)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(453, 31)
        Me.Th_Tieu_de.TabIndex = 0
        Me.Th_Tieu_de.Text = "Tra cứu nhân viên theo mức lương"
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(12, 131)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(922, 382)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mức lương"
        '
        'Th_Muc_luong
        '
        Me.Th_Muc_luong.Location = New System.Drawing.Point(124, 82)
        Me.Th_Muc_luong.Name = "Th_Muc_luong"
        Me.Th_Muc_luong.Size = New System.Drawing.Size(228, 26)
        Me.Th_Muc_luong.TabIndex = 3
        '
        'MH_Tra_cuu_Nhan_vien_theo_Muc_luong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 525)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Th_Muc_luong)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Tra_cuu_Nhan_vien_theo_Muc_luong"
        Me.Text = "MH_Tra_cuu_Nhan_vien_theo_Muc_luong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Th_Muc_luong As TextBox
End Class
