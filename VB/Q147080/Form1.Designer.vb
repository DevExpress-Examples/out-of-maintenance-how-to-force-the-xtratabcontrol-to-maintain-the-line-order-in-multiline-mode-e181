Imports Microsoft.VisualBasic
Imports System
Namespace Q147080
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myXtraTabControl1 = New DXSample.MyXtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage10 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage11 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage12 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.myXtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myXtraTabControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' myXtraTabControl1
			' 
			Me.myXtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myXtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.myXtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True
			Me.myXtraTabControl1.Name = "myXtraTabControl1"
			Me.myXtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.myXtraTabControl1.Size = New System.Drawing.Size(691, 501)
			Me.myXtraTabControl1.TabIndex = 0
			Me.myXtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6, Me.xtraTabPage7, Me.xtraTabPage8, Me.xtraTabPage9, Me.xtraTabPage10, Me.xtraTabPage11, Me.xtraTabPage12})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(682, 448)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(0, 0)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(682, 448)
			Me.xtraTabPage3.Text = "xtraTabPage3"
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.Name = "xtraTabPage4"
			Me.xtraTabPage4.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage4.Text = "xtraTabPage4"
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage5.Text = "xtraTabPage5"
			' 
			' xtraTabPage6
			' 
			Me.xtraTabPage6.Name = "xtraTabPage6"
			Me.xtraTabPage6.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage6.Text = "xtraTabPage6"
			' 
			' xtraTabPage7
			' 
			Me.xtraTabPage7.Name = "xtraTabPage7"
			Me.xtraTabPage7.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage7.Text = "xtraTabPage7"
			' 
			' xtraTabPage8
			' 
			Me.xtraTabPage8.Name = "xtraTabPage8"
			Me.xtraTabPage8.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage8.Text = "xtraTabPage8"
			' 
			' xtraTabPage9
			' 
			Me.xtraTabPage9.Name = "xtraTabPage9"
			Me.xtraTabPage9.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage9.Text = "xtraTabPage9"
			' 
			' xtraTabPage10
			' 
			Me.xtraTabPage10.Name = "xtraTabPage10"
			Me.xtraTabPage10.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage10.Text = "xtraTabPage10"
			' 
			' xtraTabPage11
			' 
			Me.xtraTabPage11.Name = "xtraTabPage11"
			Me.xtraTabPage11.Size = New System.Drawing.Size(682, 470)
			Me.xtraTabPage11.Text = "xtraTabPage11"
			' 
			' xtraTabPage12
			' 
			Me.xtraTabPage12.Name = "xtraTabPage12"
			Me.xtraTabPage12.Size = New System.Drawing.Size(682, 448)
			Me.xtraTabPage12.Text = "xtraTabPage12"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(691, 501)
			Me.Controls.Add(Me.myXtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myXtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myXtraTabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myXtraTabControl1 As DXSample.MyXtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage7 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage8 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage9 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage10 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage11 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage12 As DevExpress.XtraTab.XtraTabPage


	End Class
End Namespace

