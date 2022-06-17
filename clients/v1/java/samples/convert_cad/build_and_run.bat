@echo off

echo [INFO] Removing old files
del /F /Q *.class 2>NUL
del /F /Q result.pdf 2>NUL

echo [INFO] Starting Build
javac -cp "..\..\client\lib\*;." *.java

if errorlevel 1 (
   echo [ERROR] Compilation failed
   exit /b
)
echo [INFO] Executable created successfully

echo [INFO] Running 
java -cp "..\..\client\lib\*;." sample