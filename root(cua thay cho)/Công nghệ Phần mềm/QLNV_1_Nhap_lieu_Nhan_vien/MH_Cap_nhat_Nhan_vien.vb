﻿Imports System.ComponentModel

Public Class MH_Cap_nhat_Nhan_vien
#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow
#End Region

#Region "Xử lý Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '==== Khởi động dữ liệu : CSDL ---> Du_lieu ====
        Du_lieu = Luu_tru.Doc_Du_lieu

        '===Khởi động thể hiện ===
        Xuat_Danh_sach_Don_vi()

    End Sub
    Sub Xuat_Danh_sach_Don_vi()
        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList
        For Each Don_vi As DataRow In Danh_sach_Don_vi
            '=== Tạo thể hiện : Don_vi ---> Th_Don_vi
            Dim Th_Don_vi As New RadioButton
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat
            '==Định dạng thể hiện 
            Th_Don_vi.Size = New Size(100, 40)
            Th_Don_vi.Font = New Font("Arial", 12)

            Th_Don_vi.ForeColor = Color.White

            Th_Don_vi.Tag = Don_vi
        Next
    End Sub
    Sub Xuat_Nhan_vien()
        Th_Ho_ten.Text = Nhan_vien("Ho_ten")
        Th_Gioi_tinh.Checked = Nhan_vien("Gioi_tinh")
        Th_CMND.Text = Nhan_vien("CMND")
        Th_Ngay_sinh.Value = Nhan_vien("Ngay_sinh")
        Th_Muc_luong.Text = Nhan_vien("Muc_luong")
        Th_Dia_chi.Text = Nhan_vien("Dia_chi")
        For Each Th_Don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
            Dim Don_vi As DataRow = Th_Don_vi.Tag
            If Nhan_vien("ID_DON_VI") = Don_vi("ID") Then
                Th_Don_vi.Checked = True
            End If
        Next
    End Sub

#End Region

#Region "Xử lý Biến cố"
    Private Sub XL_Dong_y_Click(sender As Object, e As EventArgs) Handles XL_Dong_y.Click
        If Nhan_vien IsNot Nothing Then
            Nhap_Nhan_vien()
            Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Cap_nhat_Nhan_vien(Nhan_vien)
            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Cap_nhat(Nhan_vien)
            End If
            If Chuoi_loi = "" Then
                Th_Thong_bao.Text = "Đã cập nhật hồ sơ " & Nhan_vien("Ho_ten")

            Else
                Th_Thong_bao.Text = Chuoi_loi
            End If
        Else
            Th_Thong_bao.Text = "Chưa chọn nhận viên"
        End If

    End Sub

    Sub Nhap_Nhan_vien()
        Nhan_vien("Ho_ten") = Th_Ho_ten.Text.Trim
        Nhan_vien("Gioi_tinh") = Th_Gioi_tinh.Checked
        Nhan_vien("CMND") = Th_CMND.Text.Trim
        Nhan_vien("Ngay_sinh") = Th_Ngay_sinh.Value
        If Th_Muc_luong.Text.Trim = "" Then
            Nhan_vien("Muc_luong") = 0
        Else
            Nhan_vien("Muc_luong") = Th_Muc_luong.Text.Trim
        End If
        Nhan_vien("Dia_chi") = Th_Dia_chi.Text.Trim
        For Each Th_Don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
            Dim Don_vi As DataRow = Th_Don_vi.Tag
            If Th_Don_vi.Checked Then
                Nhan_vien("ID_DON_VI") = Don_vi("ID")
            End If
        Next
    End Sub

    Private Sub XL_Chon_Nhan_vien_Click(sender As Object, e As EventArgs) Handles XL_Chon_Nhan_vien.Click
        Dim Mh As New MH_Chon_Nhan_vien
        Mh.ShowDialog()
        Nhan_vien = Mh.Nhan_vien_Chon
        If Nhan_vien IsNot Nothing Then
            Xuat_Nhan_vien()
        End If
    End Sub


#End Region

End Class