FROM mono
ADD . /src
WORKDIR /src
RUN mono nuget.exe restore
RUN xbuild /p:Configuration=Release
CMD [ "mono", "/src/Mono-MyFirstNancy/bin/Release/Mono-MyFirstNancy.exe" ]
