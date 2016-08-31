#!/usr/bin/env bash

go build -buildmode=c-archive -o libdotnet.a .
gcc -shared -o libdotnet.dylib -L. -ldotnet
mcs -out:program.exe Program.cs
