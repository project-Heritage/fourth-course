library MyDll1;

{ Important note about DLL memory management: ShareMem must be the
  first unit in your library's USES clause AND your project's (select
  Project-View Source) USES clause if your DLL exports any procedures or
  functions that pass strings as parameters or function results. This
  applies to all strings passed to and from your DLL--even those that
  are nested in records and classes. ShareMem is the interface unit to
  the BORLNDMM.DLL shared memory manager, which must be deployed along
  with your DLL. To avoid using BORLNDMM.DLL, pass string information
  using PChar or ShortString parameters. }

uses
  SysUtils,
  Classes;

{$R *.res}
function Execute (const data: WideString): WideString ; stdcall ;
var
 i,j : Integer;
 tmTs,tmTs1 : TStringList;
 tmA : TStringList;
 s,s1,s2 : ShortString;
begin
 //
 tmTs:=TStringList.Create;
 tmTs1:=TStringList.Create;
 tmA:=TStringList.Create;  //list a
 tmTs.Text:=data;
 for i:=0 to tmTs.Count-1 do
  begin
   tmTs1.Delimiter:='-';
   tmTs1.DelimitedText:=tmTs.Names[i];
   s2:=tmTs.ValueFromIndex[i];
   for j:=0 to tmTs1.Count-1 do
    begin
     s:=tmTs1.Strings[j];

     if tmA.IndexOfName(s)=-1 then
      tmA.Add(s+'=0');
     if j=tmTs1.Count-1 then
      begin
       s1:=tmA.Values[s];
       tmA.Values[s]:=IntToStr(StrToInt(s1)+StrToInt(s2));
      end;
    end;

  end;

  For i:=0 to tmA.Count-2 do
  For j:=0 to tmA.Count-2 do
   if tmA.ValueFromIndex[j]> tmA.ValueFromIndex[j+1] then
    tmA.Exchange(j,j+1);

 Result:='';
 For i:=0 to tmA.Count-1 do
  Result:=Result+'-'+tmA.Names[i];
//Result:='0=0';
end;

function About: WideString; stdcall;
begin
  Result := PChar('mY 4.4');
end;

exports
  About,
  Execute;


begin
end.
