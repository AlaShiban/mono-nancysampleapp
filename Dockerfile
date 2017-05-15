FROM frolvlad/alpine-mono
ADD . /src
WORKDIR /src
RUN xbuild /p:Configuration=Release
CMD [ "mono", "/src/Mono-MyFirstNancy/bin/Debug/Mono-MyFirstNancy.exe" ]
