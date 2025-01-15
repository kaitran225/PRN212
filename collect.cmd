@echo off
set "sourceDir=%cd%"
set "targetDir=%cd%\AllExeFiles"

if not exist "%targetDir%" mkdir "%targetDir%"

for /r "%sourceDir%" %%F in (*.exe) do (
    echo Copying "%%F" to "%targetDir%"
    copy "%%F" "%targetDir%"
)

echo All .exe files have been copied to "%targetDir%".
pause