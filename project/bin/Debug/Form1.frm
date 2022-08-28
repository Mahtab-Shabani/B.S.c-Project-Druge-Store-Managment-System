VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Find And replace Test"
   ClientHeight    =   3210
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4665
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3210
   ScaleWidth      =   4665
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox ChkCaseSensitive 
      Caption         =   "Case Sensitive"
      Height          =   195
      Left            =   180
      TabIndex        =   6
      Top             =   1020
      Value           =   1  'Checked
      Width           =   4335
   End
   Begin VB.TextBox Text1 
      Height          =   1095
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   5
      Top             =   1515
      Width           =   4395
   End
   Begin VB.TextBox TxtReplace 
      Height          =   255
      Left            =   2160
      TabIndex        =   2
      Text            =   "Taste"
      Top             =   480
      Width           =   2295
   End
   Begin VB.TextBox TxtFind 
      Height          =   255
      Left            =   180
      TabIndex        =   1
      Text            =   "test"
      Top             =   480
      Width           =   1215
   End
   Begin VB.CommandButton CmdGo 
      Caption         =   "&Go"
      Default         =   -1  'True
      Height          =   495
      Left            =   60
      TabIndex        =   0
      Top             =   2640
      Width           =   4515
   End
   Begin VB.Label Label1 
      Caption         =   "Replace with"
      Height          =   195
      Index           =   1
      Left            =   2160
      TabIndex        =   4
      Top             =   240
      Width           =   2295
   End
   Begin VB.Label Label1 
      Caption         =   "Find"
      Height          =   195
      Index           =   0
      Left            =   180
      TabIndex        =   3
      Top             =   240
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdGo_Click()
    Text1.Text = FindAndReplace(Trim(TxtFind.Text), Trim(TxtReplace.Text), Text1.Text, ChkCaseSensitive.Value * -1)
End Sub

Private Function FindAndReplace(StrFind As String, strReplace As String, ByVal strMyString As String, CaseSensitive As Boolean) As String

strMyString = strMyString

If CaseSensitive Then
    N% = InStr(strMyString, StrFind)
Else
    N% = InStr(UCase(strMyString), UCase(StrFind))
End If
Do While N% <> 0
    strMyString = Left(strMyString, N% - 1) + strReplace + Right$(strMyString, Len(strMyString) - N% - Len(StrFind) + 1)
    Start = Start + N% + Len(strReplace)
    If Start <= Len(strMyString) Then
        If CaseSensitive Then
            N% = InStr(Start, strMyString, StrFind)
        Else
            N% = InStr(Start, UCase(strMyString), UCase(StrFind))
        End If
    Else
        N% = 0
    End If
Loop

FindAndReplace = strMyString
End Function

