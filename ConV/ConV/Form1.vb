Imports System.IO

Public Class Form1
    ' ฟังก์ชันที่จะตรวจสอบไฟล์และทำการเปลี่ยนแปลง
    Private Sub CheckFiles()
        ' กำหนดเส้นทางของไฟล์ที่เก็บ log
        Dim logFilePath As String = Path.Combine(Application.StartupPath, "folder_log.txt") ' File to log the processed folders
        Dim rootFolder As String = "\\192.168.83.17\ftp\DPR\ngmap\lotdb" ' โฟลเดอร์หลักที่เก็บโฟลเดอร์ย่อยต่างๆ

        ' เช็คว่า path D:\for มีอยู่หรือไม่
        If Not Directory.Exists(rootFolder) Then
            MessageBox.Show("Path D:\for ไม่พบ!")
            Exit Sub
        End If

        ' ตรวจสอบว่าโฟลเดอร์หลักมีอยู่จริงหรือไม่
        Dim subFolders As String() = Directory.GetDirectories(rootFolder)

        ' บันทึกข้อมูลลงใน log file
        ' สร้างไฟล์ log ถ้าไม่มีอยู่
        If Not File.Exists(logFilePath) Then
            File.Create(logFilePath).Dispose()
        End If

        ' อ่านข้อมูลจาก log file เพื่อตรวจสอบว่าโฟลเดอร์ไหนได้ถูกประมวลผลไปแล้ว
        Dim processedFolders As List(Of String) = File.ReadAllLines(logFilePath).ToList()

        ' ใช้ StreamWriter สำหรับเขียนข้อมูลลงไฟล์ log
        Using logWriter As New StreamWriter(logFilePath, True) ' True = เปิดในโหมด append
            ' เขียนเวลาปัจจุบันเข้าไปใน log
            ' logWriter.WriteLine("Log Start Time: " & DateTime.Now.ToString())

            For Each subFolder As String In subFolders
                ' ตรวจสอบว่าโฟลเดอร์ย่อยนั้นมีโฟลเดอร์ชื่อ 1 และ 2 หรือไม่
                Dim inputFolder As String = Path.Combine(subFolder, "parts_u_chk")
                Dim outputFolder As String = Path.Combine(subFolder, "pre_marking")

                ' ตรวจสอบว่าโฟลเดอร์ input และ output มีอยู่หรือไม่
                If Directory.Exists(inputFolder) AndAlso Directory.Exists(outputFolder) Then
                    ' ตรวจสอบว่าโฟลเดอร์นี้เคยประมวลผลไปแล้วหรือยัง
                    If processedFolders.Contains(Path.GetFileName(subFolder)) Then
                        ' ถ้าโฟลเดอร์นี้เคยประมวลผลแล้ว ข้ามไปทำโฟลเดอร์ถัดไป
                        GoTo A

                        Continue For
                    End If

                    ' รับไฟล์ทั้งหมดในโฟลเดอร์ input
                    Dim files As String() = Directory.GetFiles(inputFolder, "*.csv")

                    ' ตรวจสอบว่าใน input folder มีไฟล์ใหม่หรือไม่
                    If files.Length > 0 Then
                        'logWriter.WriteLine("Processing folder: " & Path.GetFileName(subFolder))

                        For Each file As String In files
                            ' กำหนดเส้นทางไฟล์ใหม่ใน output folder
                            Dim newFilePath As String = Path.Combine(outputFolder, Path.GetFileName(file))

                            Try
                                ' ใช้ StreamReader อ่านข้อมูลจากไฟล์ CSV
                                Using reader As New StreamReader(file)
                                    ' สร้าง StreamWriter สำหรับเขียนข้อมูลไปยังไฟล์ใหม่ โดยใช้การเข้ารหัส UTF-8
                                    Using writer As New StreamWriter(newFilePath, False, System.Text.Encoding.UTF8)
                                        ' อ่านข้อมูลทีละบรรทัด
                                        While Not reader.EndOfStream
                                            Dim line As String = reader.ReadLine()

                                            ' แยกแต่ละคอลัมน์
                                            Dim columns As String() = line.Split(","c)

                                            ' เปลี่ยนค่า 1 เป็น 0 และ 0 เป็น 1
                                            For i As Integer = 0 To columns.Length - 1
                                                If columns(i) = "1" Then
                                                    columns(i) = "0"
                                                ElseIf columns(i) = "0" Then
                                                    columns(i) = "1"
                                                End If
                                            Next

                                            ' เขียนบรรทัดที่เปลี่ยนแปลงแล้วลงไฟล์ใหม่
                                            writer.WriteLine(String.Join(",", columns))
                                        End While
                                    End Using
                                End Using

                                ' Log the processed folder (บันทึก log เฉพาะเมื่อโฟลเดอร์ถูกประมวลผล)
                                logWriter.WriteLine("Processed folder: " & Path.GetFileName(subFolder) & " at " & DateTime.Now.ToString())
                                ' เพิ่มชื่อโฟลเดอร์ที่ประมวลผลแล้วลงใน log
                                processedFolders.Add(Path.GetFileName(subFolder))
                            Catch ex As Exception
                                ' ถ้ามีข้อผิดพลาดให้แสดงข้อความ
                                MessageBox.Show("เกิดข้อผิดพลาดกับไฟล์: " & Path.GetFileName(file) & vbCrLf & ex.Message)
                                logWriter.WriteLine("Error processing file in folder: " & Path.GetFileName(subFolder) & " at " & DateTime.Now.ToString())
                            End Try
                        Next
                    Else
                        ' logWriter.WriteLine("No CSV files in input folder: " & inputFolder)
                    End If
                Else
A:
                    ' Log if the required folders are missing
                    logWriter.WriteLine("ไม่ใช่ GEN 4 : " & Path.GetFileName(subFolder))
                End If
            Next

            ' เขียนเวลาสิ้นสุดการทำงานของโปรแกรม
            ' logWriter.WriteLine("Log End Time: " & DateTime.Now.ToString())
        End Using
    End Sub

    ' ฟังก์ชันที่จะเริ่มต้น Timer และทำงานทุกๆ 10 วินาที
    Private WithEvents timer As New Timer() ' ประกาศตัวแปร Timer

    ' เริ่มต้น Timer ทำงานทุกๆ 10 วินาที
    Private Sub StartTimer()
        ' กำหนดเวลาให้ Timer ทำงานทุก 10 วินาที (10000ms = 10 วินาที)
        timer.Interval = 600000 ' 1 hr
        timer.Start() ' เริ่มต้น Timer
    End Sub

    ' ฟังก์ชันที่ทำงานเมื่อ Timer หมดเวลา
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' เมื่อ Timer หมดเวลา (ทุกๆ 10 วินาที)
        CheckFiles() ' เรียกฟังก์ชันตรวจสอบไฟล์
    End Sub

    ' ฟังก์ชันนี้จะถูกเรียกเมื่อโปรแกรมเริ่มทำงาน
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' เริ่มต้น Timer เมื่อโปรแกรมเริ่มทำงาน
        StartTimer()
        CheckFiles()
    End Sub
End Class
