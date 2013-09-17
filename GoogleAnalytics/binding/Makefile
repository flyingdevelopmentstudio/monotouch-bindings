MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

all: GoogleAnalytics.dll

GoogleAnalyticsiOS_2.0beta4.zip:
	curl -O http://dl.google.com/dl/gaformobileapps/GoogleAnalyticsiOS_2.0beta4.zip

libGoogleAnalytics.a: GoogleAnalyticsiOS_2.0beta4.zip
	unzip -p $< 'GoogleAnalyticsiOS_2.0beta4/Library/libGoogleAnalytics.a' > $@

GoogleAnalytics.dll: Makefile libGoogleAnalytics.a
	$(MONOXBUILD) /p:Configuration=Release Googleanalytics.csproj
	cp bin/Release/GoogleAnalytics.dll GoogleAnalytics.dll
	
clean:
	-rm -rf bin obj *.a *.dll *.zip