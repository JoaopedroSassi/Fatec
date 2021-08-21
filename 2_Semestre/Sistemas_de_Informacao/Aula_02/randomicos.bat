@echo off
title Aula 02 - Numeros Randomicos
mode 60,30
color 0a
set /a cont=0

:sortear
cls
set /a numero=(%random% %%100) + 1
set /a cont=%cont% + 1
echo.
echo ------------------------------------
echo Numero Sorteado foi: %numero%
echo Quantidade de sorteios: %cont%
echo ------------------------------------
echo.
pause > nul
echo.
set /p resp=Deseja sortear um novo numero? [S/N]:
if /i %resp% == s (goto:sortear) else (exit)

