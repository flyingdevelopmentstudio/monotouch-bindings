BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=3.1.2
# UserVoice SDK Version 3.1.2

all: UserVoice.dll

UserVoice.dll: Makefile libUserVoice.linkwith.cs ApiDefinition.cs StructsAndEnums.cs libUserVoice.a
	$(MONOXBUILD) /p:Configuration=Release UserVoice.csproj
	cp bin/Release/UserVoice.dll UserVoice.dll

clean:
	-rm -rf list ios bin/ obj/ *.dll *.o *.mdb 
