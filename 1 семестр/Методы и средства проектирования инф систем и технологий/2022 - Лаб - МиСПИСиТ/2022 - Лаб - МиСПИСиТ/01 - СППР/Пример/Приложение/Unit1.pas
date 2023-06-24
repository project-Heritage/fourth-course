unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
   Function CallDLLSFunction(DllName,FunctName: String):String;
  end;

var
  Form1: TForm1;

implementation

function MyFunct(Value : Boolean): PChar; stdcall; external 'MyDLL.dll';
{$R *.dfm}

procedure TForm1.Button2Click(Sender: TObject);
begin
 CallDLLSFunction('MyDll.dll','MyFunct');
end;

Function TForm1.CallDLLSFunction(DllName,FunctName: String):String;
type
 //���������� ������� �� DLL
 TMethod = function(Value : Boolean):PChar; stdcall;
var
 LMethod:TMethod;
 i:integer;
begin
 try
  //�������� ������������ ���������� � ����������� ������
  i:=Windows.LoadLibrary(PChar(DllName));
 if i<>0 then
 begin
  //��������� ������ �� ������� �� ����������
     LMethod:=Windows.GetProcAddress(i,PChar(FunctName));
  if Assigned(LMethod)then
   //����� �������
       ShowMessage(StrPas(LMethod(True)));
 end;
 except
 end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
 ShowMessage(StrPas(MyFunct(False)));
end;

end.
