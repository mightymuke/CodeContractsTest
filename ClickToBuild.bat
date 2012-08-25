@echo off
pushd build
call build.bat -D:build.configuration=Release %*
popd
pause