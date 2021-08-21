@echo off
title Aula 02 - Atividade Randomicos
mode 60,30
color 0a

:nome
cls
set /a vit=0
set /a per=0
set /a emp=0
set /p nome="Digite seu nome:"
goto:menu

:menu
cls
set /a maq=(%random% %%5) + 1
echo ==================================
echo            Jo-Ken-Po++
echo ==================================
echo.
echo   Ola %nome%, boa sorte HAHA
echo   Tente a sorte contra a MAQUINA
echo ----------------------------------
echo Numero de vitorias: %vit% 
echo Numero de derrotas: %per% 
echo Numero de empates : %emp% 
echo ----------------------------------
echo.
echo [1] - Pedra
echo [2] - Papel
echo [3] - Tesoura
echo [4] - Lagarto
echo [5] - Spock
echo [R] - Regras
echo [S] - Sair

set /p op=Digite sua opcao:
if /i %op% equ 1 (goto:pedra)
if /i %op% equ 2 (goto:papel)
if /i %op% equ 3 (goto:tesoura)
if /i %op% equ 4 (goto:lagarto)
if /i %op% equ 5 (goto:spock)
if /i %op% equ R (goto:regras)
if /i %op% equ S (goto:sair) else (
    echo.
    echo ======================
    echo    Opcao Invalida!
    pause > nul
    goto:menu)

:regras
echo - Tesoura corta papel
echo - Papel cobre pedra
echo - Pedra esmaga lagarto
echo - Lagarto envenena Spock
echo - Spock derrete tesoura
echo - Tesoura decapita lagarto
echo - Lagarto come papel
echo - Papel refuta Spock
echo - Spock vaporiza pedra
echo - Pedra amassa tesoura
echo =========================
pause > nul
goto:menu

:sair
set /p resp=Deseja realmente sair? [S/N]
if /i %resp% == n (goto:menu) else (exit) 

:escolha
set /p resp=Deseja jogar novamente? [S/N]
if /i %resp% == s (goto:menu) else (goto:nome)

:pedra
if %maq% == 1 (
echo.
echo ===================
echo Pedra X Pedra
echo Pedra empata pedra!
set /a emp=%emp% + 1) 
if %maq% == 2 (
echo.
echo ===================
echo Pedra X Papel
echo Papel cobre pedra! 
set /a per=%per% + 1) 
if %maq% == 3 (
echo.
echo ===================
echo Pedra X Tesoura
echo Pedra amassa tesoura! 
set /a vit=%vit% + 1) 
if %maq% == 4 (
echo.
echo ===================
echo Pedra X Lagarto
echo Pedra esmaga lagarto! 
set /a vit=%vit% + 1) 
if %maq% == 5 (
echo.
echo ===================
echo Pedra X Spock
echo Spock vaporiza pedra!
set /a per=%per% + 1)
pause > nul
goto:escolha

:papel
if %maq% == 1 (
echo.
echo ===================
echo Papel X Pedra
echo Papel cobre pedra! 
set /a vit=%vit% + 1)
if %maq% == 2 (
echo.
echo ===================
echo Papel X Papel
echo Papel empata papel! 
set /a emp=%emp% + 1) 
if %maq% == 3 (
echo.
echo ===================
echo Papel X Tesoura
echo Tesoura corta papel! 
set /a per=%per% + 1) 
if %maq% == 4 (
echo.
echo ===================
echo Papel X Lagarto
echo Lagarto come papel! 
set /a per=%per% + 1)
if %maq% == 5 (
echo.
echo ===================
echo Papel X Spock
echo Papel refuta spock!
set /a vit=%vit% + 1)
pause > nul
goto:escolha

:tesoura
if %maq% == 1 (
echo.
echo ===================
echo Tesoura X Pedra
echo Pedra quebra tesoura!
set /a per=%per% + 1) 
if %maq% == 2 (
echo.
echo ===================
echo Tesoura X papel
echo Tesoura corta papel! 
set /a vit=%vit% + 1) 
if %maq% == 3 (
echo.
echo ===================
echo Tesoura X Tesoura
echo Tesoura empata tesoura! 
set /a emp=%emp% + 1) 
if %maq% == 4 (
echo.
echo ===================
echo Tesoura X Lagarto
echo Tesoura decapita lagarto!
set /a vit=%vit% + 1) 
if %maq% == 5 (
echo.
echo ===================
echo Tesoura X Spock
echo Spock derrete tesoura!
set /a per=%per% + 1)
pause > nul
goto:escolha

:lagarto
if %maq% == 1 (
echo.
echo ===================
echo Lagarto X Pedra
echo Pedra esmaga lagarto!
set /a per=%per% + 1)
if %maq% == 2 (
echo.
echo ===================
echo Lagarto X papel
echo Lagarto come papel! 
set /a vit=%vit% + 1) 
if %maq% == 3 (
echo.
echo ===================
echo Lagarto X Tesoura
echo Tesoura decapita lagarto!
set /a per=%per% + 1) 
if %maq% == 4 (
echo.
echo ===================
echo Lagarto X Lagarto
echo Lagarto empata lagarto!
set /a emp=%emp% + 1)
if %maq% == 5 (
echo.
echo ===================
echo Lagarto X Spock
echo Lagarto envenena spock!
set /a vit=%vit% + 1) 
pause > nul
goto:escolha

:spock
if %maq% == 1 (
echo.
echo ===================
echo Spock X Pedra
echo Spock vaporiza pedra!
set /a vit=%vit% + 1) 
if %maq% == 2 (
echo.
echo ===================
echo Spock X papel
echo Papel refuta spock! 
set /a per=%per% + 1) 
if %maq% == 3 (
echo.
echo ===================
echo Spock X Tesoura
echo Spock derrete tesoura!
set /a vit=%vit% + 1) 
if %maq% == 4 (
echo.
echo ===================
echo Spock X Lagarto
echo Lagarto envenena spock! 
set /a per=%per% + 1) 
if %maq% == 5 (
echo.
echo ===================
echo Spock X Spock
echo Spock empata spock!
set /a emp=%emp% + 1)
pause > nul
goto:escolha

