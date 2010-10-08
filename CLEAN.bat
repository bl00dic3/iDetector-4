@echo off
title CLEAN.BAT - iDetector 4

del %CD%\bin\*.*

del %CD%\src\bin\Release\*.*
del %CD%\src\bin\Debug\*.*

del %CD%\src\obj\x86\Release\*.exe
del %CD%\src\obj\x86\Release\*.pdb
del %CD%\src\obj\x86\Release\*.xml

del %CD%\src\obj\x86\Debug\*.exe
del %CD%\src\obj\x86\Debug\*.pdb
del %CD%\src\obj\x86\Debug\*.xml

echo.
echo Done!
echo.
pause