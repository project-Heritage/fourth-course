object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 77
  ClientWidth = 233
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Edit1: TEdit
    Left = 16
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
  end
  object Button1: TButton
    Left = 143
    Top = 14
    Width = 75
    Height = 25
    Caption = 'Static'
    TabOrder = 1
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 143
    Top = 45
    Width = 75
    Height = 25
    Caption = 'Dynamic'
    TabOrder = 2
    OnClick = Button2Click
  end
end
