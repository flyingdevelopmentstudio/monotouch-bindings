BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=2.0.12
# UseerVoice SDK Version 2.0.12

all: UserVoice.dll

UserVoice.dll: Makefile libUserVoice.linkwith.cs ApiDefinition.cs StructsAndEnums.cs libUserVoice.a
	$(MONOXBUILD) /p:Configuration=Release UserVoice.csproj
	cp bin/Release/UserVoice.dll UserVoice.dll

clean:
	-rm -rf list ios bin/ obj/ *.dll *.o *.mdb 
