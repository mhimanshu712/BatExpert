 
COLOR 22

echo StrText="yo man">spk.vbs
echo set ObjVoice=CreateObject("SAPI.SpVoice") >> spk.vbs
echo ObjVoice.Speak StrText >> spk.vbs
start spk.vbs